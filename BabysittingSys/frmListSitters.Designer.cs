namespace BabysittingSys
{
    partial class frmListSitters
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
            this.grpSittersList = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDisplaySitters = new System.Windows.Forms.Button();
            this.dgvDisplaySitters = new System.Windows.Forms.DataGridView();
            this.grpSittersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaySitters)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSittersList
            // 
            this.grpSittersList.Controls.Add(this.btnClearAll);
            this.grpSittersList.Controls.Add(this.btnDisplaySitters);
            this.grpSittersList.Controls.Add(this.dgvDisplaySitters);
            this.grpSittersList.Location = new System.Drawing.Point(119, 56);
            this.grpSittersList.Name = "grpSittersList";
            this.grpSittersList.Size = new System.Drawing.Size(954, 580);
            this.grpSittersList.TabIndex = 1;
            this.grpSittersList.TabStop = false;
            this.grpSittersList.Text = "Sitters List";
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
            // btnDisplaySitters
            // 
            this.btnDisplaySitters.Location = new System.Drawing.Point(378, 45);
            this.btnDisplaySitters.Name = "btnDisplaySitters";
            this.btnDisplaySitters.Size = new System.Drawing.Size(157, 39);
            this.btnDisplaySitters.TabIndex = 1;
            this.btnDisplaySitters.Text = "Display Sitters";
            this.btnDisplaySitters.UseVisualStyleBackColor = true;
            this.btnDisplaySitters.Click += new System.EventHandler(this.btnDisplaySitters_Click);
            // 
            // dgvDisplaySitters
            // 
            this.dgvDisplaySitters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplaySitters.Location = new System.Drawing.Point(59, 123);
            this.dgvDisplaySitters.Name = "dgvDisplaySitters";
            this.dgvDisplaySitters.RowHeadersWidth = 51;
            this.dgvDisplaySitters.RowTemplate.Height = 24;
            this.dgvDisplaySitters.Size = new System.Drawing.Size(856, 362);
            this.dgvDisplaySitters.TabIndex = 0;
            // 
            // frmListSitters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1193, 693);
            this.Controls.Add(this.grpSittersList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListSitters";
            this.Text = "List sitters in a table";
            this.Load += new System.EventHandler(this.frmListSitters_Load);
            this.grpSittersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaySitters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSittersList;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDisplaySitters;
        private System.Windows.Forms.DataGridView dgvDisplaySitters;
    }
}