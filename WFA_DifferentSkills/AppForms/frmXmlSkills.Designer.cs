namespace WFA_DifferentSkills.AppForms
{
    partial class frmXmlSkills
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNorthwindTable = new System.Windows.Forms.ComboBox();
            this.cbXmlFiles = new System.Windows.Forms.ComboBox();
            this.btnListXmlFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateXmlFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXML = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbDescription
            // 
            this.wbDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbDescription.Location = new System.Drawing.Point(0, 0);
            this.wbDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDescription.Name = "wbDescription";
            this.wbDescription.Size = new System.Drawing.Size(385, 441);
            this.wbDescription.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(385, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 441);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "XML-1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbNorthwindTable);
            this.groupBox1.Controls.Add(this.cbXmlFiles);
            this.groupBox1.Controls.Add(this.btnListXmlFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateXmlFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create XML File From Table AND Read XML From File";
            // 
            // cbNorthwindTable
            // 
            this.cbNorthwindTable.FormattingEnabled = true;
            this.cbNorthwindTable.Location = new System.Drawing.Point(152, 25);
            this.cbNorthwindTable.Name = "cbNorthwindTable";
            this.cbNorthwindTable.Size = new System.Drawing.Size(189, 21);
            this.cbNorthwindTable.TabIndex = 14;
            this.cbNorthwindTable.SelectedIndexChanged += new System.EventHandler(this.cbNorthwindTable_SelectedIndexChanged);
            // 
            // cbXmlFiles
            // 
            this.cbXmlFiles.FormattingEnabled = true;
            this.cbXmlFiles.Location = new System.Drawing.Point(152, 59);
            this.cbXmlFiles.Name = "cbXmlFiles";
            this.cbXmlFiles.Size = new System.Drawing.Size(189, 21);
            this.cbXmlFiles.TabIndex = 14;
            this.cbXmlFiles.SelectedIndexChanged += new System.EventHandler(this.cbXmlFiles_SelectedIndexChanged);
            // 
            // btnListXmlFile
            // 
            this.btnListXmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListXmlFile.BackColor = System.Drawing.Color.White;
            this.btnListXmlFile.Location = new System.Drawing.Point(347, 60);
            this.btnListXmlFile.Name = "btnListXmlFile";
            this.btnListXmlFile.Size = new System.Drawing.Size(136, 21);
            this.btnListXmlFile.TabIndex = 11;
            this.btnListXmlFile.Text = "List From XML File";
            this.btnListXmlFile.UseVisualStyleBackColor = false;
            this.btnListXmlFile.Click += new System.EventHandler(this.btnListXmlFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Table From Northwind:";
            // 
            // btnCreateXmlFile
            // 
            this.btnCreateXmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateXmlFile.BackColor = System.Drawing.Color.White;
            this.btnCreateXmlFile.Location = new System.Drawing.Point(347, 25);
            this.btnCreateXmlFile.Name = "btnCreateXmlFile";
            this.btnCreateXmlFile.Size = new System.Drawing.Size(136, 23);
            this.btnCreateXmlFile.TabIndex = 10;
            this.btnCreateXmlFile.Text = "Create XML File";
            this.btnCreateXmlFile.UseVisualStyleBackColor = false;
            this.btnCreateXmlFile.Click += new System.EventHandler(this.btnCreateXmlFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select XML File:";
            // 
            // dgvXML
            // 
            this.dgvXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXML.Location = new System.Drawing.Point(3, 16);
            this.dgvXML.Name = "dgvXML";
            this.dgvXML.Size = new System.Drawing.Size(510, 278);
            this.dgvXML.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvXML);
            this.groupBox2.Location = new System.Drawing.Point(7, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 297);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // frmXmlSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(922, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.wbDescription);
            this.Name = "frmXmlSkills";
            this.Text = "frmXmlSkills";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmXmlSkills_FormClosed);
            this.Load += new System.EventHandler(this.frmXmlSkills_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbDescription;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnListXmlFile;
        private System.Windows.Forms.Button btnCreateXmlFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbXmlFiles;
        private System.Windows.Forms.ComboBox cbNorthwindTable;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}