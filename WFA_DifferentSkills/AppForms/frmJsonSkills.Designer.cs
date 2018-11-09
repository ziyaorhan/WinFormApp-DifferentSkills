namespace WFA_DifferentSkills.AppForms
{
    partial class frmJsonSkills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbDescription = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnListFromJsonFile = new System.Windows.Forms.Button();
            this.cbJsonFiles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateJsonFile = new System.Windows.Forms.Button();
            this.txtJsonFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnClearInputs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbDescription
            // 
            this.wbDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbDescription.Location = new System.Drawing.Point(0, 0);
            this.wbDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDescription.Name = "wbDescription";
            this.wbDescription.Size = new System.Drawing.Size(385, 504);
            this.wbDescription.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(385, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 504);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "JSON-1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvList);
            this.groupBox4.Location = new System.Drawing.Point(6, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(617, 312);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 16);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.Size = new System.Drawing.Size(611, 293);
            this.dgvList.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnClearList);
            this.groupBox3.Controls.Add(this.btnListFromJsonFile);
            this.groupBox3.Controls.Add(this.cbJsonFiles);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(320, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 73);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3-List From Json File";
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(191, 13);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(94, 23);
            this.btnClearList.TabIndex = 11;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnListFromJsonFile
            // 
            this.btnListFromJsonFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListFromJsonFile.Location = new System.Drawing.Point(191, 41);
            this.btnListFromJsonFile.Name = "btnListFromJsonFile";
            this.btnListFromJsonFile.Size = new System.Drawing.Size(94, 23);
            this.btnListFromJsonFile.TabIndex = 8;
            this.btnListFromJsonFile.Text = "Lists";
            this.btnListFromJsonFile.UseVisualStyleBackColor = true;
            this.btnListFromJsonFile.Click += new System.EventHandler(this.btnListFromJsonFile_Click);
            // 
            // cbJsonFiles
            // 
            this.cbJsonFiles.FormattingEnabled = true;
            this.cbJsonFiles.Location = new System.Drawing.Point(97, 31);
            this.cbJsonFiles.Name = "cbJsonFiles";
            this.cbJsonFiles.Size = new System.Drawing.Size(82, 21);
            this.cbJsonFiles.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Select File:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCreateJsonFile);
            this.groupBox2.Controls.Add(this.txtJsonFileName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(320, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 67);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2-Create Json File";
            // 
            // btnCreateJsonFile
            // 
            this.btnCreateJsonFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateJsonFile.Location = new System.Drawing.Point(191, 16);
            this.btnCreateJsonFile.Name = "btnCreateJsonFile";
            this.btnCreateJsonFile.Size = new System.Drawing.Size(94, 23);
            this.btnCreateJsonFile.TabIndex = 1;
            this.btnCreateJsonFile.Text = "Create ";
            this.btnCreateJsonFile.UseVisualStyleBackColor = true;
            this.btnCreateJsonFile.Click += new System.EventHandler(this.btnCreateJsonFile_Click);
            // 
            // txtJsonFileName
            // 
            this.txtJsonFileName.Location = new System.Drawing.Point(97, 18);
            this.txtJsonFileName.Name = "txtJsonFileName";
            this.txtJsonFileName.Size = new System.Drawing.Size(82, 20);
            this.txtJsonFileName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Json File Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFatherName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.btnClearInputs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.txtMotherName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 147);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1-Create Virtual List";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(97, 118);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(82, 20);
            this.txtFatherName.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(82, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(97, 47);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(82, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Father Name:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(97, 72);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(82, 20);
            this.txtAge.TabIndex = 2;
            // 
            // btnClearInputs
            // 
            this.btnClearInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInputs.Location = new System.Drawing.Point(195, 115);
            this.btnClearInputs.Name = "btnClearInputs";
            this.btnClearInputs.Size = new System.Drawing.Size(92, 23);
            this.btnClearInputs.TabIndex = 6;
            this.btnClearInputs.Text = "Clear Inputs";
            this.btnClearInputs.UseVisualStyleBackColor = true;
            this.btnClearInputs.Click += new System.EventHandler(this.btnClearInputs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mother Name:";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToList.Location = new System.Drawing.Point(195, 86);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(92, 23);
            this.btnAddToList.TabIndex = 5;
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(97, 95);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(82, 20);
            this.txtMotherName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname:";
            // 
            // frmJsonSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1022, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.wbDescription);
            this.Name = "frmJsonSkills";
            this.Text = "frmJsonSkills";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmJsonSkills_FormClosed);
            this.Load += new System.EventHandler(this.frmJsonSkills_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbDescription;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnListFromJsonFile;
        private System.Windows.Forms.ComboBox cbJsonFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateJsonFile;
        private System.Windows.Forms.TextBox txtJsonFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnClearInputs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}