namespace BabysittingSys
{
    partial class frmCancelBooking
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCancelBooking = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpClientDetails = new System.Windows.Forms.GroupBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClientPhoneNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.grpSitterDetails = new System.Windows.Forms.GroupBox();
            this.txtSitterID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSitterPhoneNo = new System.Windows.Forms.TextBox();
            this.txtSitterEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSitterName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chkPayment = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cboDuration = new System.Windows.Forms.ComboBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.grpCancelBooking.SuspendLayout();
            this.grpClientDetails.SuspendLayout();
            this.grpSitterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.DarkSalmon;
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuClient,
            this.mnuBooking,
            this.mnuExit,
            this.mnuBack});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(998, 24);
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
            this.mnuRegisterClient,
            this.mnuUpdateClient,
            this.mnuRemoveClient});
            this.mnuClient.Name = "mnuClient";
            this.mnuClient.Size = new System.Drawing.Size(50, 20);
            this.mnuClient.Text = "Client";
            // 
            // mnuRegisterClient
            // 
            this.mnuRegisterClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRegisterClient.Name = "mnuRegisterClient";
            this.mnuRegisterClient.Size = new System.Drawing.Size(151, 22);
            this.mnuRegisterClient.Text = "Register Client";
            // 
            // mnuUpdateClient
            // 
            this.mnuUpdateClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuUpdateClient.Name = "mnuUpdateClient";
            this.mnuUpdateClient.Size = new System.Drawing.Size(151, 22);
            this.mnuUpdateClient.Text = "Update Client";
            // 
            // mnuRemoveClient
            // 
            this.mnuRemoveClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRemoveClient.Name = "mnuRemoveClient";
            this.mnuRemoveClient.Size = new System.Drawing.Size(151, 22);
            this.mnuRemoveClient.Text = "Remove Client";
            // 
            // mnuBooking
            // 
            this.mnuBooking.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeBooking,
            this.mnuUpdateBooking});
            this.mnuBooking.Name = "mnuBooking";
            this.mnuBooking.Size = new System.Drawing.Size(63, 20);
            this.mnuBooking.Text = "Booking";
            // 
            // mnuMakeBooking
            // 
            this.mnuMakeBooking.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Size = new System.Drawing.Size(159, 22);
            this.mnuMakeBooking.Text = "Make Booking";
            this.mnuMakeBooking.Click += new System.EventHandler(this.mnuMakeBooking_Click);
            // 
            // mnuUpdateBooking
            // 
            this.mnuUpdateBooking.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuUpdateBooking.Name = "mnuUpdateBooking";
            this.mnuUpdateBooking.Size = new System.Drawing.Size(159, 22);
            this.mnuUpdateBooking.Text = "Update Booking";
            this.mnuUpdateBooking.Click += new System.EventHandler(this.mnuUpdateBooking_Click);
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
            // grpCancelBooking
            // 
            this.grpCancelBooking.Controls.Add(this.btnSearch);
            this.grpCancelBooking.Controls.Add(this.txtBookingID);
            this.grpCancelBooking.Controls.Add(this.txtClientID);
            this.grpCancelBooking.Controls.Add(this.label2);
            this.grpCancelBooking.Controls.Add(this.label1);
            this.grpCancelBooking.Controls.Add(this.grpClientDetails);
            this.grpCancelBooking.Controls.Add(this.grpSitterDetails);
            this.grpCancelBooking.Controls.Add(this.dtpDate);
            this.grpCancelBooking.Controls.Add(this.chkPayment);
            this.grpCancelBooking.Controls.Add(this.label5);
            this.grpCancelBooking.Controls.Add(this.label14);
            this.grpCancelBooking.Controls.Add(this.btnCancelBooking);
            this.grpCancelBooking.Controls.Add(this.dtpTime);
            this.grpCancelBooking.Controls.Add(this.cboDuration);
            this.grpCancelBooking.Controls.Add(this.txtTotalCost);
            this.grpCancelBooking.Controls.Add(this.label8);
            this.grpCancelBooking.Controls.Add(this.label7);
            this.grpCancelBooking.Controls.Add(this.label6);
            this.grpCancelBooking.Controls.Add(this.label4);
            this.grpCancelBooking.Location = new System.Drawing.Point(107, 41);
            this.grpCancelBooking.Margin = new System.Windows.Forms.Padding(2);
            this.grpCancelBooking.Name = "grpCancelBooking";
            this.grpCancelBooking.Padding = new System.Windows.Forms.Padding(2);
            this.grpCancelBooking.Size = new System.Drawing.Size(768, 521);
            this.grpCancelBooking.TabIndex = 3;
            this.grpCancelBooking.TabStop = false;
            this.grpCancelBooking.Text = "Cancel Booking";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(263, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(136, 29);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingID.MaxLength = 50;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(101, 20);
            this.txtBookingID.TabIndex = 39;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(136, 88);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.MaxLength = 50;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(101, 20);
            this.txtClientID.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Client ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Booking ID";
            // 
            // grpClientDetails
            // 
            this.grpClientDetails.Controls.Add(this.txtClientEmail);
            this.grpClientDetails.Controls.Add(this.label12);
            this.grpClientDetails.Controls.Add(this.label11);
            this.grpClientDetails.Controls.Add(this.txtClientPhoneNo);
            this.grpClientDetails.Controls.Add(this.label13);
            this.grpClientDetails.Controls.Add(this.txtClientName);
            this.grpClientDetails.Location = new System.Drawing.Point(34, 117);
            this.grpClientDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpClientDetails.Name = "grpClientDetails";
            this.grpClientDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpClientDetails.Size = new System.Drawing.Size(291, 175);
            this.grpClientDetails.TabIndex = 34;
            this.grpClientDetails.TabStop = false;
            this.grpClientDetails.Text = "Client Details";
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(102, 72);
            this.txtClientEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientEmail.MaxLength = 35;
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(152, 20);
            this.txtClientEmail.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Phone No.";
            // 
            // txtClientPhoneNo
            // 
            this.txtClientPhoneNo.Location = new System.Drawing.Point(102, 127);
            this.txtClientPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientPhoneNo.Name = "txtClientPhoneNo";
            this.txtClientPhoneNo.Size = new System.Drawing.Size(152, 20);
            this.txtClientPhoneNo.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Client Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(102, 28);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientName.MaxLength = 50;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(152, 20);
            this.txtClientName.TabIndex = 21;
            // 
            // grpSitterDetails
            // 
            this.grpSitterDetails.Controls.Add(this.txtSitterID);
            this.grpSitterDetails.Controls.Add(this.label16);
            this.grpSitterDetails.Controls.Add(this.txtHourlyRate);
            this.grpSitterDetails.Controls.Add(this.label15);
            this.grpSitterDetails.Controls.Add(this.txtSitterPhoneNo);
            this.grpSitterDetails.Controls.Add(this.txtSitterEmail);
            this.grpSitterDetails.Controls.Add(this.label10);
            this.grpSitterDetails.Controls.Add(this.label9);
            this.grpSitterDetails.Controls.Add(this.cboSitterName);
            this.grpSitterDetails.Controls.Add(this.label3);
            this.grpSitterDetails.Location = new System.Drawing.Point(396, 17);
            this.grpSitterDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpSitterDetails.Name = "grpSitterDetails";
            this.grpSitterDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpSitterDetails.Size = new System.Drawing.Size(316, 275);
            this.grpSitterDetails.TabIndex = 33;
            this.grpSitterDetails.TabStop = false;
            this.grpSitterDetails.Text = "Sitter Details";
            // 
            // txtSitterID
            // 
            this.txtSitterID.Location = new System.Drawing.Point(114, 31);
            this.txtSitterID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSitterID.MaxLength = 4;
            this.txtSitterID.Name = "txtSitterID";
            this.txtSitterID.ReadOnly = true;
            this.txtSitterID.Size = new System.Drawing.Size(68, 20);
            this.txtSitterID.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "Sitter ID";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(116, 228);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtHourlyRate.MaxLength = 4;
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(188, 20);
            this.txtHourlyRate.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 231);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Hourly Rate";
            // 
            // txtSitterPhoneNo
            // 
            this.txtSitterPhoneNo.Location = new System.Drawing.Point(116, 179);
            this.txtSitterPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSitterPhoneNo.MaxLength = 10;
            this.txtSitterPhoneNo.Name = "txtSitterPhoneNo";
            this.txtSitterPhoneNo.Size = new System.Drawing.Size(188, 20);
            this.txtSitterPhoneNo.TabIndex = 15;
            // 
            // txtSitterEmail
            // 
            this.txtSitterEmail.Location = new System.Drawing.Point(114, 126);
            this.txtSitterEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtSitterEmail.MaxLength = 35;
            this.txtSitterEmail.Name = "txtSitterEmail";
            this.txtSitterEmail.Size = new System.Drawing.Size(188, 20);
            this.txtSitterEmail.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Phone No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email";
            // 
            // cboSitterName
            // 
            this.cboSitterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSitterName.FormattingEnabled = true;
            this.cboSitterName.Location = new System.Drawing.Point(114, 74);
            this.cboSitterName.Margin = new System.Windows.Forms.Padding(2);
            this.cboSitterName.Name = "cboSitterName";
            this.cboSitterName.Size = new System.Drawing.Size(189, 21);
            this.cboSitterName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sitter Name";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(122, 330);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2025, 10, 20, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(152, 20);
            this.dtpDate.TabIndex = 31;
            this.dtpDate.Value = new System.DateTime(2025, 10, 20, 0, 0, 0, 0);
            // 
            // chkPayment
            // 
            this.chkPayment.AutoSize = true;
            this.chkPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPayment.Location = new System.Drawing.Point(490, 454);
            this.chkPayment.Margin = new System.Windows.Forms.Padding(2);
            this.chkPayment.Name = "chkPayment";
            this.chkPayment.Size = new System.Drawing.Size(229, 19);
            this.chkPayment.TabIndex = 30;
            this.chkPayment.Text = "I agree to pay in cash after the service";
            this.chkPayment.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(516, 482);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "!! CASH ONLY SERVICE !!";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.Location = new System.Drawing.Point(296, 454);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(115, 31);
            this.btnCancelBooking.TabIndex = 27;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm tt";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(497, 327);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(152, 20);
            this.dtpTime.TabIndex = 26;
            // 
            // cboDuration
            // 
            this.cboDuration.FormattingEnabled = true;
            this.cboDuration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboDuration.Location = new System.Drawing.Point(122, 388);
            this.cboDuration.Margin = new System.Windows.Forms.Padding(2);
            this.cboDuration.Name = "cboDuration";
            this.cboDuration.Size = new System.Drawing.Size(121, 21);
            this.cboDuration.TabIndex = 23;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(498, 378);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCost.MaxLength = 4;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(152, 20);
            this.txtTotalCost.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Payment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(393, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(998, 571);
            this.Controls.Add(this.grpCancelBooking);
            this.Controls.Add(this.mnuMainMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCancelBooking";
            this.Text = "frmCancelBooking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpCancelBooking.ResumeLayout(false);
            this.grpCancelBooking.PerformLayout();
            this.grpClientDetails.ResumeLayout(false);
            this.grpClientDetails.PerformLayout();
            this.grpSitterDetails.ResumeLayout(false);
            this.grpSitterDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterClient;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveClient;
        private System.Windows.Forms.ToolStripMenuItem mnuBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpCancelBooking;
        private System.Windows.Forms.CheckBox chkPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cboDuration;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpClientDetails;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtClientPhoneNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.GroupBox grpSitterDetails;
        private System.Windows.Forms.TextBox txtSitterID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSitterPhoneNo;
        private System.Windows.Forms.TextBox txtSitterEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSitterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
    }
}