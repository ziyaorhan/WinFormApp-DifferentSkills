namespace WFA_DifferentSkills.AppForms
{
    partial class frmDbCreator
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
            this.btnStart = new System.Windows.Forms.Button();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.rbCustomize = new System.Windows.Forms.RadioButton();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvErrorCmd = new System.Windows.Forms.DataGridView();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExecuted = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnExec = new System.Windows.Forms.TextBox();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.wbDescription = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorCmd)).BeginInit();
            this.gb3.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(585, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Kuruluma Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(22, 19);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(76, 17);
            this.rbDefault.TabIndex = 1;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "LocalHost ";
            this.rbDefault.UseVisualStyleBackColor = false;
            this.rbDefault.CheckedChanged += new System.EventHandler(this.rbDefault_CheckedChanged);
            // 
            // rbCustomize
            // 
            this.rbCustomize.AutoSize = true;
            this.rbCustomize.Location = new System.Drawing.Point(113, 19);
            this.rbCustomize.Name = "rbCustomize";
            this.rbCustomize.Size = new System.Drawing.Size(49, 17);
            this.rbCustomize.TabIndex = 1;
            this.rbCustomize.TabStop = true;
            this.rbCustomize.Text = "Özel ";
            this.rbCustomize.UseVisualStyleBackColor = false;
            this.rbCustomize.CheckedChanged += new System.EventHandler(this.rbCustomize_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(96, 27);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(143, 20);
            this.txtServer.TabIndex = 2;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(96, 53);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(143, 20);
            this.txtDatabase.TabIndex = 2;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(96, 79);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(143, 20);
            this.txtUserId.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Initial Catalog:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // dgvErrorCmd
            // 
            this.dgvErrorCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorCmd.GridColor = System.Drawing.Color.White;
            this.dgvErrorCmd.Location = new System.Drawing.Point(6, 40);
            this.dgvErrorCmd.Name = "dgvErrorCmd";
            this.dgvErrorCmd.RowHeadersWidth = 20;
            this.dgvErrorCmd.Size = new System.Drawing.Size(377, 99);
            this.dgvErrorCmd.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(44, 14);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(99, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Derlenen Satır:";
            // 
            // txtExecuted
            // 
            this.txtExecuted.Enabled = false;
            this.txtExecuted.Location = new System.Drawing.Point(217, 13);
            this.txtExecuted.Name = "txtExecuted";
            this.txtExecuted.Size = new System.Drawing.Size(46, 20);
            this.txtExecuted.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Problemli Satır:";
            // 
            // txtUnExec
            // 
            this.txtUnExec.Enabled = false;
            this.txtUnExec.Location = new System.Drawing.Point(337, 14);
            this.txtUnExec.Name = "txtUnExec";
            this.txtUnExec.Size = new System.Drawing.Size(46, 20);
            this.txtUnExec.TabIndex = 6;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.dgvErrorCmd);
            this.gb3.Controls.Add(this.txtUnExec);
            this.gb3.Controls.Add(this.label5);
            this.gb3.Controls.Add(this.txtExecuted);
            this.gb3.Controls.Add(this.label6);
            this.gb3.Controls.Add(this.txtStatus);
            this.gb3.Controls.Add(this.label7);
            this.gb3.Location = new System.Drawing.Point(395, 222);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(390, 144);
            this.gb3.TabIndex = 7;
            this.gb3.TabStop = false;
            this.gb3.Text = "-SONUÇ-";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.txtPassword);
            this.gb2.Controls.Add(this.txtServer);
            this.gb2.Controls.Add(this.txtDatabase);
            this.gb2.Controls.Add(this.label4);
            this.gb2.Controls.Add(this.txtUserId);
            this.gb2.Controls.Add(this.label3);
            this.gb2.Controls.Add(this.label1);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Location = new System.Drawing.Point(395, 68);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(390, 145);
            this.gb2.TabIndex = 8;
            this.gb2.TabStop = false;
            this.gb2.Text = "-2-";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbCustomize);
            this.gb1.Controls.Add(this.rbDefault);
            this.gb1.Location = new System.Drawing.Point(395, 6);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(390, 53);
            this.gb1.TabIndex = 9;
            this.gb1.TabStop = false;
            this.gb1.Text = "-1-";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.White;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnd.Location = new System.Drawing.Point(688, 379);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(97, 26);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "Tamam";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // wbDescription
            // 
            this.wbDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbDescription.Location = new System.Drawing.Point(0, 0);
            this.wbDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDescription.Name = "wbDescription";
            this.wbDescription.Size = new System.Drawing.Size(385, 417);
            this.wbDescription.TabIndex = 11;
            // 
            // frmDbCreator
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(795, 417);
            this.Controls.Add(this.wbDescription);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDbCreator";
            this.Text = "frmDbCreator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDbCreator_FormClosed);
            this.Load += new System.EventHandler(this.frmDbCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorCmd)).EndInit();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.RadioButton rbCustomize;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvErrorCmd;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExecuted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnExec;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.WebBrowser wbDescription;
    }
}