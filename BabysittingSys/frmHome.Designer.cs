namespace BabysittingSys
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveSitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoginAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuAdmin,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(868, 24);
            this.mnuMainMenu.TabIndex = 0;
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
            this.mnuRegisterClient.Size = new System.Drawing.Size(180, 22);
            this.mnuRegisterClient.Text = "Register Client";
            this.mnuRegisterClient.Click += new System.EventHandler(this.mnuRegisterClient_Click);
            // 
            // mnuUpdateClient
            // 
            this.mnuUpdateClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuUpdateClient.Name = "mnuUpdateClient";
            this.mnuUpdateClient.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateClient.Text = "Update Client";
            this.mnuUpdateClient.Click += new System.EventHandler(this.mnuUpdateClient_Click);
            // 
            // mnuRemoveClient
            // 
            this.mnuRemoveClient.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRemoveClient.Name = "mnuRemoveClient";
            this.mnuRemoveClient.Size = new System.Drawing.Size(180, 22);
            this.mnuRemoveClient.Text = "Remove Client";
            this.mnuRemoveClient.Click += new System.EventHandler(this.mnuRemoveClient_Click);
            // 
            // mnuSitter
            // 
            this.mnuSitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterSitter,
            this.mnuUpdateSitter,
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
            // mnuUpdateSitter
            // 
            this.mnuUpdateSitter.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuUpdateSitter.Name = "mnuUpdateSitter";
            this.mnuUpdateSitter.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateSitter.Text = "Update Sitter";
            this.mnuUpdateSitter.Click += new System.EventHandler(this.mnuUpdateSitter_Click);
            // 
            // mnuRemoveSitter
            // 
            this.mnuRemoveSitter.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuRemoveSitter.Name = "mnuRemoveSitter";
            this.mnuRemoveSitter.Size = new System.Drawing.Size(180, 22);
            this.mnuRemoveSitter.Text = "Remove Sitter";
            this.mnuRemoveSitter.Click += new System.EventHandler(this.mnuRemoveSitter_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoginAdmin});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuLoginAdmin
            // 
            this.mnuLoginAdmin.BackColor = System.Drawing.Color.PeachPuff;
            this.mnuLoginAdmin.Name = "mnuLoginAdmin";
            this.mnuLoginAdmin.Size = new System.Drawing.Size(104, 22);
            this.mnuLoginAdmin.Text = "Login";
            this.mnuLoginAdmin.Click += new System.EventHandler(this.mnuLoginAdmin_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(868, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmHome";
            this.Text = "Home Page";
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
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterClient;
        private System.Windows.Forms.ToolStripMenuItem mnuSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterSitter;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateSitter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuLoginAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveClient;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveSitter;
    }
}

