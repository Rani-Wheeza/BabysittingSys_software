namespace BabysittingSys
{
    partial class frmAdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashBoard));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSitterList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateYearlyBookingAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.generateYearlySitterAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.DarkSalmon;
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuClient,
            this.mnuSitter,
            this.mnuExit,
            this.mnuBack,
            this.bookingToolStripMenuItem,
            this.mnuAnalysis});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(889, 24);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(52, 20);
            this.mnuHome.Text = "Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuClient
            // 
            this.mnuClient.BackColor = System.Drawing.Color.DarkSalmon;
            this.mnuClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientList,
            this.mnuSearchClient});
            this.mnuClient.Name = "mnuClient";
            this.mnuClient.Size = new System.Drawing.Size(50, 20);
            this.mnuClient.Text = "Client";
            // 
            // mnuClientList
            // 
            this.mnuClientList.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuClientList.Name = "mnuClientList";
            this.mnuClientList.Size = new System.Drawing.Size(143, 22);
            this.mnuClientList.Text = "Client List";
            this.mnuClientList.Click += new System.EventHandler(this.mnuClientList_Click);
            // 
            // mnuSearchClient
            // 
            this.mnuSearchClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuSearchClient.Name = "mnuSearchClient";
            this.mnuSearchClient.Size = new System.Drawing.Size(143, 22);
            this.mnuSearchClient.Text = "Search Client";
            this.mnuSearchClient.Click += new System.EventHandler(this.mnuSearchClient_Click);
            // 
            // mnuSitter
            // 
            this.mnuSitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSitterList,
            this.mnuSearchSitter});
            this.mnuSitter.Name = "mnuSitter";
            this.mnuSitter.Size = new System.Drawing.Size(46, 20);
            this.mnuSitter.Text = "Sitter";
            // 
            // mnuSitterList
            // 
            this.mnuSitterList.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuSitterList.Name = "mnuSitterList";
            this.mnuSitterList.Size = new System.Drawing.Size(139, 22);
            this.mnuSitterList.Text = "Sitter List";
            this.mnuSitterList.Click += new System.EventHandler(this.mnuSitterList_Click);
            // 
            // mnuSearchSitter
            // 
            this.mnuSearchSitter.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuSearchSitter.Name = "mnuSearchSitter";
            this.mnuSearchSitter.Size = new System.Drawing.Size(139, 22);
            this.mnuSearchSitter.Text = "Search Sitter";
            this.mnuSearchSitter.Click += new System.EventHandler(this.mnuSearchSitter_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.BackColor = System.Drawing.Color.Crimson;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.BackColor = System.Drawing.Color.Tomato;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingListToolStripMenuItem,
            this.searchBookingToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // bookingListToolStripMenuItem
            // 
            this.bookingListToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.bookingListToolStripMenuItem.Name = "bookingListToolStripMenuItem";
            this.bookingListToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bookingListToolStripMenuItem.Text = "Booking List";
            this.bookingListToolStripMenuItem.Click += new System.EventHandler(this.bookingListToolStripMenuItem_Click);
            // 
            // searchBookingToolStripMenuItem
            // 
            this.searchBookingToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.searchBookingToolStripMenuItem.Name = "searchBookingToolStripMenuItem";
            this.searchBookingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.searchBookingToolStripMenuItem.Text = "Search Booking";
            this.searchBookingToolStripMenuItem.Click += new System.EventHandler(this.searchBookingToolStripMenuItem_Click);
            // 
            // mnuAnalysis
            // 
            this.mnuAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateYearlyBookingAnalysis,
            this.generateYearlySitterAnalysisToolStripMenuItem});
            this.mnuAnalysis.Name = "mnuAnalysis";
            this.mnuAnalysis.Size = new System.Drawing.Size(62, 20);
            this.mnuAnalysis.Text = "Analysis";
            // 
            // mnuGenerateYearlyBookingAnalysis
            // 
            this.mnuGenerateYearlyBookingAnalysis.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuGenerateYearlyBookingAnalysis.Name = "mnuGenerateYearlyBookingAnalysis";
            this.mnuGenerateYearlyBookingAnalysis.Size = new System.Drawing.Size(248, 22);
            this.mnuGenerateYearlyBookingAnalysis.Text = "Generate Yearly Booking Analysis";
            this.mnuGenerateYearlyBookingAnalysis.Click += new System.EventHandler(this.mnuGenerateYearlyBookingAnalysis_Click);
            // 
            // generateYearlySitterAnalysisToolStripMenuItem
            // 
            this.generateYearlySitterAnalysisToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.generateYearlySitterAnalysisToolStripMenuItem.Name = "generateYearlySitterAnalysisToolStripMenuItem";
            this.generateYearlySitterAnalysisToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.generateYearlySitterAnalysisToolStripMenuItem.Text = "GenerateYearly Sitter Analysis";
            this.generateYearlySitterAnalysisToolStripMenuItem.Click += new System.EventHandler(this.generateYearlySitterAnalysisToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(889, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMainMenu);
            this.Name = "frmAdminDashBoard";
            this.Text = "frmAdminDashBoard";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuClientList;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchClient;
        private System.Windows.Forms.ToolStripMenuItem mnuSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuSitterList;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateYearlyBookingAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem generateYearlySitterAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookingToolStripMenuItem;
    }
}