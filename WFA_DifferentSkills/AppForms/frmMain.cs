﻿using System;
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

        #region xmlToolStripMenuItem methods
        private void xMLToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (Global.wbMainVisibility)
            {
                Global.WebBrowserFill("frmXmlSkills.html", this.wbMain);
                this.wbMain.Visible = true;
            }
        }

        private void xMLToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.wbMain.Visible = false;
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXmlSkills child = new frmXmlSkills(this);
            child.Show();
            Global.wbMainVisibility = false;
            wbMain.Visible = false;
        }
        #endregion

        #region jSONToolStripMenuItem methods
        private void jSONToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (Global.wbMainVisibility)
            {
                Global.WebBrowserFill("frmJsonSkills.html", this.wbMain);
                this.wbMain.Visible = true;
            }
        }

        private void jSONToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.wbMain.Visible = false;
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJsonSkills child = new frmJsonSkills(this);
            child.Show();
            Global.wbMainVisibility = false;
            wbMain.Visible = false;
        }
        #endregion

        #region eULERTYPEToolStripMenuItem
        private void eULERTYPEToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (Global.wbMainVisibility)
            {
                Global.WebBrowserFill("frmEulerType.html", this.wbMain);
                this.wbMain.Visible = true;
            }
        }

        private void eULERTYPEToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.wbMain.Visible = false;
        }

        private void eULERTYPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEulerType child = new frmEulerType(this);
            child.Show();
            Global.wbMainVisibility = false;
            wbMain.Visible = false;
        }
        #endregion

        #region hTMLPARSEToolStripMenuItem
        private void hTMLPARSEToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (Global.wbMainVisibility)
            {
                Global.WebBrowserFill("frmHtmlParse.html", this.wbMain);
                wbMain.Visible = true;
            }
        }

        private void hTMLPARSEToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.wbMain.Visible = false;
        }

        private void hTMLPARSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHtmlParse child = new frmHtmlParse(this);
            child.Show();
            Global.wbMainVisibility = false;
            wbMain.Visible = false;
        } 
        #endregion

    }
}
