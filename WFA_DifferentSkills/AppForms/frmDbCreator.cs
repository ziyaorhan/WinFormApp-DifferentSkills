using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_DifferentSkills.AppClasses;
using WFA_DifferentSkills.ORM.Manager;

namespace WFA_DifferentSkills.AppForms
{
    public partial class frmDbCreator : Form
    {
        public frmDbCreator(frmMain parent)
        {
            InitializeComponent();
            //for initial
            this.MdiParent = parent;
            this.Text = "Veri Tabanı Kurulumu";
            Global.WebBrowserFill("frmDbCreator.html", this.wbDescription);
            //for project
            rbDefault.Checked = true;
            btnEnd.Enabled = false;
        }

        #region Initial Methods
        private void frmDbCreator_Load(object sender, EventArgs e)
        {
           if(Validation.IsOpenForm(this))
                this.Close();
        }

        private void frmDbCreator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.wbMainVisibility = true;
            Global.openForms.Remove(this.Name.ToString());
        }
        #endregion

        private void rbDefault_CheckedChanged(object sender, EventArgs e)
        {
            txtServer.Text = "localhost";
            txtDatabase.Text = "WFASkillsDB";
            txtUserId.Text = "sa";
            txtPassword.Text = "123";
            txtServer.Enabled = false;
            txtDatabase.Enabled = false;
            txtUserId.Enabled = false;
        }

        private void rbCustomize_CheckedChanged(object sender, EventArgs e)
        {
            txtServer.Text = "";
            txtDatabase.Text = "";
            txtUserId.Text = "";
            txtPassword.Text = "";
            txtServer.Enabled = true;
            txtDatabase.Enabled = true;
            txtUserId.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string connStr = "";
            string infoStr = "";
            ClickDisabled();
            if (!String.IsNullOrWhiteSpace(txtServer.Text) && !String.IsNullOrWhiteSpace(txtUserId.Text) && !String.IsNullOrWhiteSpace(txtPassword.Text) && !String.IsNullOrWhiteSpace(txtDatabase.Text))
            {
                connStr = DatabaseOperations.SqlConnStrBuilder(txtServer.Text.Trim(), txtUserId.Text.Trim(), txtPassword.Text.Trim(), txtDatabase.Text.Trim());
                //rbDefault.Checked and I have not a database
                if (rbDefault.Checked == true)
                {
                    if (!DatabaseOperations.IsThereADbInLocal(txtDatabase.Text.Trim()))
                    {
                        if (DatabaseOperations.UpdateConnStrInAppConfig(connStr))
                        {
                            if (DatabaseOperations.CreateDbToLocalHost(txtDatabase.Text.Trim()))
                            {
                                Executor();
                            }
                            else
                            {
                                infoStr = "Uyarı! " + txtDatabase.Text.Trim() + " adında veritabanı create edilirken bir hata oluştu. Lütfen tekrar deneyiniz.";
                            }
                        }
                        else
                        {
                            infoStr = "Uyarı! App.config dosyasında Connection String oluşturulurken bir hata oluştu. Lütfen tekrar deneyiniz.";
                        }
                    }
                    else
                    {
                        infoStr = "Uyarı! Bu yöntemde WFASkillsDB adında bir veri tabanının olmadığı kabul edilir. Lütfen ilgili veritabanını siliniz.";

                    }

                    #region MyRegion
                    ////1-update connection string in App.config file
                    ////(Server=.;Database=WFASkillsDB;User Id=sa;password=txtPassword.Text)
                    //string connStr = DatabaseOperations.SqlConnStrBuilder(password: txtPassword.Text.Trim());
                    //bool isUpdateAppCfg = DatabaseOperations.UpdateConnStrInAppConfig(connStr);
                    //if (isUpdateAppCfg)
                    //{
                    //    //2-create new database via master(System Database) database
                    //    bool isCreated = DatabaseOperations.CreateDbToLocalHost(txtDatabase.Text.Trim(), DatabaseOperations.IsThereADbInLocal(txtDatabase.Text.Trim()));
                    //    if (isCreated)
                    //    {
                    //        //sql script execute 
                    //        Executor();
                    //    }
                    //} 
                    #endregion
                }
                // rbCustomize.Checked and I have a database
                else
                {
                    if (DatabaseOperations.IsThereAConnection(connStr))
                    {
                        if (DatabaseOperations.UpdateConnStrInAppConfig(connStr))
                        {
                            //sql script execute
                            Executor();
                        }
                        else
                        {
                            infoStr = "Uyarı! Connection String verileri App.Config dosyasına yazılırken bir hata oluştu.";
                        }
                    }
                    else
                    {
                        infoStr = "Uyarı! Girmiş olduğunuz bilgilerle veri tabanına bağlanılamadı.";
                    }
                }
            }
            else
            {
                infoStr = "Uyarı! Lütfen tüm alanları doldurunuz.";
            }

            if (infoStr != "")
            {
                MessageBox.Show(infoStr);
                ClickEnabled();
            }
            else
            {
                ClickDisabled();
                btnEnd.Enabled = true;
                btnEnd.BackColor = Color.LightGreen;
            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClickDisabled()
        {
            Cursor.Current = Cursors.WaitCursor;
            gb1.Enabled = false;
            gb2.Enabled = false;
            btnStart.Enabled = false;
        }

        private void ClickEnabled()
        {
            Cursor.Current = Cursors.Default;
            gb1.Enabled = true;
            gb2.Enabled = true;
            btnStart.Enabled = true;
        }

        private void Executor()
        {

            if (!String.IsNullOrEmpty(DatabaseOperations.GetConnStrFromAppConfig()))
            {
                StatusOfExecutedSqlCmd status = DatabaseOperations.DBExecutorFromSqlFile(DatabaseOperations.GetConnStrFromAppConfig(), "Northwind", txtDatabase.Text.Trim());
                //area of status info 
                if (status != null)
                {
                    txtStatus.Text = status.SetupStatusStr;
                    txtExecuted.Text = status.ExecutedCmdCount.ToString();
                    txtUnExec.Text = status.UnexecutedCmdCount.ToString();
                    dgvErrorCmd.DataSource = status.PrbSqlCmdLst.ToList();
                    dgvErrorCmd.Columns["LineNoByPaternOrder"].Width = 27;
                    dgvErrorCmd.Columns["SqlExpression"].Width = 330;
                    dgvErrorCmd.Columns["LineNoByPaternOrder"].HeaderText = "GO No:";
                    dgvErrorCmd.Columns["SqlExpression"].HeaderText = "Execute Edilemeyen Sql İfade:";

                    //Execute other db
                    DatabaseContext context = new DatabaseContext();
                    var db = context.GithubUser.ToList();
                }
            }
        }
    }
}
