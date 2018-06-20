using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_DifferentSkills.AppForms;
using WFA_DifferentSkills.ORM.Manager;
//
namespace WFA_DifferentSkills
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseContext context = new DatabaseContext();
            var db=context.GithubUser.ToList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
