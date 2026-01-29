namespace BabysittingSys
{
    partial class frmRegisterClient
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
            this.mnuUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRegisterClient = new System.Windows.Forms.GroupBox();
            this.btnRegisterClient = new System.Windows.Forms.Button();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.cboAgeOfChild = new System.Windows.Forms.ComboBox();
            this.cboNoOfChildren = new System.Windows.Forms.ComboBox();
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
            this.txtClientID = new System.Windows.Forms.TextBox();
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
            this.mnuMainMenu.SuspendLayout();
            this.grpRegisterClient.SuspendLayout();
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
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(1220, 28);
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
            // mnuClient
            // 
            this.mnuClient.BackColor = System.Drawing.Color.DarkSalmon;
            this.mnuClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateClient,
            this.mnuRemoveClient});
            this.mnuClient.Name = "mnuClient";
            this.mnuClient.Size = new System.Drawing.Size(61, 24);
            this.mnuClient.Text = "Client";
            // 
            // mnuUpdateClient
            // 
            this.mnuUpdateClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuUpdateClient.Name = "mnuUpdateClient";
            this.mnuUpdateClient.Size = new System.Drawing.Size(188, 26);
            this.mnuUpdateClient.Text = "Update Client";
            this.mnuUpdateClient.Click += new System.EventHandler(this.mnuUpdateClient_Click);
            // 
            // mnuRemoveClient
            // 
            this.mnuRemoveClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRemoveClient.Name = "mnuRemoveClient";
            this.mnuRemoveClient.Size = new System.Drawing.Size(188, 26);
            this.mnuRemoveClient.Text = "Remove Client";
            this.mnuRemoveClient.Click += new System.EventHandler(this.mnuRemoveClient_Click);
            // 
            // mnuBooking
            // 
            this.mnuBooking.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeBooking,
            this.mnuUpdateBooking,
            this.mnuCancelBooking});
            this.mnuBooking.Name = "mnuBooking";
            this.mnuBooking.Size = new System.Drawing.Size(78, 24);
            this.mnuBooking.Text = "Booking";
            // 
            // mnuMakeBooking
            // 
            this.mnuMakeBooking.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Size = new System.Drawing.Size(200, 26);
            this.mnuMakeBooking.Text = "Make Booking";
            this.mnuMakeBooking.Click += new System.EventHandler(this.mnuMakeBooking_Click);
            // 
            // mnuUpdateBooking
            // 
            this.mnuUpdateBooking.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuUpdateBooking.Name = "mnuUpdateBooking";
            this.mnuUpdateBooking.Size = new System.Drawing.Size(200, 26);
            this.mnuUpdateBooking.Text = "Update Booking";
            this.mnuUpdateBooking.Click += new System.EventHandler(this.mnuUpdateBooking_Click);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(200, 26);
            this.mnuCancelBooking.Text = "Cancel Booking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click);
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
            // grpRegisterClient
            // 
            this.grpRegisterClient.Controls.Add(this.btnRegisterClient);
            this.grpRegisterClient.Controls.Add(this.cboLanguage);
            this.grpRegisterClient.Controls.Add(this.cboAgeOfChild);
            this.grpRegisterClient.Controls.Add(this.cboNoOfChildren);
            this.grpRegisterClient.Controls.Add(this.txtDescription);
            this.grpRegisterClient.Controls.Add(this.txtEirCode);
            this.grpRegisterClient.Controls.Add(this.txtStreet);
            this.grpRegisterClient.Controls.Add(this.txtTown);
            this.grpRegisterClient.Controls.Add(this.txtCounty);
            this.grpRegisterClient.Controls.Add(this.txtPhoneNo);
            this.grpRegisterClient.Controls.Add(this.txtEmail);
            this.grpRegisterClient.Controls.Add(this.label13);
            this.grpRegisterClient.Controls.Add(this.txtLastName);
            this.grpRegisterClient.Controls.Add(this.txtFirstName);
            this.grpRegisterClient.Controls.Add(this.txtClientID);
            this.grpRegisterClient.Controls.Add(this.label12);
            this.grpRegisterClient.Controls.Add(this.label11);
            this.grpRegisterClient.Controls.Add(this.label10);
            this.grpRegisterClient.Controls.Add(this.label9);
            this.grpRegisterClient.Controls.Add(this.label8);
            this.grpRegisterClient.Controls.Add(this.label7);
            this.grpRegisterClient.Controls.Add(this.label6);
            this.grpRegisterClient.Controls.Add(this.label5);
            this.grpRegisterClient.Controls.Add(this.label4);
            this.grpRegisterClient.Controls.Add(this.label3);
            this.grpRegisterClient.Controls.Add(this.label2);
            this.grpRegisterClient.Controls.Add(this.label1);
            this.grpRegisterClient.Location = new System.Drawing.Point(133, 70);
            this.grpRegisterClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegisterClient.Name = "grpRegisterClient";
            this.grpRegisterClient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegisterClient.Size = new System.Drawing.Size(965, 588);
            this.grpRegisterClient.TabIndex = 2;
            this.grpRegisterClient.TabStop = false;
            this.grpRegisterClient.Text = "Register Client";
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterClient.Location = new System.Drawing.Point(389, 529);
            this.btnRegisterClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(183, 34);
            this.btnRegisterClient.TabIndex = 25;
            this.btnRegisterClient.Text = "Register Client";
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
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
            this.cboLanguage.Location = new System.Drawing.Point(157, 464);
            this.cboLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(212, 24);
            this.cboLanguage.TabIndex = 24;
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
            this.cboAgeOfChild.Location = new System.Drawing.Point(653, 389);
            this.cboAgeOfChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAgeOfChild.Name = "cboAgeOfChild";
            this.cboAgeOfChild.Size = new System.Drawing.Size(153, 24);
            this.cboAgeOfChild.TabIndex = 23;
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
            this.cboNoOfChildren.Location = new System.Drawing.Point(168, 389);
            this.cboNoOfChildren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNoOfChildren.Name = "cboNoOfChildren";
            this.cboNoOfChildren.Size = new System.Drawing.Size(153, 24);
            this.cboNoOfChildren.TabIndex = 22;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(612, 462);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(312, 22);
            this.txtDescription.TabIndex = 21;
            // 
            // txtEirCode
            // 
            this.txtEirCode.Location = new System.Drawing.Point(643, 313);
            this.txtEirCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEirCode.MaxLength = 7;
            this.txtEirCode.Name = "txtEirCode";
            this.txtEirCode.Size = new System.Drawing.Size(185, 22);
            this.txtEirCode.TabIndex = 20;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(135, 315);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(185, 22);
            this.txtStreet.TabIndex = 19;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(643, 235);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.MaxLength = 30;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(185, 22);
            this.txtTown.TabIndex = 15;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(135, 235);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCounty.MaxLength = 30;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(185, 22);
            this.txtCounty.TabIndex = 18;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(643, 153);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNo.MaxLength = 10;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(185, 22);
            this.txtPhoneNo.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 154);
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
            this.label13.Location = new System.Drawing.Point(28, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "County";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(643, 85);
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
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(135, 44);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientID.MaxLength = 4;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(72, 22);
            this.txtClientID.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(503, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Language(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Age of Child(ren)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "No.of children";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "EirCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Town";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 154);
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
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client ID";
            // 
            // frmRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1220, 726);
            this.Controls.Add(this.grpRegisterClient);
            this.Controls.Add(this.mnuMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegisterClient";
            this.Text = "frmRegisterClient";
            this.Load += new System.EventHandler(this.frmRegisterClient_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpRegisterClient.ResumeLayout(false);
            this.grpRegisterClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveClient;
        private System.Windows.Forms.ToolStripMenuItem mnuBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpRegisterClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEirCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.ComboBox cboAgeOfChild;
        private System.Windows.Forms.ComboBox cboNoOfChildren;
        private System.Windows.Forms.Button btnRegisterClient;
    }
}