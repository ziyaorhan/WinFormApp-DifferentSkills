using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_DifferentSkills.AppClasses;

namespace WFA_DifferentSkills.AppForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.wbMain.Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // backcolor setting for frmMain
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch
                {
                }
            }
        }

        #region githubApiToolStripMenuItem methods
        private void githubApiToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (Global.wbMainVisibility)
            {
                Global.WebBrowserFill("frmGithubApi.html", this.wbMain);
                wbMain.Visible = true;
            }
        }

        private void githubApiToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
                this.wbMain.Visible = false;
        }

        private void githubApiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGithubApi child = new frmGithubApi(this);
            child.Show();
            Global.wbMainVisibility = false;
           this. wbMain.Visible = false;
        }
        #endregion

        #region createDBToolStripMenuItem methods
        private void createDbToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (Global.wbMainVisibility)
            {
                Global.WebBrowserFill("frmDbCreator.html", this.wbMain);
                this.wbMain.Visible = true;
            }
        }

        private void createDbToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
                this.wbMain.Visible = false;     
        }

        private void createDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDbCreator child = new frmDbCreator(this);
            child.Show();
            Global.wbMainVisibility = false;
            wbMain.Visible = false;
        } 
        #endregion
    }
}
