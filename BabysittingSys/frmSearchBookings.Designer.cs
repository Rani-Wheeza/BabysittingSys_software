namespace BabysittingSys
{
    partial class frmSearchBookings
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
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSearchBooking = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.btnClear);
            this.grpBookingDetails.Controls.Add(this.dgvSearchBooking);
            this.grpBookingDetails.Location = new System.Drawing.Point(105, 156);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(980, 355);
            this.grpBookingDetails.TabIndex = 8;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Details";
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
            // dgvSearchBooking
            // 
            this.dgvSearchBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBooking.Location = new System.Drawing.Point(22, 42);
            this.dgvSearchBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSearchBooking.Name = "dgvSearchBooking";
            this.dgvSearchBooking.RowHeadersWidth = 51;
            this.dgvSearchBooking.RowTemplate.Height = 24;
            this.dgvSearchBooking.Size = new System.Drawing.Size(933, 231);
            this.dgvSearchBooking.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "BookingID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(229, 78);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingID.Multiline = true;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(173, 32);
            this.txtBookingID.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(465, 78);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearchBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1191, 589);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmSearchBookings";
            this.Text = "frmSearchBookings";
            this.Load += new System.EventHandler(this.frmSearchBookings_Load);
            this.grpBookingDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSearchBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Button btnSearch;
    }
}