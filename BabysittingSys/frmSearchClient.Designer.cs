namespace BabysittingSys
{
    partial class frmSearchClient
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.dgvSearchClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpClientDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchClient)).BeginInit();
            this.grpClientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(411, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(175, 52);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientID.Multiline = true;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(173, 32);
            this.txtClientID.TabIndex = 1;
            // 
            // dgvSearchClient
            // 
            this.dgvSearchClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchClient.Location = new System.Drawing.Point(22, 42);
            this.dgvSearchClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSearchClient.Name = "dgvSearchClient";
            this.dgvSearchClient.RowHeadersWidth = 51;
            this.dgvSearchClient.RowTemplate.Height = 24;
            this.dgvSearchClient.Size = new System.Drawing.Size(933, 231);
            this.dgvSearchClient.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ClientID";
            // 
            // grpClientDetails
            // 
            this.grpClientDetails.Controls.Add(this.btnClear);
            this.grpClientDetails.Controls.Add(this.dgvSearchClient);
            this.grpClientDetails.Location = new System.Drawing.Point(51, 130);
            this.grpClientDetails.Name = "grpClientDetails";
            this.grpClientDetails.Size = new System.Drawing.Size(980, 355);
            this.grpClientDetails.TabIndex = 4;
            this.grpClientDetails.TabStop = false;
            this.grpClientDetails.Text = "Client Details";
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
            // frmSearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1109, 563);
            this.Controls.Add(this.grpClientDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmSearchClient";
            this.Text = "Search Clietnts";
            this.Load += new System.EventHandler(this.frmSearchClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchClient)).EndInit();
            this.grpClientDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.DataGridView dgvSearchClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpClientDetails;
        private System.Windows.Forms.Button btnClear;
    }
}