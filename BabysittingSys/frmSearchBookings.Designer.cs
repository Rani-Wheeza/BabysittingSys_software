namespace BabysittingSys
{
    partial class frmSearchBookings
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
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSearchBooking = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.mnuAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateYearlyBookingAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.generateYearlySitterAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooking)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.btnClear);
            this.grpBookingDetails.Controls.Add(this.dgvSearchBooking);
            this.grpBookingDetails.Location = new System.Drawing.Point(47, 147);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(1088, 355);
            this.grpBookingDetails.TabIndex = 8;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Details";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(442, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSearchBooking
            // 
            this.dgvSearchBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBooking.Location = new System.Drawing.Point(22, 42);
            this.dgvSearchBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSearchBooking.Name = "dgvSearchBooking";
            this.dgvSearchBooking.RowHeadersWidth = 51;
            this.dgvSearchBooking.RowTemplate.Height = 24;
            this.dgvSearchBooking.Size = new System.Drawing.Size(1016, 231);
            this.dgvSearchBooking.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "BookingID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(171, 69);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingID.Multiline = true;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(173, 32);
            this.txtBookingID.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(407, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.mnuMainMenu.Size = new System.Drawing.Size(1191, 24);
            this.mnuMainMenu.TabIndex = 9;
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
            this.bookingListToolStripMenuItem});
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
            // frmSearchBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1191, 589);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmSearchBookings";
            this.Text = "frmSearchBookings";
            this.Load += new System.EventHandler(this.frmSearchBookings_Load);
            this.grpBookingDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooking)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSearchBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuClientList;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchClient;
        private System.Windows.Forms.ToolStripMenuItem mnuSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuSitterList;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateYearlyBookingAnalysis;
        private System.Windows.Forms.ToolStripMenuItem generateYearlySitterAnalysisToolStripMenuItem;
    }
}