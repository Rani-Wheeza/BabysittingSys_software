namespace BabysittingSys
{
    partial class frmLIstClients
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
            this.grpClientsList = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDisplayClients = new System.Windows.Forms.Button();
            this.dgvDisplayClients = new System.Windows.Forms.DataGridView();
            this.grpClientsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayClients)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClientsList
            // 
            this.grpClientsList.Controls.Add(this.btnClearAll);
            this.grpClientsList.Controls.Add(this.btnDisplayClients);
            this.grpClientsList.Controls.Add(this.dgvDisplayClients);
            this.grpClientsList.Location = new System.Drawing.Point(190, 60);
            this.grpClientsList.Name = "grpClientsList";
            this.grpClientsList.Size = new System.Drawing.Size(954, 580);
            this.grpClientsList.TabIndex = 0;
            this.grpClientsList.TabStop = false;
            this.grpClientsList.Text = "Clients List";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(405, 519);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(157, 39);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDisplayClients
            // 
            this.btnDisplayClients.Location = new System.Drawing.Point(378, 45);
            this.btnDisplayClients.Name = "btnDisplayClients";
            this.btnDisplayClients.Size = new System.Drawing.Size(157, 39);
            this.btnDisplayClients.TabIndex = 1;
            this.btnDisplayClients.Text = "Display Clients";
            this.btnDisplayClients.UseVisualStyleBackColor = true;
            this.btnDisplayClients.Click += new System.EventHandler(this.btnDisplayClients_Click);
            // 
            // dgvDisplayClients
            // 
            this.dgvDisplayClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayClients.Location = new System.Drawing.Point(59, 123);
            this.dgvDisplayClients.Name = "dgvDisplayClients";
            this.dgvDisplayClients.RowHeadersWidth = 51;
            this.dgvDisplayClients.RowTemplate.Height = 24;
            this.dgvDisplayClients.Size = new System.Drawing.Size(856, 362);
            this.dgvDisplayClients.TabIndex = 0;
            // 
            // frmLIstClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1300, 672);
            this.Controls.Add(this.grpClientsList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLIstClients";
            this.Text = "frmLIstClients";
            this.Load += new System.EventHandler(this.frmLIstClients_Load);
            this.grpClientsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientsList;
        private System.Windows.Forms.Button btnDisplayClients;
        private System.Windows.Forms.DataGridView dgvDisplayClients;
        private System.Windows.Forms.Button btnClearAll;
    }
}