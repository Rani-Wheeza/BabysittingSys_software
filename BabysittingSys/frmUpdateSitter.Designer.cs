namespace BabysittingSys
{
    partial class frmUpdateSitter
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
            this.mnuSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateSitter = new System.Windows.Forms.GroupBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboMedicalCertified = new System.Windows.Forms.ComboBox();
            this.cboChildCareCertified = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateSitter = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEirCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSitterID = new System.Windows.Forms.ComboBox();
            this.mnuMainMenu.SuspendLayout();
            this.grpUpdateSitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.DarkSalmon;
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuSitter,
            this.mnuExit,
            this.mnuBack});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(967, 24);
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
            // mnuSitter
            // 
            this.mnuSitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterSitter,
            this.mnuRemoveSitter});
            this.mnuSitter.Name = "mnuSitter";
            this.mnuSitter.Size = new System.Drawing.Size(46, 20);
            this.mnuSitter.Text = "Sitter";
            // 
            // mnuRegisterSitter
            // 
            this.mnuRegisterSitter.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRegisterSitter.Name = "mnuRegisterSitter";
            this.mnuRegisterSitter.Size = new System.Drawing.Size(147, 22);
            this.mnuRegisterSitter.Text = "Register Sitter";
            this.mnuRegisterSitter.Click += new System.EventHandler(this.mnuRegisterSitter_Click);
            // 
            // mnuRemoveSitter
            // 
            this.mnuRemoveSitter.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRemoveSitter.Name = "mnuRemoveSitter";
            this.mnuRemoveSitter.Size = new System.Drawing.Size(147, 22);
            this.mnuRemoveSitter.Text = "Remove Sitter";
            this.mnuRemoveSitter.Click += new System.EventHandler(this.mnuRemoveSitter_Click);
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
            // grpUpdateSitter
            // 
            this.grpUpdateSitter.Controls.Add(this.cboSitterID);
            this.grpUpdateSitter.Controls.Add(this.cboLanguage);
            this.grpUpdateSitter.Controls.Add(this.dtpDOB);
            this.grpUpdateSitter.Controls.Add(this.chkSunday);
            this.grpUpdateSitter.Controls.Add(this.chkSaturday);
            this.grpUpdateSitter.Controls.Add(this.chkFriday);
            this.grpUpdateSitter.Controls.Add(this.chkThursday);
            this.grpUpdateSitter.Controls.Add(this.chkWednesday);
            this.grpUpdateSitter.Controls.Add(this.chkTuesday);
            this.grpUpdateSitter.Controls.Add(this.chkMonday);
            this.grpUpdateSitter.Controls.Add(this.txtHourlyRate);
            this.grpUpdateSitter.Controls.Add(this.label16);
            this.grpUpdateSitter.Controls.Add(this.cboMedicalCertified);
            this.grpUpdateSitter.Controls.Add(this.cboChildCareCertified);
            this.grpUpdateSitter.Controls.Add(this.label15);
            this.grpUpdateSitter.Controls.Add(this.label14);
            this.grpUpdateSitter.Controls.Add(this.label10);
            this.grpUpdateSitter.Controls.Add(this.label9);
            this.grpUpdateSitter.Controls.Add(this.btnUpdateSitter);
            this.grpUpdateSitter.Controls.Add(this.txtDescription);
            this.grpUpdateSitter.Controls.Add(this.txtEirCode);
            this.grpUpdateSitter.Controls.Add(this.txtStreet);
            this.grpUpdateSitter.Controls.Add(this.txtTown);
            this.grpUpdateSitter.Controls.Add(this.txtCounty);
            this.grpUpdateSitter.Controls.Add(this.txtPhoneNo);
            this.grpUpdateSitter.Controls.Add(this.txtEmail);
            this.grpUpdateSitter.Controls.Add(this.label13);
            this.grpUpdateSitter.Controls.Add(this.txtLastName);
            this.grpUpdateSitter.Controls.Add(this.txtFirstName);
            this.grpUpdateSitter.Controls.Add(this.label12);
            this.grpUpdateSitter.Controls.Add(this.label11);
            this.grpUpdateSitter.Controls.Add(this.label8);
            this.grpUpdateSitter.Controls.Add(this.label7);
            this.grpUpdateSitter.Controls.Add(this.label6);
            this.grpUpdateSitter.Controls.Add(this.label5);
            this.grpUpdateSitter.Controls.Add(this.label4);
            this.grpUpdateSitter.Controls.Add(this.label3);
            this.grpUpdateSitter.Controls.Add(this.label2);
            this.grpUpdateSitter.Controls.Add(this.label1);
            this.grpUpdateSitter.Location = new System.Drawing.Point(82, 37);
            this.grpUpdateSitter.Margin = new System.Windows.Forms.Padding(2);
            this.grpUpdateSitter.Name = "grpUpdateSitter";
            this.grpUpdateSitter.Padding = new System.Windows.Forms.Padding(2);
            this.grpUpdateSitter.Size = new System.Drawing.Size(736, 526);
            this.grpUpdateSitter.TabIndex = 4;
            this.grpUpdateSitter.TabStop = false;
            this.grpUpdateSitter.Text = "Update Sitter";
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "Irish",
            "Spanish",
            "Italian",
            "French",
            "Greman",
            "Ukrainian",
            "Russian",
            "Korean",
            "Japanese",
            "Mandarin"});
            this.cboLanguage.Location = new System.Drawing.Point(492, 242);
            this.cboLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(160, 21);
            this.cboLanguage.TabIndex = 45;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(99, 154);
            this.dtpDOB.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(142, 20);
            this.dtpDOB.TabIndex = 44;
            this.dtpDOB.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunday.Location = new System.Drawing.Point(199, 394);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(75, 21);
            this.chkSunday.TabIndex = 42;
            this.chkSunday.Text = "Sunday";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaturday.Location = new System.Drawing.Point(199, 371);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(84, 21);
            this.chkSaturday.TabIndex = 41;
            this.chkSaturday.Text = "Saturday";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriday.Location = new System.Drawing.Point(199, 348);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(66, 21);
            this.chkFriday.TabIndex = 40;
            this.chkFriday.Text = "Friday";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThursday.Location = new System.Drawing.Point(99, 417);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(87, 21);
            this.chkThursday.TabIndex = 39;
            this.chkThursday.Text = "Thursday";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWednesday.Location = new System.Drawing.Point(99, 394);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(102, 21);
            this.chkWednesday.TabIndex = 38;
            this.chkWednesday.Text = "Wednesday";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTuesday.Location = new System.Drawing.Point(99, 371);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(82, 21);
            this.chkTuesday.TabIndex = 37;
            this.chkTuesday.Text = "Tuesday";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonday.Location = new System.Drawing.Point(99, 348);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(77, 21);
            this.chkMonday.TabIndex = 36;
            this.chkMonday.Text = "Monday";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(496, 383);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtHourlyRate.MaxLength = 4;
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(115, 20);
            this.txtHourlyRate.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(382, 383);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Hourly Rate";
            // 
            // cboMedicalCertified
            // 
            this.cboMedicalCertified.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicalCertified.FormattingEnabled = true;
            this.cboMedicalCertified.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboMedicalCertified.Location = new System.Drawing.Point(496, 292);
            this.cboMedicalCertified.Margin = new System.Windows.Forms.Padding(2);
            this.cboMedicalCertified.Name = "cboMedicalCertified";
            this.cboMedicalCertified.Size = new System.Drawing.Size(92, 21);
            this.cboMedicalCertified.TabIndex = 32;
            // 
            // cboChildCareCertified
            // 
            this.cboChildCareCertified.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChildCareCertified.FormattingEnabled = true;
            this.cboChildCareCertified.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboChildCareCertified.Location = new System.Drawing.Point(151, 290);
            this.cboChildCareCertified.Margin = new System.Windows.Forms.Padding(2);
            this.cboChildCareCertified.Name = "cboChildCareCertified";
            this.cboChildCareCertified.Size = new System.Drawing.Size(92, 21);
            this.cboChildCareCertified.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 346);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Availabilty";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(379, 293);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Medical Certified";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 293);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Child care Certified";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "D.O.B";
            // 
            // btnUpdateSitter
            // 
            this.btnUpdateSitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSitter.Location = new System.Drawing.Point(256, 471);
            this.btnUpdateSitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSitter.Name = "btnUpdateSitter";
            this.btnUpdateSitter.Size = new System.Drawing.Size(137, 28);
            this.btnUpdateSitter.TabIndex = 25;
            this.btnUpdateSitter.Text = "Update Sitter";
            this.btnUpdateSitter.UseVisualStyleBackColor = true;
            this.btnUpdateSitter.Click += new System.EventHandler(this.btnUpdateSitter_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(496, 340);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 20);
            this.txtDescription.TabIndex = 21;
            // 
            // txtEirCode
            // 
            this.txtEirCode.Location = new System.Drawing.Point(103, 246);
            this.txtEirCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEirCode.MaxLength = 7;
            this.txtEirCode.Name = "txtEirCode";
            this.txtEirCode.Size = new System.Drawing.Size(140, 20);
            this.txtEirCode.TabIndex = 20;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(494, 202);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(140, 20);
            this.txtStreet.TabIndex = 19;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(101, 201);
            this.txtTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTown.MaxLength = 30;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(140, 20);
            this.txtTown.TabIndex = 15;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(492, 154);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.MaxLength = 30;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(140, 20);
            this.txtCounty.TabIndex = 18;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(494, 115);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNo.MaxLength = 10;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(140, 20);
            this.txtPhoneNo.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 113);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(377, 152);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "County";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(494, 72);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 67);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(379, 339);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(381, 246);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Language(s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "EirCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Town";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sitter ID";
            // 
            // cboSitterID
            // 
            this.cboSitterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSitterID.FormattingEnabled = true;
            this.cboSitterID.Location = new System.Drawing.Point(99, 33);
            this.cboSitterID.Margin = new System.Windows.Forms.Padding(2);
            this.cboSitterID.Name = "cboSitterID";
            this.cboSitterID.Size = new System.Drawing.Size(92, 21);
            this.cboSitterID.TabIndex = 46;
            this.cboSitterID.SelectedIndexChanged += new System.EventHandler(this.cboSitterID_SelectedIndexChanged);
            // 
            // frmUpdateSitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(967, 588);
            this.Controls.Add(this.grpUpdateSitter);
            this.Controls.Add(this.mnuMainMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateSitter";
            this.Text = "frmUpdateSitter";
            this.Load += new System.EventHandler(this.frmUpdateSitter_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpUpdateSitter.ResumeLayout(false);
            this.grpUpdateSitter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpUpdateSitter;
        private System.Windows.Forms.ComboBox cboMedicalCertified;
        private System.Windows.Forms.ComboBox cboChildCareCertified;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdateSitter;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEirCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.ComboBox cboSitterID;
    }
}