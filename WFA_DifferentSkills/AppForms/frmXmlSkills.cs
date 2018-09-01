using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_DifferentSkills.AppClasses;
namespace WFA_DifferentSkills.AppForms
{
    public partial class frmXmlSkills : Form
    {
        private string selectedTable = String.Empty;
        private string selectedXmlFile = String.Empty;
        private string xmlFolderPath;

        public frmXmlSkills(frmMain parent)
        {
            InitializeComponent();
            //for initial
            this.MdiParent = parent;
            this.Text = "XML Operations";
            Global.WebBrowserFill("", this.wbDescription);

            //for this project
            string[] cbNorthTableItems = { "Categories", "Employees", "Orders", "Products" };
            cbNorthwindTable.Items.AddRange(cbNorthTableItems);
            cbNorthwindTable.SelectedIndex = -1;
            FillCbXmlFiles();
        }

        #region Initial Methods
        private void frmXmlSkills_Load(object sender, EventArgs e)
        {
            if (Validation.IsOpenForm(this))
                this.Close();
        }

        private void frmXmlSkills_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.wbMainVisibility = true;
            Global.openForms.Remove(this.Name.ToString());
        }
        #endregion

        private void FillCbXmlFiles()
        {
            xmlFolderPath = Global.GetPath("\\Files\\XML");
            DirectoryInfo XmlFilesInfo = new DirectoryInfo(xmlFolderPath);
            FileInfo[] XmlFiles = XmlFilesInfo.GetFiles();
            cbXmlFiles.Items.Clear();
            foreach (FileInfo file in XmlFiles)
            {
                cbXmlFiles.Items.Add(file.Name);
            }
            cbXmlFiles.SelectedIndex = -1;
        }

        private void btnCreateXmlFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTable != String.Empty)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * From " + selectedTable, DatabaseOperations.GetConnStrFromAppConfig());
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    //
                    string fileName = selectedTable;
                    string fileExtension = ".xml";
                    string fileFullName = Path.Combine(xmlFolderPath, fileName + fileExtension);
                    if (!File.Exists(fileFullName))
                    {
                        FileStream fs = File.Create(fileFullName);
                        fs.Dispose();
                    }
                    MessageBox.Show(fileFullName);
                    ds.WriteXml(fileFullName);
                    FillCbXmlFiles();

                    Process.Start(fileFullName);
                }
                else
                {
                    MessageBox.Show("Warning! Please select the table...");
                }
            }
            catch 
            {

            }
        }

        private void btnListXmlFile_Click(object sender, EventArgs e)
        {
            if (selectedXmlFile != String.Empty)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Global.GetPath("\\Files\\XML\\") + selectedXmlFile);
                dgvXML.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Warning! Please select the XML Files...");
            }
        }

        private void cbNorthwindTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNorthwindTable.SelectedIndex != -1)
                selectedTable = cbNorthwindTable.SelectedItem.ToString();
        }

        private void cbXmlFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbXmlFiles.SelectedIndex != -1)
                selectedXmlFile = cbXmlFiles.SelectedItem.ToString();
        }
    }
}
