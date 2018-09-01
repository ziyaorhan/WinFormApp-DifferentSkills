using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web.Script.Serialization;
using Newtonsoft;
using WFA_DifferentSkills.AppClasses;
using System.Diagnostics;

namespace WFA_DifferentSkills.AppForms
{
    public partial class frmJsonSkills : Form
    {
        private List<JsonTemlate> persons;
        public string jsonFolderPath;
        public frmJsonSkills(frmMain parent)
        {
            //for initial
            InitializeComponent();
            this.MdiParent = parent;
            this.Text = "JSON Operations";
            Global.WebBrowserFill("", this.wbDescription);

            //for this project
            persons = new List<JsonTemlate>();
            jsonFolderPath = Global.GetPath("\\Files\\JSON");

            FillComboboxJsonFiles();

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

        private void FillComboboxJsonFiles()
        {
            DirectoryInfo folder = new DirectoryInfo(jsonFolderPath);
            FileInfo[] files = folder.GetFiles();
            cbJsonFiles.Items.Clear();
            foreach (FileInfo file in files)
            {
                cbJsonFiles.Items.Add(file.Name);
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text) && !String.IsNullOrWhiteSpace(txtSurname.Text) && !String.IsNullOrWhiteSpace(txtAge.Text) && !String.IsNullOrWhiteSpace(txtMotherName.Text) && !String.IsNullOrWhiteSpace(txtFatherName.Text))
            {
                JsonTemlate person = new JsonTemlate();
                person.Name = txtName.Text;
                person.Surname = txtSurname.Text;
                person.Age = txtAge.Text;
                person.MotherName = txtMotherName.Text;
                person.FatherName = txtFatherName.Text;
                if (person.ToString() != "")
                    persons.Add(person);
                dgvList.DataSource = null;  //this is important
                dgvList.DataSource = persons;
            }
            else
            {
                List<TextBox> inputTextBoxes = new List<TextBox>() { txtName, txtSurname, txtAge, txtMotherName, txtFatherName };
                foreach (TextBox txt in inputTextBoxes)
                {
                    if (String.IsNullOrWhiteSpace(txt.Text))
                        txt.Focus();
                }
            }
        }

        private void btnClearInputs_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtAge.Text = "";
            txtMotherName.Text = "";
            txtFatherName.Text = "";
            txtName.Focus();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = null;
            persons.Clear();
        }

        private void btnCreateJsonFile_Click(object sender, EventArgs e)
        {
            if (dgvList.DataSource != null && txtJsonFileName.Text != String.Empty)
            {
                string jsonText = Newtonsoft.Json.JsonConvert.SerializeObject(persons);
                string jsonFileName = txtJsonFileName.Text;
                string jsonFilePath = jsonFolderPath + "\\" + jsonFileName + ".json";
                if (!File.Exists(jsonFilePath))//create if not
                {
                    FileStream fs = File.Create(jsonFilePath);
                    fs.Dispose();
                }
                StreamWriter sw = new StreamWriter(jsonFilePath);
                sw.WriteLine(jsonText);
                sw.Close();
                sw.Dispose();
                MessageBox.Show("Info! The json file was created successfully...");
                FillComboboxJsonFiles();
            }
            else
            {
                MessageBox.Show("Warning! First, create a virtual list. Then enter the file name.");
            }
        }

        private void btnListFromJsonFile_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedFileText = cbJsonFiles.SelectedItem.ToString();
                string filePath = jsonFolderPath + "\\" + selectedFileText;
                string[] jsonTextAsArray = File.ReadAllLines(filePath);
                string jsonText = "";
                foreach (string line in jsonTextAsArray)
                {
                    jsonText += line;
                }
                List<JsonTemlate> deserializeJsonList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JsonTemlate>>(jsonText);
                dgvList.DataSource = deserializeJsonList;
            }
            catch
            {
                return;
            }
        }
    }
    public class JsonTemlate
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname + " " + Age + " " + MotherName + " " + FatherName;
        }
    }
}
