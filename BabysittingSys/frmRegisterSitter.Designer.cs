namespace BabysittingSys
{
    partial class frmRegisterSitter
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
            this.mnuUpdateSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRedisterSitter = new System.Windows.Forms.GroupBox();
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
            this.btnRegisterSitter = new System.Windows.Forms.Button();
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
            this.txtSitterID = new System.Windows.Forms.TextBox();
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
            this.mnuMainMenu.SuspendLayout();
            this.grpRedisterSitter.SuspendLayout();
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
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(1259, 28);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(64, 24);
            this.mnuHome.Text = "Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuSitter
            // 
            this.mnuSitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateSitter,
            this.mnuRemoveSitter});
            this.mnuSitter.Name = "mnuSitter";
            this.mnuSitter.Size = new System.Drawing.Size(58, 24);
            this.mnuSitter.Text = "Sitter";
            // 
            // mnuUpdateSitter
            // 
            this.mnuUpdateSitter.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuUpdateSitter.Name = "mnuUpdateSitter";
            this.mnuUpdateSitter.Size = new System.Drawing.Size(185, 26);
            this.mnuUpdateSitter.Text = "Update Sitter";
            this.mnuUpdateSitter.Click += new System.EventHandler(this.mnuUpdateSitter_Click);
            // 
            // mnuRemoveSitter
            // 
            this.mnuRemoveSitter.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRemoveSitter.Name = "mnuRemoveSitter";
            this.mnuRemoveSitter.Size = new System.Drawing.Size(185, 26);
            this.mnuRemoveSitter.Text = "Remove Sitter";
            this.mnuRemoveSitter.Click += new System.EventHandler(this.mnuRemoveSitter_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.BackColor = System.Drawing.Color.Crimson;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.BackColor = System.Drawing.Color.Tomato;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 24);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpRedisterSitter
            // 
            this.grpRedisterSitter.Controls.Add(this.cboLanguage);
            this.grpRedisterSitter.Controls.Add(this.dtpDOB);
            this.grpRedisterSitter.Controls.Add(this.chkSunday);
            this.grpRedisterSitter.Controls.Add(this.chkSaturday);
            this.grpRedisterSitter.Controls.Add(this.chkFriday);
            this.grpRedisterSitter.Controls.Add(this.chkThursday);
            this.grpRedisterSitter.Controls.Add(this.chkWednesday);
            this.grpRedisterSitter.Controls.Add(this.chkTuesday);
            this.grpRedisterSitter.Controls.Add(this.chkMonday);
            this.grpRedisterSitter.Controls.Add(this.txtHourlyRate);
            this.grpRedisterSitter.Controls.Add(this.label16);
            this.grpRedisterSitter.Controls.Add(this.cboMedicalCertified);
            this.grpRedisterSitter.Controls.Add(this.cboChildCareCertified);
            this.grpRedisterSitter.Controls.Add(this.label15);
            this.grpRedisterSitter.Controls.Add(this.label14);
            this.grpRedisterSitter.Controls.Add(this.label10);
            this.grpRedisterSitter.Controls.Add(this.label9);
            this.grpRedisterSitter.Controls.Add(this.btnRegisterSitter);
            this.grpRedisterSitter.Controls.Add(this.txtDescription);
            this.grpRedisterSitter.Controls.Add(this.txtEirCode);
            this.grpRedisterSitter.Controls.Add(this.txtStreet);
            this.grpRedisterSitter.Controls.Add(this.txtTown);
            this.grpRedisterSitter.Controls.Add(this.txtCounty);
            this.grpRedisterSitter.Controls.Add(this.txtPhoneNo);
            this.grpRedisterSitter.Controls.Add(this.txtEmail);
            this.grpRedisterSitter.Controls.Add(this.label13);
            this.grpRedisterSitter.Controls.Add(this.txtLastName);
            this.grpRedisterSitter.Controls.Add(this.txtFirstName);
            this.grpRedisterSitter.Controls.Add(this.txtSitterID);
            this.grpRedisterSitter.Controls.Add(this.label12);
            this.grpRedisterSitter.Controls.Add(this.label11);
            this.grpRedisterSitter.Controls.Add(this.label8);
            this.grpRedisterSitter.Controls.Add(this.label7);
            this.grpRedisterSitter.Controls.Add(this.label6);
            this.grpRedisterSitter.Controls.Add(this.label5);
            this.grpRedisterSitter.Controls.Add(this.label4);
            this.grpRedisterSitter.Controls.Add(this.label3);
            this.grpRedisterSitter.Controls.Add(this.label2);
            this.grpRedisterSitter.Controls.Add(this.label1);
            this.grpRedisterSitter.Location = new System.Drawing.Point(125, 59);
            this.grpRedisterSitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRedisterSitter.Name = "grpRedisterSitter";
            this.grpRedisterSitter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRedisterSitter.Size = new System.Drawing.Size(983, 634);
            this.grpRedisterSitter.TabIndex = 5;
            this.grpRedisterSitter.TabStop = false;
            this.grpRedisterSitter.Text = "Register Sitter";
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
            this.cboLanguage.Location = new System.Drawing.Point(656, 303);
            this.cboLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(212, 24);
            this.cboLanguage.TabIndex = 44;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(135, 186);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDOB.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(188, 22);
            this.dtpDOB.TabIndex = 43;
            this.dtpDOB.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunday.Location = new System.Drawing.Point(265, 485);
            this.chkSunday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(86, 24);
            this.chkSunday.TabIndex = 42;
            this.chkSunday.Text = "Sunday";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaturday.Location = new System.Drawing.Point(265, 457);
            this.chkSaturday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(97, 24);
            this.chkSaturday.TabIndex = 41;
            this.chkSaturday.Text = "Saturday";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriday.Location = new System.Drawing.Point(265, 428);
            this.chkFriday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(77, 24);
            this.chkFriday.TabIndex = 40;
            this.chkFriday.Text = "Friday";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThursday.Location = new System.Drawing.Point(132, 513);
            this.chkThursday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(100, 24);
            this.chkThursday.TabIndex = 39;
            this.chkThursday.Text = "Thursday";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWednesday.Location = new System.Drawing.Point(132, 485);
            this.chkWednesday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(118, 24);
            this.chkWednesday.TabIndex = 38;
            this.chkWednesday.Text = "Wednesday";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTuesday.Location = new System.Drawing.Point(132, 457);
            this.chkTuesday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(94, 24);
            this.chkTuesday.TabIndex = 37;
            this.chkTuesday.Text = "Tuesday";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonday.Location = new System.Drawing.Point(132, 428);
            this.chkMonday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(89, 24);
            this.chkMonday.TabIndex = 36;
            this.chkMonday.Text = "Monday";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(661, 471);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHourlyRate.MaxLength = 4;
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(152, 22);
            this.txtHourlyRate.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(509, 471);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 20);
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
            this.cboMedicalCertified.Location = new System.Drawing.Point(661, 359);
            this.cboMedicalCertified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMedicalCertified.Name = "cboMedicalCertified";
            this.cboMedicalCertified.Size = new System.Drawing.Size(121, 24);
            this.cboMedicalCertified.TabIndex = 32;
            // 
            // cboChildCareCertified
            // 
            this.cboChildCareCertified.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChildCareCertified.FormattingEnabled = true;
            this.cboChildCareCertified.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboChildCareCertified.Location = new System.Drawing.Point(201, 357);
            this.cboChildCareCertified.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChildCareCertified.Name = "cboChildCareCertified";
            this.cboChildCareCertified.Size = new System.Drawing.Size(121, 24);
            this.cboChildCareCertified.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Availabilty";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(505, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Medical Certified";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Child care Certified";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "D.O.B";
            // 
            // btnRegisterSitter
            // 
            this.btnRegisterSitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterSitter.Location = new System.Drawing.Point(352, 559);
            this.btnRegisterSitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterSitter.Name = "btnRegisterSitter";
            this.btnRegisterSitter.Size = new System.Drawing.Size(183, 34);
            this.btnRegisterSitter.TabIndex = 25;
            this.btnRegisterSitter.Text = "Register Sitter";
            this.btnRegisterSitter.UseVisualStyleBackColor = true;
            this.btnRegisterSitter.Click += new System.EventHandler(this.btnRegisterSitter_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(661, 418);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 22);
            this.txtDescription.TabIndex = 21;
            // 
            // txtEirCode
            // 
            this.txtEirCode.Location = new System.Drawing.Point(137, 303);
            this.txtEirCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEirCode.MaxLength = 7;
            this.txtEirCode.Name = "txtEirCode";
            this.txtEirCode.Size = new System.Drawing.Size(185, 22);
            this.txtEirCode.TabIndex = 20;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(659, 249);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(185, 22);
            this.txtStreet.TabIndex = 19;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(135, 247);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.MaxLength = 30;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(185, 22);
            this.txtTown.TabIndex = 15;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(656, 190);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCounty.MaxLength = 30;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(185, 22);
            this.txtCounty.TabIndex = 18;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(659, 142);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNo.MaxLength = 10;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(185, 22);
            this.txtPhoneNo.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(503, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "County";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(659, 89);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 22);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 82);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 22);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtSitterID
            // 
            this.txtSitterID.Location = new System.Drawing.Point(135, 44);
            this.txtSitterID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSitterID.MaxLength = 4;
            this.txtSitterID.Name = "txtSitterID";
            this.txtSitterID.ReadOnly = true;
            this.txtSitterID.Size = new System.Drawing.Size(72, 22);
            this.txtSitterID.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(505, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(508, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Language(s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "EirCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Town";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sitter ID";
            // 
            // frmRegisterSitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1259, 704);
            this.Controls.Add(this.grpRedisterSitter);
            this.Controls.Add(this.mnuMainMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegisterSitter";
            this.Text = "frmRegisterSitter";
            this.Load += new System.EventHandler(this.frmRegisterSitter_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpRedisterSitter.ResumeLayout(false);
            this.grpRedisterSitter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpRedisterSitter;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboMedicalCertified;
        private System.Windows.Forms.ComboBox cboChildCareCertified;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegisterSitter;
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
        private System.Windows.Forms.TextBox txtSitterID;
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
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cboLanguage;
    }
}