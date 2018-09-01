using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_DifferentSkills.AppClasses;
using WFA_DifferentSkills.ORM;
using WFA_DifferentSkills.ORM.Manager;

namespace WFA_DifferentSkills.AppForms
{
    public partial class frmGithubApi : Form
    {
        private int status = 0;

        private string QueryText;

        public string queryText
        {
            get { return QueryText; }
            set { QueryText = txtSearch.Text.Trim(); }
        }

        public frmGithubApi(frmMain parent)
        {
            InitializeComponent();
            //for initial
            this.MdiParent = parent;
            this.Text = "Github Api";
            Global.WebBrowserFill("frmGithubApi.html", this.wbDescription);
        }

        #region Initial Methods
        private void frmGithubApi_Load(object sender, EventArgs e)
        {
            if (Validation.IsOpenForm(this))
                this.Close();
        }

        private void frmGithubApi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.wbMainVisibility = true;
            Global.openForms.Remove(this.Name.ToString());
        }
        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(queryText))
            {
                Cursor.Current = Cursors.WaitCursor;
                //the database is checked... 
                using (DatabaseContext db = new DatabaseContext())
                {
                    lblStatus.Text = "Checking the database...";
                    List<GithubUser> result = (from i in db.GithubUser
                                               where i.Login == queryText
                                               select i).ToList();
                    status = result.Count;  // it is true if it is not zero.
                }
                if (status != 0)
                {
                    lblStatus.Text = "Getting data from the database...";
                    GetUserAndRepo();
                }
                else
                {
                    lblStatus.Text = "Getting data from Github ...";
                    //insert from api to db.
                    using (DatabaseContext db = new DatabaseContext())
                    {
                        try
                        {
                            string repoUrl = "https://api.github.com/users/" + queryText + "/repos";
                            List<GithubRepoForJson> repos = Global.GetDeserializeJson<List<GithubRepoForJson>>(repoUrl);
                            lblStatus.Text = "Saving data to the database...";
                            List<GithubRepository> reposForUser = new List<GithubRepository>();
                            foreach (GithubRepoForJson repo in repos)
                            {
                                GithubRepository r = new GithubRepository();
                                r.FullName = repo.full_name;
                                r.CreatedAt = repo.created_at;
                                r.DownloadUrl = "https://github.com/" + repo.full_name + "/archive/master.zip";
                                reposForUser.Add(r);
                            }
                            //
                            string userUrl = "https://api.github.com/users/" + queryText;
                            GithubUserForJson user = Global.GetDeserializeJson<GithubUserForJson>(userUrl);
                            GithubUser u = new GithubUser();
                            u.Login = user.login;
                            u.HtmlUrl = user.html_url;
                            u.Name = user.name;
                            u.AvatarUrl = user.avatar_url;
                            u.Followers = user.followers;
                            u.Following = user.following;
                            u.Repository = reposForUser;
                            db.GithubUser.Add(u);
                            db.SaveChanges();
                            //select from db
                            lblStatus.Text = "Getting data from the database...";
                            GetUserAndRepo();
                        }
                        catch
                        {
                            MessageBox.Show("Error! Github user was not found. Please try again...");
                            lblStatus.Text = "Unsuccessful...";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Warning! Please enter a Github \"Login Name\"...");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            queryText = txtSearch.ToString().Trim();
            lblStatus.Text = "";
        }

        private void dgvRepos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (columnIndex != 4)//User column was used as a button.
                return;
            if (rowIndex == -1)
                return;
            string downloadUrl = Convert.ToString(dgvRepos["DownloadUrl", rowIndex].Value);
            if (!String.IsNullOrEmpty(downloadUrl))
                Process.Start(downloadUrl);
        }

        private void dgvRepos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (columnIndex == 4)   // User column was used as a button.
            {
                e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionBackColor = Color.White;
                e.CellStyle.SelectionForeColor = Color.Green;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.Value = (object)"Download ZIP";
            }
        }

        private void GetUserAndRepo()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                try
                {
                    var user = (from i in db.GithubUser
                                where i.Login == queryText
                                select new
                                {
                                    i.Name,
                                    i.HtmlUrl,
                                    i.Followers,
                                    i.Following,
                                    i.AvatarUrl,
                                    i.Repository
                                }).FirstOrDefault();
                    //user select
                    lblName.Text = user.Name;
                    lblHtmlUrl.Text = user.HtmlUrl;
                    lblFollowers.Text = user.Followers.ToString();
                    lblFollowing.Text = user.Following.ToString();
                    pbResim.Load(user.AvatarUrl.ToString());
                    //repo select
                    dgvRepos.DataSource = user.Repository.ToList();
                    //settings
                    dgvRepos.Columns["FullName"].HeaderText = "Repository Name";
                    dgvRepos.Columns["CreatedAt"].HeaderText = "Created At";
                    dgvRepos.Columns["User"].HeaderText = "Download As Zip";// User column was used as a button.
                    dgvRepos.Columns["Id"].Visible = false;
                    dgvRepos.Columns["DownloadUrl"].Visible = false;
                    //dgvRepos.Columns["CreatedAt"].SortMode= DataGridViewColumnSortMode.Automatic;
                    lblStatus.Text = "Completed...";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Please check your internet connection..." + Environment.NewLine+"Exception: "+ex.Message);
                    lblStatus.Text = "Operation failed!";
                }
            }
        }
    }
}
