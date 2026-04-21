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
    public partial class frmMakeBooking : Form
    {
        frmHome Parent;

        private static int firstBookingID = 3000; //this is the startin ID

        public frmMakeBooking()
        {
            InitializeComponent();
        }

        public frmMakeBooking(frmHome parent)
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

        private void mnuRegisterClient_Click(object sender, EventArgs e)
        {
            frmRegisterClient nextForm = new frmRegisterClient();
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateClient_Click(object sender, EventArgs e)
        {
            frmUpdateClient nextForm = new frmUpdateClient();
            this.Hide();
            nextForm.Show();
        }

        private void mnuRemoveClient_Click(object sender, EventArgs e)
        {
            frmRemoveClient nextForm = new frmRemoveClient();
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateBooking_Click(object sender, EventArgs e)
        {
            frmUpdateBooking nextForm = new frmUpdateBooking();
            this.Hide();
            nextForm.Show();
        }

        private void mnuCancelBooking_Click(object sender, EventArgs e)
        {
            frmUpdateBooking nextForm = new frmUpdateBooking();
            this.Hide();
            nextForm.Show();
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            
        }


        private void cboSitterName_SelectedIndexChanged(object sender, EventArgs e)
        {                       

            if (cboSitterName.SelectedIndex != -1) 
            {
                return;

            }

            int sitterID = Convert.ToInt32(cboSitterName.SelectedValue);

            DataSet ds = Sitters.GetSitterByID(sitterID);

            if (ds.Tables["Sitter_By_ID"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Sitter_By_ID"].Rows[0];

                txtSitterID.Text = dr["SitterID"].ToString();
                txtSitterEmail.Text = dr["SiterEmail"].ToString();
                txtSitterPhoneNo.Text = dr["SitterPhoneNo"].ToString();
                txtHourlyRate.Text = dr["HourlyRate"].ToString();

                calculateTotal();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtClientID.Text.Equals(""))
            {
                MessageBox.Show("Client ID must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientID.Focus();
                return;
            }

            DataSet ds = Clients.GetClientByID(Convert.ToInt32(txtClientID.Text));

            if (ds.Tables["Client_By_ID"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Sitter_By_ID"].Rows[0];

                txtClientName.Text = dr["ClientName"].ToString();
                txtClientEmail.Text = dr["ClientEmail"].ToString();
                txtClientPhoneNo.Text = dr["ClientPhoneNo"].ToString();
                
                calculateTotal();
            }
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            if (txtClientName.Text.Equals(""))
            {
                MessageBox.Show("Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientName.Focus();
                return;
            }
            else if (txtClientName.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Name cannot contain numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientName.Focus();
                return;
            }

            //Validate email

            string email = txtClientEmail.Text;

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (txtClientEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientEmail.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientEmail.Focus();
                return;
            }

            if (txtClientPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("Phone Number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientPhoneNo.Focus();
                return;
            }
            else if (!txtClientPhoneNo.Text.All(char.IsDigit) || !txtClientPhoneNo.Text.StartsWith("08"))
            {
                MessageBox.Show("Phone number is invalid! Phone number has to be all digits and start with 08", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientPhoneNo.Focus();
                return;
            }
            else if (txtClientPhoneNo.Text.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientPhoneNo.Focus();
                return;
            }

            if (txtClientName.Text == "")
            {
                MessageBox.Show("Please enter client name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientName.Focus();
                return;
            }

            if (cboSitterName.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a sitter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSitterName.Focus();
                return;
            }

            if (dtpDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("You cannot select a past date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDate.Value = DateTime.Today;
                return;
            }

            if (dtpTime.Value.Date < DateTime.Today)
            {
                MessageBox.Show("You cannot select a past hour.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpTime.Value = DateTime.Today;
                return;
            }

            if (cboDuration.SelectedIndex == 0) 
            { 
                MessageBox.Show("Please select a duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDuration.Focus();
                return;
            }

            if (!chkPayment.Checked)
            {
                MessageBox.Show("Please agree to the payment terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkPayment.Focus();
                return;
            }

            //save data - 2nd semester
            //Bookings booking = new Bookings(Convert.ToInt32(txtBookingID.Text), Convert.ToInt32(txtClientID.Text),txtClientName,txtClientEmail,txtClientPhoneNo, Convert.ToInt32(txtSitterID.Text),cboSitterName,txtSitterEmail,txtSitterPhoneNo,txtHourlyRate);

                       

            //Cormation message
            MessageBox.Show("A Booking has been made", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            
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
            

            firstBookingID++;
            txtBookingID.Text = firstBookingID.ToString();
        }

        private void calculateTotal()
        {
            if(decimal.TryParse(txtHourlyRate.Text, out decimal rate))
            {
                int hours = cboDuration.SelectedIndex + 1;
                txtTotalCost.Text = (rate *  hours).ToString("0.00");
            }
        }

        private void cboDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

       
    }
}
