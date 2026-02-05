namespace BabysittingSys
{
    partial class frmListBookings
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
            this.grdBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBooking
            // 
            this.grdBooking.AllowUserToAddRows = false;
            this.grdBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooking.Location = new System.Drawing.Point(119, 123);
            this.grdBooking.Name = "grdBooking";
            this.grdBooking.Size = new System.Drawing.Size(556, 127);
            this.grdBooking.TabIndex = 1;
            // 
            // frmListBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdBooking);
            this.Name = "frmListBookings";
            this.Text = "List Bookings in table";
            ((System.ComponentModel.ISupportInitialize)(this.grdBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBooking;
    }
}