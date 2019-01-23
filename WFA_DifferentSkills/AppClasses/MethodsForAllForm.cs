using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WFA_DifferentSkills.AppClasses
{
    abstract class MethodsForAllForm : Form
    {
        public abstract void onClick(EventHandler evnt);
    }
}
