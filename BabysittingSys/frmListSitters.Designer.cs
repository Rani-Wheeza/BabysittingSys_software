namespace BabysittingSys
{
    partial class frmListSitters
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
            this.grpSittersList = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDisplaySitters = new System.Windows.Forms.Button();
            this.dgvDisplaySitters = new System.Windows.Forms.DataGridView();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateYearlyBookingAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.generateYearlySitterAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSittersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaySitters)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSittersList
            // 
            this.grpSittersList.Controls.Add(this.btnClearAll);
            this.grpSittersList.Controls.Add(this.btnDisplaySitters);
            this.grpSittersList.Controls.Add(this.dgvDisplaySitters);
            this.grpSittersList.Location = new System.Drawing.Point(31, 51);
            this.grpSittersList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSittersList.Name = "grpSittersList";
            this.grpSittersList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSittersList.Size = new System.Drawing.Size(914, 471);
            this.grpSittersList.TabIndex = 1;
            this.grpSittersList.TabStop = false;
            this.grpSittersList.Text = "Sitters List";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(420, 415);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(118, 32);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDisplaySitters
            // 
            this.btnDisplaySitters.Location = new System.Drawing.Point(420, 40);
            this.btnDisplaySitters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisplaySitters.Name = "btnDisplaySitters";
            this.btnDisplaySitters.Size = new System.Drawing.Size(118, 32);
            this.btnDisplaySitters.TabIndex = 1;
            this.btnDisplaySitters.Text = "Display Sitters";
            this.btnDisplaySitters.UseVisualStyleBackColor = true;
            this.btnDisplaySitters.Click += new System.EventHandler(this.btnDisplaySitters_Click);
            // 
            // dgvDisplaySitters
            // 
            this.dgvDisplaySitters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplaySitters.Location = new System.Drawing.Point(44, 100);
            this.dgvDisplaySitters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDisplaySitters.Name = "dgvDisplaySitters";
            this.dgvDisplaySitters.RowHeadersWidth = 51;
            this.dgvDisplaySitters.RowTemplate.Height = 24;
            this.dgvDisplaySitters.Size = new System.Drawing.Size(836, 294);
            this.dgvDisplaySitters.TabIndex = 0;
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
            this.mnuMainMenu.Size = new System.Drawing.Size(982, 24);
            this.mnuMainMenu.TabIndex = 2;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(52, 20);
            this.mnuHome.Text = "Home";
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
            // 
            // mnuSearchClient
            // 
            this.mnuSearchClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuSearchClient.Name = "mnuSearchClient";
            this.mnuSearchClient.Size = new System.Drawing.Size(143, 22);
            this.mnuSearchClient.Text = "Search Client";
            // 
            // mnuSitter
            // 
            this.mnuSitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchSitter});
            this.mnuSitter.Name = "mnuSitter";
            this.mnuSitter.Size = new System.Drawing.Size(46, 20);
            this.mnuSitter.Text = "Sitter";
            // 
            // mnuSearchSitter
            // 
            this.mnuSearchSitter.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuSearchSitter.Name = "mnuSearchSitter";
            this.mnuSearchSitter.Size = new System.Drawing.Size(139, 22);
            this.mnuSearchSitter.Text = "Search Sitter";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.BackColor = System.Drawing.Color.Crimson;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.BackColor = System.Drawing.Color.Tomato;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
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
            // 
            // searchBookingToolStripMenuItem
            // 
            this.searchBookingToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.searchBookingToolStripMenuItem.Name = "searchBookingToolStripMenuItem";
            this.searchBookingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.searchBookingToolStripMenuItem.Text = "Search Booking";
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
            // 
            // generateYearlySitterAnalysisToolStripMenuItem
            // 
            this.generateYearlySitterAnalysisToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.generateYearlySitterAnalysisToolStripMenuItem.Name = "generateYearlySitterAnalysisToolStripMenuItem";
            this.generateYearlySitterAnalysisToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.generateYearlySitterAnalysisToolStripMenuItem.Text = "GenerateYearly Sitter Analysis";
            // 
            // frmListSitters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(982, 567);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.grpSittersList);
            this.Name = "frmListSitters";
            this.Text = "List sitters in a table";
            this.Load += new System.EventHandler(this.frmListSitters_Load);
            this.grpSittersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaySitters)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSittersList;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDisplaySitters;
        private System.Windows.Forms.DataGridView dgvDisplaySitters;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuClientList;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchClient;
        private System.Windows.Forms.ToolStripMenuItem mnuSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateYearlyBookingAnalysis;
        private System.Windows.Forms.ToolStripMenuItem generateYearlySitterAnalysisToolStripMenuItem;
    }
}