using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_DifferentSkills.AppClasses;

namespace WFA_DifferentSkills.AppForms
{
    public partial class frmJsonSkills : Form
    {
        public frmJsonSkills(frmMain parent)
        {
            //for initial
            InitializeComponent();
            this.MdiParent = parent;
            this.Text = "JSON Operations";
            Global.WebBrowserFill("", this.wbDescription);
        }

        #region initial methods
        private void frmJsonSkills_Load(object sender, EventArgs e)
        {
            if (Validation.IsOpenForm(this))
                this.Close();
        }

        private void frmJsonSkills_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.wbMainVisibility = true;
            Global.openForms.Remove(this.Name.ToString());
        } 
        #endregion
    }
}
