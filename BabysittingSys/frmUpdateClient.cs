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
    public partial class frmUpdateClient : Form
    {
        frmHome Parent;
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        public frmUpdateClient(frmHome parent)
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
            frmRegisterClient frmRegisterClient = new frmRegisterClient();
            this.Hide();
            frmRegisterClient.Show();
        }

        private void mnuRemoveClient_Click(object sender, EventArgs e)
        {
            frmRemoveClient nextForm = new frmRemoveClient(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            cboClientID.Items.Add("1013");
            cboClientID.Items.Add("1024");
            cboClientID.Items.Add("1015");
            cboClientID.Items.Add("1036");
            cboClientID.Items.Add("1017");
        }

        private void cboClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientID.Text == "1013")
            {
                txtFirstName.Text = "Anna";
                txtLastName.Text = "Joy";
                txtEmail.Text = "anna.joy23@example.com";
                txtPhoneNo.Text = "0832451129";
                txtCounty.Text = "Kerry";
                txtTown.Text = "Killerney";
                txtStreet.Text = "56 Some Street";
                txtEirCode.Text = "V93 1234";
                cboNoOfChildren.SelectedIndex = 2;
                cboAgeOfChild.SelectedIndex = 3;
                cboLanguage.SelectedIndex = 5;
                txtDescription.Text = "New to the area and hoping to connect with trustworthy sitters " +
                    "for date nights and last-minute support";
            }
            else if (cboClientID.Text == "1024")
            {
                txtFirstName.Text = "Mark";
                txtLastName.Text = "Kim";
                txtEmail.Text = "mark.kim89@example.com";
                txtPhoneNo.Text = "0856729041";
                txtCounty.Text = "Dublin";
                txtTown.Text = "Dublin 2";
                txtStreet.Text = "10 St. Stephen’s Green";
                txtEirCode.Text = "D02 XY45";
                cboNoOfChildren.SelectedIndex = 1;
                cboAgeOfChild.SelectedIndex = 2;
                cboLanguage.SelectedIndex = 2;
                txtDescription.Text = "We need a dependable babysitter comfortable with pets " +
                    "and light homework help for our 8-year-old.";
            }
            else if (cboClientID.Text == "1015")
            {
                txtFirstName.Text = "Sarah";
                txtLastName.Text = "Cole";
                txtEmail.Text = "sarah.cole04@example.com";
                txtPhoneNo.Text = "0873195570";
                txtCounty.Text = "Cork";
                txtTown.Text = "Cork city";
                txtStreet.Text = "34 Patrick Street";
                txtEirCode.Text = "T12 ABC1";
                cboNoOfChildren.SelectedIndex = 4;
                cboAgeOfChild.SelectedIndex = 4;
                cboLanguage.SelectedIndex = 6;
                txtDescription.Text = "Family of three looking for someone patient and " +
                    "energetic to mind our toddler a few hours a week";
            }
            else if (cboClientID.Text == "1036")
            {
                txtFirstName.Text = "Daniel";
                txtLastName.Text = "O'Reilly";
                txtEmail.Text = "daniel.oreilly@example.com";
                txtPhoneNo.Text = "0869102234";
                txtCounty.Text = "Carlow";
                txtTown.Text = "Carlow";
                txtStreet.Text = "12 Church Lane";
                txtEirCode.Text = "R93 9999";
                cboNoOfChildren.SelectedIndex = 3;
                cboAgeOfChild.SelectedIndex = 3;
                cboLanguage.SelectedIndex = 4;
                txtDescription.Text = "Family of three looking for someone patient " +
                    "and energetic to mind our toddler a few hours a week";
            }
            else if (cboClientID.Text == "1017")
            {
                txtFirstName.Text = "Lily";
                txtLastName.Text = "Brenda";
                txtEmail.Text = "lily.banda99@example.com";
                txtPhoneNo.Text = "0894307786";
                txtCounty.Text = "Donegal";
                txtTown.Text = "Letterkenny";
                txtStreet.Text = "5 Main Street";
                txtEirCode.Text = "F92 5678";
                cboNoOfChildren.SelectedIndex = 2;
                cboAgeOfChild.SelectedIndex = 1;
                cboLanguage.SelectedIndex = 1;
                txtDescription.Text = "Busy working parents seeking a caring, punctual " +
                    "babysitter who can help with after-school care.";
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            //Validate the data

            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            else if (txtFirstName.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("First Name cannot contain numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (txtLastName.Text.Equals(""))
            {
                MessageBox.Show("Last Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }
            else if (txtLastName.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Last Name cannot contain numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }

            //Validate email

            string email = txtEmail.Text;

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("Phone Number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }
            else if (!txtPhoneNo.Text.All(char.IsDigit) || !txtPhoneNo.Text.StartsWith("08"))
            {
                MessageBox.Show("Phone number is invalid! Phone number has to be all digits and start with 08", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }
            else if (txtPhoneNo.Text.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }

            if (txtCounty.Text.Equals(""))
            {
                MessageBox.Show("County must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }
            else if (txtCounty.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("County cannot contain numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }

            if (txtTown.Text.Equals(""))
            {
                MessageBox.Show("Town must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }
            else if (txtTown.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Town cannot contain numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }

            if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("Street must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            else if (txtStreet.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Street cannot contain numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }

            string eircode = txtEirCode.Text;

            string eircodePattern = @"(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$";

            /*
             Title: Validation for Irish Eircode
             Author: Asunez
             Site ownwer/sponcer: Stackoverflow
             Date: Oct 29, 2015
             Code version: edited Mar 26, 2021 by user Andrew
             Availability: https://stackoverflow.com/questions/33391412/validation-for-irish-eircode
             (Accessed 24/11/2025)
             Modified: No*/

            if (txtEirCode.Text.Equals(""))
            {
                MessageBox.Show("EirCode must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEirCode.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(eircode, eircodePattern))
            {
                MessageBox.Show("Invalid Eircode format! Eircode must be all CAPS with no spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEirCode.Focus();
                return;
            }

            if (cboNoOfChildren.Text.Equals(""))
            {
                MessageBox.Show("Choose number of child(ren)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNoOfChildren.Focus();
                return;
            }

            if (cboAgeOfChild.Text.Equals(""))
            {
                MessageBox.Show("Choose age of child(ren)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAgeOfChild.Focus();
                return;
            }


            if (cboLanguage.Text.Equals(""))
            {
                MessageBox.Show("Choose prefered language(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLanguage.Focus();
                return;
            }


            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            //save data - 2nd semester


            //Cormation message
            MessageBox.Show("Are you sure you want to update client details", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            
            //Reset UI
            cboClientID.SelectedIndex = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();
            txtCounty.Clear();
            txtTown.Clear();
            txtStreet.Clear();
            txtEirCode.Clear();
            cboNoOfChildren.SelectedIndex = -1;
            cboAgeOfChild.SelectedIndex = -1;
            cboLanguage.SelectedIndex = -1;
            txtDescription.Clear();

            cboClientID.Focus();

        }

       
    }
}

