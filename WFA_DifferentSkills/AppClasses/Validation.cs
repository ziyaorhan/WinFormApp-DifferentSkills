using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DifferentSkills.AppClasses
{
    public static class Validation
    {
        public static bool IsOpenForm(Form frm)
        {
            bool returnValue = false;
            try
            {
                Global.openForms.Add(frm.Name.ToString());
                int counter = 0;
                foreach (string frmName in Global.openForms)
                {
                    if (frmName == frm.Name.ToString())
                        counter++;
                }
                if (counter > 1)//to prevent multiple opening of the same form
                    returnValue = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! "+ex.Message);
            }
            return returnValue;
        }
    }
}
