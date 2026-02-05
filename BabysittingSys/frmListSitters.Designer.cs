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
            this.grdSitter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdSitter)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSitter
            // 
            this.grdSitter.AllowUserToAddRows = false;
            this.grdSitter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSitter.GridColor = System.Drawing.Color.LightCyan;
            this.grdSitter.Location = new System.Drawing.Point(70, 116);
            this.grdSitter.Name = "grdSitter";
            this.grdSitter.Size = new System.Drawing.Size(556, 127);
            this.grdSitter.TabIndex = 0;
            // 
            // frmListSitters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdSitter);
            this.Name = "frmListSitters";
            this.Text = "List sitters in a table";
            ((System.ComponentModel.ISupportInitialize)(this.grdSitter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSitter;
    }
}