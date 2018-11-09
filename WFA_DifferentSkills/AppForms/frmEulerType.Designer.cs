namespace WFA_DifferentSkills.AppForms
{
    partial class frmEulerType
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtMultiplicationTbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTbl = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lstSequentialNumber = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ofdForNumberFile = new System.Windows.Forms.OpenFileDialog();
            this.txtQueue = new System.Windows.Forms.MaskedTextBox();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbDescription
            // 
            this.wbDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbDescription.Location = new System.Drawing.Point(0, 0);
            this.wbDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDescription.Name = "wbDescription";
            this.wbDescription.Size = new System.Drawing.Size(385, 434);
            this.wbDescription.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(385, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblWarning);
            this.tabPage1.Controls.Add(this.lblUyari);
            this.tabPage1.Controls.Add(this.txtNumber);
            this.tabPage1.Controls.Add(this.txtMultiplicationTbl);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCreateTbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "-1-";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(26, 66);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 10;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(43, 79);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 13);
            this.lblUyari.TabIndex = 9;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(127, 32);
            this.txtNumber.Mask = "00";
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(53, 20);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.ValidatingType = typeof(int);
            // 
            // txtMultiplicationTbl
            // 
            this.txtMultiplicationTbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMultiplicationTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMultiplicationTbl.Location = new System.Drawing.Point(26, 85);
            this.txtMultiplicationTbl.Multiline = true;
            this.txtMultiplicationTbl.Name = "txtMultiplicationTbl";
            this.txtMultiplicationTbl.ReadOnly = true;
            this.txtMultiplicationTbl.Size = new System.Drawing.Size(484, 303);
            this.txtMultiplicationTbl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter a number :";
            // 
            // btnCreateTbl
            // 
            this.btnCreateTbl.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateTbl.Location = new System.Drawing.Point(361, 25);
            this.btnCreateTbl.Name = "btnCreateTbl";
            this.btnCreateTbl.Size = new System.Drawing.Size(149, 33);
            this.btnCreateTbl.TabIndex = 1;
            this.btnCreateTbl.Text = "Create Multiplication Table";
            this.btnCreateTbl.UseVisualStyleBackColor = false;
            this.btnCreateTbl.Click += new System.EventHandler(this.btnCreateTbl_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblFilePath);
            this.tabPage2.Controls.Add(this.lstSequentialNumber);
            this.tabPage2.Controls.Add(this.btnSort);
            this.tabPage2.Controls.Add(this.btnSelectFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "-2-";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(211, 35);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 13);
            this.lblFilePath.TabIndex = 2;
            // 
            // lstSequentialNumber
            // 
            this.lstSequentialNumber.FormattingEnabled = true;
            this.lstSequentialNumber.Location = new System.Drawing.Point(214, 78);
            this.lstSequentialNumber.Name = "lstSequentialNumber";
            this.lstSequentialNumber.Size = new System.Drawing.Size(286, 303);
            this.lstSequentialNumber.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(17, 78);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(121, 33);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(17, 25);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(121, 33);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFibonacci);
            this.tabPage3.Controls.Add(this.txtQueue);
            this.tabPage3.Controls.Add(this.txtFibonacci);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(531, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "-3-";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ofdForNumberFile
            // 
            this.ofdForNumberFile.FileName = "ofdForNumberFile";
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(85, 19);
            this.txtQueue.Mask = "00";
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(100, 20);
            this.txtQueue.TabIndex = 4;
            this.txtQueue.ValidatingType = typeof(int);
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFibonacci.Location = new System.Drawing.Point(85, 94);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.ReadOnly = true;
            this.txtFibonacci.Size = new System.Drawing.Size(101, 20);
            this.txtFibonacci.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Queue :";
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(85, 55);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(101, 23);
            this.btnFibonacci.TabIndex = 8;
            this.btnFibonacci.Text = "Get Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // frmEulerType
            // 
            this.AcceptButton = this.btnCreateTbl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(924, 434);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.wbDescription);
            this.Name = "frmEulerType";
            this.Text = "frmEulerType";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEulerType_FormClosed);
            this.Load += new System.EventHandler(this.frmEulerType_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser wbDescription;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.MaskedTextBox txtNumber;
        private System.Windows.Forms.TextBox txtMultiplicationTbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateTbl;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ListBox lstSequentialNumber;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog ofdForNumberFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.MaskedTextBox txtQueue;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.Label label2;
    }
}