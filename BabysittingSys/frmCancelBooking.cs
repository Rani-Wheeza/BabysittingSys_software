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
    
    public partial class frmCancelBooking : Form
    {
        frmHome Parent;
        public frmCancelBooking()
        {
            InitializeComponent();
        }

        public frmCancelBooking(frmHome parent)
        {
            InitializeComponent();

            this.Parent = parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Get confirmation from user on if they would kie to exit the app/form
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //check if user clicked yes
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
        }

        private void mnuMakeBooking_Click(object sender, EventArgs e)
        {
            frmMakeBooking nextForm = new frmMakeBooking(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateBooking_Click(object sender, EventArgs e)
        {
            frmUpdateBooking nextForm = new frmUpdateBooking(this.Parent);//not sure about the this.Parent part.
            this.Hide();
            nextForm.Show();
        }

        private void frmCancelBooking_Load (object sender, EventArgs e)
        {
            
            
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

            DataRow dr = ds.Tables["Booking_By_ID"].Rows[0];

            txtClientID.Text = dr["ClientID"].ToString();
            txtClientName.Text = dr["ClientName"].ToString();
            txtClientEmail.Text = dr["ClientEmail"].ToString();
            txtClientPhoneNo.Text = dr["ClientPhone"].ToString();
            txtSitterID.Text = dr["SitterID"].ToString();
            cboSitterName.Text = dr["SitterName"].ToString();
            txtSitterEmail.Text = dr["SitterEmail"].ToString();
            txtSitterPhoneNo.Text = dr["SitterPhoneNo"].ToString();
            txtHourlyRate.Text = dr["HourlyRate"].ToString();
            dtpDate.Value = Convert.ToDateTime(dr["BookDate"]);
            dtpTime.Value = Convert.ToDateTime(dr["BookTime"]);
            cboDuration.Text = dr["Duration"].ToString();
            txtTotalCost.Text = dr["TotalCost"].ToString();
            chkPayment.Checked = dr["Payment"].ToString() == "Yes";
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {

            //save data - 2nd semester
            if (txtBookingID.Text.Equals(""))
            {
                MessageBox.Show("Booking ID must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel booking?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.No) 
            {
                return;
            }

            Bookings booking = new Bookings(Convert.ToInt32(txtBookingID.Text), Convert.ToInt32(txtClientID.Text), txtClientName.Text, txtClientEmail.Text, txtClientPhoneNo.Text, Convert.ToInt32(txtSitterID.Text), cboSitterName.Text, txtSitterEmail.Text, txtSitterPhoneNo.Text, txtHourlyRate.Text, dtpDate.Value, dtpTime.Value, Convert.ToInt32(cboDuration.Text), Convert.ToDecimal(txtTotalCost.Text), "Yes");
            
            booking.CancelBooking();

            //Cormation message
            MessageBox.Show("Booking has been cancelled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtBookingID.Clear();
            txtClientID.Clear();
            txtClientName.Clear();
            txtClientPhoneNo.Clear();
            txtClientEmail.Clear();
            txtSitterID.Clear();
            txtSitterEmail.Clear();
            txtSitterPhoneNo.Clear();
            txtHourlyRate.Clear();
            cboSitterName.SelectedIndex = -1;
            cboDuration.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
            chkPayment.Checked = false;

            txtBookingID.Focus();

            grpCancelBooking.Visible = false;

        }

        
    }

}
