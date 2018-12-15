namespace WFA_DifferentSkills.AppForms
{
    partial class frmHtmlParse
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.wbDescription = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wbTweets = new System.Windows.Forms.WebBrowser();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lblLike = new System.Windows.Forms.Label();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.lblFollowing = new System.Windows.Forms.Label();
            this.lblTweets = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(989, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // wbDescription
            // 
            this.wbDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.wbDescription.Location = new System.Drawing.Point(0, 0);
            this.wbDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDescription.Name = "wbDescription";
            this.wbDescription.Size = new System.Drawing.Size(385, 538);
            this.wbDescription.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.wbTweets);
            this.groupBox1.Location = new System.Drawing.Point(403, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 262);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // wbTweets
            // 
            this.wbTweets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTweets.Location = new System.Drawing.Point(3, 16);
            this.wbTweets.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTweets.Name = "wbTweets";
            this.wbTweets.Size = new System.Drawing.Size(563, 243);
            this.wbTweets.TabIndex = 0;
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUserInfo.Controls.Add(this.lblLike);
            this.gbUserInfo.Controls.Add(this.lblFollowers);
            this.gbUserInfo.Controls.Add(this.lblFollowing);
            this.gbUserInfo.Controls.Add(this.lblTweets);
            this.gbUserInfo.Controls.Add(this.lblLink);
            this.gbUserInfo.Controls.Add(this.lblLocation);
            this.gbUserInfo.Controls.Add(this.lblName);
            this.gbUserInfo.Controls.Add(this.label7);
            this.gbUserInfo.Controls.Add(this.label6);
            this.gbUserInfo.Controls.Add(this.label4);
            this.gbUserInfo.Controls.Add(this.label8);
            this.gbUserInfo.Controls.Add(this.label3);
            this.gbUserInfo.Controls.Add(this.label2);
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Controls.Add(this.pbPicture);
            this.gbUserInfo.Location = new System.Drawing.Point(403, 60);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(569, 207);
            this.gbUserInfo.TabIndex = 18;
            this.gbUserInfo.TabStop = false;
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLike.ForeColor = System.Drawing.Color.Gray;
            this.lblLike.Location = new System.Drawing.Point(229, 180);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(26, 17);
            this.lblLike.TabIndex = 5;
            this.lblLike.Text = "---";
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowers.ForeColor = System.Drawing.Color.Gray;
            this.lblFollowers.Location = new System.Drawing.Point(229, 153);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(26, 17);
            this.lblFollowers.TabIndex = 5;
            this.lblFollowers.Text = "---";
            // 
            // lblFollowing
            // 
            this.lblFollowing.AutoSize = true;
            this.lblFollowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFollowing.ForeColor = System.Drawing.Color.Gray;
            this.lblFollowing.Location = new System.Drawing.Point(229, 126);
            this.lblFollowing.Name = "lblFollowing";
            this.lblFollowing.Size = new System.Drawing.Size(26, 17);
            this.lblFollowing.TabIndex = 5;
            this.lblFollowing.Text = "---";
            // 
            // lblTweets
            // 
            this.lblTweets.AutoSize = true;
            this.lblTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTweets.ForeColor = System.Drawing.Color.Gray;
            this.lblTweets.Location = new System.Drawing.Point(229, 99);
            this.lblTweets.Name = "lblTweets";
            this.lblTweets.Size = new System.Drawing.Size(26, 17);
            this.lblTweets.TabIndex = 5;
            this.lblTweets.Text = "---";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLink.ForeColor = System.Drawing.Color.Gray;
            this.lblLink.Location = new System.Drawing.Point(229, 72);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(26, 17);
            this.lblLink.TabIndex = 5;
            this.lblLink.Text = "---";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLocation.ForeColor = System.Drawing.Color.Gray;
            this.lblLocation.Location = new System.Drawing.Point(229, 45);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(26, 17);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "---";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(229, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(180, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Link:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(148, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(143, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Following:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(180, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Like:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(142, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Followers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(159, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tweets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.InitialImage = null;
            this.pbPicture.Location = new System.Drawing.Point(13, 17);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(100, 94);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.label5);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Location = new System.Drawing.Point(403, 7);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(569, 47);
            this.gbSearch.TabIndex = 17;
            this.gbSearch.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Location = new System.Drawing.Point(407, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Twitter Account: ";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(172, 14);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "verimetrik";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmHtmlParse
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(989, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.wbDescription);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmHtmlParse";
            this.Text = "frmHtmlParse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHtmlParse_FormClosed);
            this.Load += new System.EventHandler(this.frmHtmlParse_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.WebBrowser wbDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser wbTweets;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblLike;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Label lblFollowing;
        private System.Windows.Forms.Label lblTweets;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}