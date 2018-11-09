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
using WFA_DifferentSkills.AppClasses;

namespace WFA_DifferentSkills.AppForms
{
    public partial class frmEulerType : Form
    {
        public frmEulerType(frmMain parent)
        {
            InitializeComponent();
            //initial
            this.MdiParent = parent;
            this.Text = "Euler Type Algorithm";
            Global.WebBrowserFill("frmEulerType.html", this.wbDescription);
            //for this project
            ofdForNumberFile.Filter = "Text File |*.txt";
        }

        #region initial methods
        private void frmEulerType_Load(object sender, EventArgs e)
        {
            if (Validation.IsOpenForm(this))
                this.Close();
        }

        private void frmEulerType_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.wbMainVisibility = true;
            Global.openForms.Remove(this.Name.ToString());
        }
        #endregion

        #region Tab-1
        private void btnCreateTbl_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != string.Empty)
            {
                if (Convert.ToInt32(txtNumber.Text) == 0 || Convert.ToInt32(txtNumber.Text) > 15)
                {
                    lblWarning.Text = "* Ente a number between 1 and 15...";
                    txtMultiplicationTbl.Clear();
                }
                //çarpım tablosu oluştur.
                else
                {
                    int sayi = Convert.ToInt32(txtNumber.Text);
                    string multiplicationTbl = 0 + "   ";
                    int i;
                    int k = 1;
                    for (i = 1; i <= sayi; i++)
                    {
                        for (int j = 1; j <= sayi; j++)
                        {
                            multiplicationTbl += (k * j) + "   ";
                        }
                        multiplicationTbl += Environment.NewLine;
                        multiplicationTbl += Environment.NewLine;
                        multiplicationTbl += i + "   ";
                        k = i;
                    }
                    for (int z = 1; z <= sayi; z++)
                    {
                        multiplicationTbl += (k * z) + "   ";
                    }
                    txtMultiplicationTbl.Text = multiplicationTbl;
                }
            }
        }
        #endregion

        #region Tab-2
        List<double> numbers = new List<double>();
        public bool status { get; set; }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            lstSequentialNumber.Items.Clear();
            if (ofdForNumberFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofdForNumberFile.SafeFileName;
                string filePath = ofdForNumberFile.FileName;
                MessageBox.Show(filePath);
                FileInfo fileInfo = new FileInfo(filePath);
                string fileExtension = fileInfo.Extension;
                lblFilePath.Text = filePath;
                try
                {
                    if (fileExtension != ".txt")
                    {
                        lblFilePath.Text = "Warning! Please select a file with extension .txt";
                    }
                    else
                    {
                        FileStream file = new FileStream(filePath, FileMode.Open);
                        StreamReader fileReader = new StreamReader(file);
                        string contentLine;
                        string number = "";
                        while ((contentLine = fileReader.ReadLine()) != null)
                        {
                            foreach (char ch in contentLine)
                            {
                                if (Char.IsWhiteSpace(ch) == false)
                                {
                                    number += ch.ToString();
                                    status = true;
                                }
                                else
                                {
                                    status = false;
                                    if (status == false && number != String.Empty)
                                    {
                                        lstSequentialNumber.Items.Add(number.ToString());
                                        numbers.Add(Convert.ToDouble(number));
                                        number = string.Empty;
                                    }
                                }
                            }
                        }
                        lstSequentialNumber.Items.Add(number.ToString());
                        numbers.Add(Convert.ToDouble(number));
                        number = string.Empty;
                        fileReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    lblFilePath.Text = ex.Message.ToString() + Environment.NewLine + "Danger! In the file should be just number";
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstSequentialNumber.Items.Clear();
            numbers.Sort();
            numbers.Reverse();
            foreach (double item in numbers)
            {
                lstSequentialNumber.Items.Add(item.ToString());
            }
        }
        #endregion

        #region Tab-3
        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int firstNumber = 0;    // 1.fibonacci
            int secondNumber = 1; // 2.fibonacci
            int result = 0;
            if (txtQueue.Text != String.Empty)
            {
                int siraNo = int.Parse(txtQueue.Text);

                for (int i = 3; i <= siraNo; i++)//3.'den istenene kadar.
                {
                    // 0,   1,  1,  2,  3,  5
                    //firts second
                    //     firts second
                    result = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = result;
                }
                txtFibonacci.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }
        #endregion


    }
}
