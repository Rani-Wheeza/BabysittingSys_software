namespace BabysittingSys
{
    partial class frmRemoveClient
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
            this.mnuBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRemoveClient = new System.Windows.Forms.GroupBox();
            this.cboAgeOfChild = new System.Windows.Forms.ComboBox();
            this.cboNoOfChildren = new System.Windows.Forms.ComboBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.btnRemoveClient = new System.Windows.Forms.Button();
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnuMainMenu.SuspendLayout();
            this.grpRemoveClient.SuspendLayout();
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
            this.mnuMainMenu.Size = new System.Drawing.Size(994, 24);
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
            this.mnuUpdateClient});
            this.mnuClient.Name = "mnuClient";
            this.mnuClient.Size = new System.Drawing.Size(50, 20);
            this.mnuClient.Text = "Client";
            // 
            // mnuRegisterClient
            // 
            this.mnuRegisterClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRegisterClient.Name = "mnuRegisterClient";
            this.mnuRegisterClient.Size = new System.Drawing.Size(150, 22);
            this.mnuRegisterClient.Text = "Register Client";
            this.mnuRegisterClient.Click += new System.EventHandler(this.mnuRegisterClient_Click);
            // 
            // mnuUpdateClient
            // 
            this.mnuUpdateClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuUpdateClient.Name = "mnuUpdateClient";
            this.mnuUpdateClient.Size = new System.Drawing.Size(150, 22);
            this.mnuUpdateClient.Text = "Update Client";
            this.mnuUpdateClient.Click += new System.EventHandler(this.mnuUpdateClient_Click);
            // 
            // mnuBooking
            // 
            this.mnuBooking.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeBooking,
            this.mnuUpdateBooking,
            this.mnuCancelBooking});
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
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(159, 22);
            this.mnuCancelBooking.Text = "Cancel Booking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click);
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
            // grpRemoveClient
            // 
            this.grpRemoveClient.Controls.Add(this.cboAgeOfChild);
            this.grpRemoveClient.Controls.Add(this.cboNoOfChildren);
            this.grpRemoveClient.Controls.Add(this.cboLanguage);
            this.grpRemoveClient.Controls.Add(this.btnRemoveClient);
            this.grpRemoveClient.Controls.Add(this.txtDescription);
            this.grpRemoveClient.Controls.Add(this.txtEirCode);
            this.grpRemoveClient.Controls.Add(this.txtStreet);
            this.grpRemoveClient.Controls.Add(this.txtTown);
            this.grpRemoveClient.Controls.Add(this.txtCounty);
            this.grpRemoveClient.Controls.Add(this.txtPhoneNo);
            this.grpRemoveClient.Controls.Add(this.txtEmail);
            this.grpRemoveClient.Controls.Add(this.label13);
            this.grpRemoveClient.Controls.Add(this.txtLastName);
            this.grpRemoveClient.Controls.Add(this.txtFirstName);
            this.grpRemoveClient.Controls.Add(this.label12);
            this.grpRemoveClient.Controls.Add(this.label11);
            this.grpRemoveClient.Controls.Add(this.label10);
            this.grpRemoveClient.Controls.Add(this.label9);
            this.grpRemoveClient.Controls.Add(this.label8);
            this.grpRemoveClient.Controls.Add(this.label7);
            this.grpRemoveClient.Controls.Add(this.label6);
            this.grpRemoveClient.Controls.Add(this.label5);
            this.grpRemoveClient.Controls.Add(this.label4);
            this.grpRemoveClient.Controls.Add(this.label3);
            this.grpRemoveClient.Controls.Add(this.label2);
            this.grpRemoveClient.Location = new System.Drawing.Point(93, 109);
            this.grpRemoveClient.Margin = new System.Windows.Forms.Padding(2);
            this.grpRemoveClient.Name = "grpRemoveClient";
            this.grpRemoveClient.Padding = new System.Windows.Forms.Padding(2);
            this.grpRemoveClient.Size = new System.Drawing.Size(724, 469);
            this.grpRemoveClient.TabIndex = 3;
            this.grpRemoveClient.TabStop = false;
            this.grpRemoveClient.Text = "Remove Client";
            // 
            // cboAgeOfChild
            // 
            this.cboAgeOfChild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeOfChild.FormattingEnabled = true;
            this.cboAgeOfChild.Items.AddRange(new object[] {
            "3 - 12 months",
            "1 - 5 years",
            "6 - 12 years",
            "13 - 15 years",
            "16 - 18 years"});
            this.cboAgeOfChild.Location = new System.Drawing.Point(506, 288);
            this.cboAgeOfChild.Margin = new System.Windows.Forms.Padding(2);
            this.cboAgeOfChild.Name = "cboAgeOfChild";
            this.cboAgeOfChild.Size = new System.Drawing.Size(116, 21);
            this.cboAgeOfChild.TabIndex = 28;
            // 
            // cboNoOfChildren
            // 
            this.cboNoOfChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNoOfChildren.FormattingEnabled = true;
            this.cboNoOfChildren.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboNoOfChildren.Location = new System.Drawing.Point(126, 295);
            this.cboNoOfChildren.Margin = new System.Windows.Forms.Padding(2);
            this.cboNoOfChildren.Name = "cboNoOfChildren";
            this.cboNoOfChildren.Size = new System.Drawing.Size(116, 21);
            this.cboNoOfChildren.TabIndex = 27;
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
            this.cboLanguage.Location = new System.Drawing.Point(126, 353);
            this.cboLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(160, 21);
            this.cboLanguage.TabIndex = 26;
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveClient.Location = new System.Drawing.Point(292, 406);
            this.btnRemoveClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(137, 28);
            this.btnRemoveClient.TabIndex = 25;
            this.btnRemoveClient.Text = "Remove Client";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(459, 351);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(235, 20);
            this.txtDescription.TabIndex = 21;
            // 
            // txtEirCode
            // 
            this.txtEirCode.Location = new System.Drawing.Point(482, 230);
            this.txtEirCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEirCode.MaxLength = 7;
            this.txtEirCode.Name = "txtEirCode";
            this.txtEirCode.Size = new System.Drawing.Size(140, 20);
            this.txtEirCode.TabIndex = 20;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(101, 232);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(140, 20);
            this.txtStreet.TabIndex = 19;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(482, 167);
            this.txtTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTown.MaxLength = 30;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(140, 20);
            this.txtTown.TabIndex = 15;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(101, 167);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.MaxLength = 30;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(140, 20);
            this.txtCounty.TabIndex = 18;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(482, 100);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNo.MaxLength = 10;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(140, 20);
            this.txtPhoneNo.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 101);
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
            this.label13.Location = new System.Drawing.Point(21, 167);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "County";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(482, 45);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 43);
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
            this.label12.Location = new System.Drawing.Point(377, 353);
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
            this.label11.Location = new System.Drawing.Point(22, 353);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Language(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 292);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Age of Child(ren)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 295);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "No.of children";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 230);
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
            this.label7.Location = new System.Drawing.Point(22, 232);
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
            this.label6.Location = new System.Drawing.Point(377, 167);
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
            this.label5.Location = new System.Drawing.Point(377, 103);
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
            this.label4.Location = new System.Drawing.Point(22, 101);
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
            this.label3.Location = new System.Drawing.Point(377, 43);
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
            this.label2.Location = new System.Drawing.Point(22, 45);
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
            this.label1.Location = new System.Drawing.Point(114, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Client ID";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(194, 55);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.MaxLength = 30;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(140, 20);
            this.txtClientID.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(385, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 26);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmRemoveClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(994, 624);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpRemoveClient);
            this.Controls.Add(this.mnuMainMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRemoveClient";
            this.Text = "frmRemoveClient";
            this.Load += new System.EventHandler(this.frmRemoveClient_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpRemoveClient.ResumeLayout(false);
            this.grpRemoveClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterClient;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem mnuBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpRemoveClient;
        private System.Windows.Forms.Button btnRemoveClient;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.ComboBox cboNoOfChildren;
        private System.Windows.Forms.ComboBox cboAgeOfChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnSearch;
    }
}