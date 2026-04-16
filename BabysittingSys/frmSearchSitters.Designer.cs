namespace BabysittingSys
{
    partial class frmSearchSitters
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
            this.grpSitterDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSearchSitter = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSitterID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpSitterDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSitter)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSitterDetails
            // 
            this.grpSitterDetails.Controls.Add(this.btnClear);
            this.grpSitterDetails.Controls.Add(this.dgvSearchSitter);
            this.grpSitterDetails.Location = new System.Drawing.Point(108, 159);
            this.grpSitterDetails.Name = "grpSitterDetails";
            this.grpSitterDetails.Size = new System.Drawing.Size(980, 355);
            this.grpSitterDetails.TabIndex = 8;
            this.grpSitterDetails.TabStop = false;
            this.grpSitterDetails.Text = "Sitter Details";
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
            // dgvSearchSitter
            // 
            this.dgvSearchSitter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSitter.Location = new System.Drawing.Point(22, 42);
            this.dgvSearchSitter.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSearchSitter.Name = "dgvSearchSitter";
            this.dgvSearchSitter.RowHeadersWidth = 51;
            this.dgvSearchSitter.RowTemplate.Height = 24;
            this.dgvSearchSitter.Size = new System.Drawing.Size(933, 231);
            this.dgvSearchSitter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "SitterID";
            // 
            // txtSitterID
            // 
            this.txtSitterID.Location = new System.Drawing.Point(232, 81);
            this.txtSitterID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSitterID.Multiline = true;
            this.txtSitterID.Name = "txtSitterID";
            this.txtSitterID.Size = new System.Drawing.Size(173, 32);
            this.txtSitterID.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(468, 81);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearchSitters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1160, 724);
            this.Controls.Add(this.grpSitterDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSitterID);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmSearchSitters";
            this.Text = "frmSearchSitters";
            this.Load += new System.EventHandler(this.frmSearchSitters_Load);
            this.grpSitterDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSitterDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSearchSitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSitterID;
        private System.Windows.Forms.Button btnSearch;
    }
}