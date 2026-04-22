namespace BabysittingSys
{
    partial class frmGenerateYearlySitterAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chtSitterAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.chtSitterAnalysis)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(144, 50);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(178, 21);
            this.cboYear.TabIndex = 4;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // chtSitterAnalysis
            // 
            chartArea2.Name = "ChartArea1";
            this.chtSitterAnalysis.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtSitterAnalysis.Legends.Add(legend2);
            this.chtSitterAnalysis.Location = new System.Drawing.Point(57, 118);
            this.chtSitterAnalysis.Name = "chtSitterAnalysis";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Sitter A";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Sitter B";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Sitter C";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Sitter D";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Sitter E";
            series12.BorderWidth = 4;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Top Earnings";
            this.chtSitterAnalysis.Series.Add(series7);
            this.chtSitterAnalysis.Series.Add(series8);
            this.chtSitterAnalysis.Series.Add(series9);
            this.chtSitterAnalysis.Series.Add(series10);
            this.chtSitterAnalysis.Series.Add(series11);
            this.chtSitterAnalysis.Series.Add(series12);
            this.chtSitterAnalysis.Size = new System.Drawing.Size(829, 431);
            this.chtSitterAnalysis.TabIndex = 5;
            this.chtSitterAnalysis.Text = "Chart Sitter";
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
            this.mnuMainMenu.Size = new System.Drawing.Size(942, 24);
            this.mnuMainMenu.TabIndex = 6;
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
            this.mnuGenerateYearlyBookingAnalysis});
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
            // frmGenerateYearlySitterAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(942, 607);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.chtSitterAnalysis);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.label1);
            this.Name = "frmGenerateYearlySitterAnalysis";
            this.Text = "frmGenerateYearlySitterAnalysis";
            this.Load += new System.EventHandler(this.frmGenerateYearlySitterAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtSitterAnalysis)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtSitterAnalysis;
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
        private System.Windows.Forms.ToolStripMenuItem searchBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateYearlyBookingAnalysis;
    }
}