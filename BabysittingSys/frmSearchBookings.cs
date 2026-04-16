using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabysittingSys
{
    public partial class frmSearchBookings : Form
    {
        public frmSearchBookings()
        {
            InitializeComponent();
        }

        private void frmSearchBookings_Load(object sender, EventArgs e)
        {
            dgvSearchBooking.ReadOnly = true;
            dgvSearchBooking.AllowUserToDeleteRows = false;
            dgvSearchBooking.AllowUserToAddRows = false;
            dgvSearchBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBookingID.Text.Equals(""))
            {
                MessageBox.Show("Booking ID must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }

            DataSet ds = Bookings.GetBookingByID(Convert.ToInt32(txtBookingID.Text));

            if (ds.Tables["Booking_By_ID"].Rows.Count == 0)
            {
                MessageBox.Show("No Booking found with that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }

            dgvSearchBooking.DataSource = ds.Tables["Booking_By_ID"];

            Convert.ToInt32(txtBookingID.Text);

            if (!txtBookingID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Booking ID must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }
        }
                
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookingID.Clear();
            dgvSearchBooking.DataSource = null;
            dgvSearchBooking.Rows.Clear();
            dgvSearchBooking.Refresh();

            txtBookingID.Focus();
        }
    }
}
