namespace WFA_DifferentSkills.AppForms
{
    partial class frmMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.createDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubApiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eULERTYPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDbToolStripMenuItem,
            this.aPIToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.eULERTYPEToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(950, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // createDbToolStripMenuItem
            // 
            this.createDbToolStripMenuItem.Name = "createDbToolStripMenuItem";
            this.createDbToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.createDbToolStripMenuItem.Text = "CREATE DB";
            this.createDbToolStripMenuItem.Click += new System.EventHandler(this.createDbToolStripMenuItem_Click);
            this.createDbToolStripMenuItem.MouseEnter += new System.EventHandler(this.createDbToolStripMenuItem_MouseEnter);
            this.createDbToolStripMenuItem.MouseLeave += new System.EventHandler(this.createDbToolStripMenuItem_MouseLeave);
            // 
            // aPIToolStripMenuItem
            // 
            this.aPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubApiToolStripMenuItem});
            this.aPIToolStripMenuItem.Name = "aPIToolStripMenuItem";
            this.aPIToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aPIToolStripMenuItem.Text = ">API";
            // 
            // githubApiToolStripMenuItem
            // 
            this.githubApiToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.githubApiToolStripMenuItem.Name = "githubApiToolStripMenuItem";
            this.githubApiToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.githubApiToolStripMenuItem.Text = "Github Api";
            this.githubApiToolStripMenuItem.Click += new System.EventHandler(this.githubApiToolStripMenuItem_Click);
            this.githubApiToolStripMenuItem.MouseEnter += new System.EventHandler(this.githubApiToolStripMenuItem_MouseEnter);
            this.githubApiToolStripMenuItem.MouseLeave += new System.EventHandler(this.githubApiToolStripMenuItem_MouseLeave);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.xMLToolStripMenuItem.Text = "XML OPERATIONS";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            this.xMLToolStripMenuItem.MouseEnter += new System.EventHandler(this.xMLToolStripMenuItem_MouseEnter);
            this.xMLToolStripMenuItem.MouseLeave += new System.EventHandler(this.xMLToolStripMenuItem_MouseLeave);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.jSONToolStripMenuItem.Text = "JSON OPERATIONS";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            this.jSONToolStripMenuItem.MouseEnter += new System.EventHandler(this.jSONToolStripMenuItem_MouseEnter);
            this.jSONToolStripMenuItem.MouseLeave += new System.EventHandler(this.jSONToolStripMenuItem_MouseLeave);
            // 
            // eULERTYPEToolStripMenuItem
            // 
            this.eULERTYPEToolStripMenuItem.Name = "eULERTYPEToolStripMenuItem";
            this.eULERTYPEToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.eULERTYPEToolStripMenuItem.Text = "EULER TYPE ALGORITHM";
            this.eULERTYPEToolStripMenuItem.Click += new System.EventHandler(this.eULERTYPEToolStripMenuItem_Click);
            this.eULERTYPEToolStripMenuItem.MouseEnter += new System.EventHandler(this.eULERTYPEToolStripMenuItem_MouseEnter);
            this.eULERTYPEToolStripMenuItem.MouseLeave += new System.EventHandler(this.eULERTYPEToolStripMenuItem_MouseLeave);
            // 
            // wbMain
            // 
            this.wbMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.wbMain.Location = new System.Drawing.Point(535, 24);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(415, 470);
            this.wbMain.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(950, 494);
            this.Controls.Add(this.wbMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "WFA Different Skills";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.ToolStripMenuItem aPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubApiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eULERTYPEToolStripMenuItem;
    }
}