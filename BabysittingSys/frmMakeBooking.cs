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
            txtBookingID.Text = firstBookingID.ToString();

            cboClientID.Items.Add("1013");
            cboClientID.Items.Add("1015");
            cboClientID.Items.Add("1017");
            cboClientID.Items.Add("1024");
            cboClientID.Items.Add("1036");

            cboSitterName.Items.Add("Sarah O'Grady");
            cboSitterName.Items.Add("Aoife Murphy");
            cboSitterName.Items.Add("Ciara Donnelly");
            cboSitterName.Items.Add("Saoirse O'Sullivan");
            cboSitterName.Items.Add("Caoimhe Walsh");
        }

        private void cboClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientID.Text == "1013")
            {
                txtClientName.Text = "Anna Joy";
                txtClientEmail.Text = "anna.joy23@example.com";
                txtClientPhoneNo.Text = "0832451129";
            }
            else if (cboClientID.Text == "1024")
            {
                txtClientName.Text = "Mark Kim";
                txtClientEmail.Text = "mark.kim89@example.com";
                txtClientPhoneNo.Text = "0856729041";
            }
            else if (cboClientID.Text == "1015")
            {
                txtClientName.Text = "Sarah Cole";
                txtClientEmail.Text = "sarah.cole04@example.com";
                txtClientPhoneNo.Text = "0873195570";
            }
            else if (cboClientID.Text == "1036")
            {
                txtClientName.Text = "Daniel O'Reilly";
                txtClientEmail.Text = "daniel.oreilly@example.com";
                txtClientPhoneNo.Text = "0869102234";
            }
            else if (cboClientID.Text == "1017")
            {
                txtClientName.Text = "Lily Brenda";
                txtClientEmail.Text = "lily.banda99@example.com";
                txtClientPhoneNo.Text = "0894307786";
            }

        }



        private void cboSitterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSitterName.Text == "Sarah O'Grady")
            {
                txtSitterID.Text = "2003";
                txtSitterEmail.Text = "sarah2@gmail.com";
                txtSitterPhoneNo.Text = "0848261852";
                txtHourlyRate.Text = "12";
            }

            else if (cboSitterName.Text == "Aoife Murphy")
            {
                txtSitterID.Text = "2004";
                txtSitterEmail.Text = "murphy.a@gmail.com";
                txtSitterPhoneNo.Text = "0850379963";
                txtHourlyRate.Text = "24";
            }

            else if (cboSitterName.Text == "Ciara Donnelly")
            {
                txtSitterID.Text = "2005";
                txtSitterEmail.Text = "ciaradonnelly@gmail.com";
                txtSitterPhoneNo.Text = "0827386277";
                txtHourlyRate.Text = "15.50";
            }

            else if (cboSitterName.Text == "Saoirse O'Sullivan")
            {
                txtSitterID.Text = "2006";
                txtSitterEmail.Text = "saoirseos@gmail.com";
                txtSitterPhoneNo.Text = "0869781639";
                txtHourlyRate.Text = "13.50";
            }

            else if (cboSitterName.Text == "Caoimhe Walsh")
            {
                txtSitterID.Text = "2007";
                txtSitterEmail.Text = "walshc@gmail.com";
                txtSitterPhoneNo.Text = "0813960070";
                txtHourlyRate.Text = "18";
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


            //Cormation message
            MessageBox.Show("A Booking has been made", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI

            cboClientID.SelectedIndex = -1;
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
