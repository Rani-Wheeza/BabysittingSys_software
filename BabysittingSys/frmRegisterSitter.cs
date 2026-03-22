using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BabysittingSys
{
    public partial class frmRegisterSitter : Form  //Sitters
    {
        frmHome Parent;

        
        public frmRegisterSitter()
        {
            InitializeComponent();
        }

        public frmRegisterSitter(frmHome parent)
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

        private void mnuUpdateSitter_Click(object sender, EventArgs e)
        {
            frmUpdateSitter nextForm = new frmUpdateSitter(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRemoveSitter_Click(object sender, EventArgs e)
        {
            frmRemoveClient nextForm = new frmRemoveClient(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
        }

        private void frmRegisterSitter_Load(object sender, EventArgs e)
        {
            txtSitterID.Text = Sitters.GetNextSitterID().ToString();


        }

        private void btnRegisterSitter_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (txtLastName.Text.Equals(""))
            {
                MessageBox.Show("Last Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            DateTime dob = dtpDOB.Value;
            int age = DateTime.Now.Year - dob.Year;

            if ((dob.Date > DateTime.Now.AddYears(-age)))
            {
                age--;
            }

            if(age < 18)
            {
                MessageBox.Show("Sitter muset be atleast 18 years old", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDOB.Focus();
                return;
            }

            if (dtpDOB.MaxDate.Equals(""))
            {
                MessageBox.Show("A Date must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDOB.Focus();
                return;
            }

            if (txtCounty.Text.Equals(""))
            {
                MessageBox.Show("County must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }

            if (txtTown.Text.Equals(""))
            {
                MessageBox.Show("Town must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }

            if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("Street must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (cboLanguage.Text.Equals(""))
            {
                MessageBox.Show("Choose prefered language(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLanguage.Focus();
                return;
            }

            if (cboChildCareCertified.Text.Equals(""))
            {
                MessageBox.Show("Select yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboChildCareCertified.Focus();
                return;
            }

            if (cboMedicalCertified.Text.Equals(""))
            {
                MessageBox.Show("Select yes or no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMedicalCertified.Focus();
                return;
            }


            //atleast one has to be selceted to move on with saving the data.
            if (!chkMonday.Checked && !chkTuesday.Checked && !chkWednesday.Checked && !chkThursday.Checked && !chkFriday.Checked && !chkSaturday.Checked && !chkSunday.Checked)
            {
                MessageBox.Show("Selecet at least one available day(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkMonday.Focus();
                return;//fixed, i think 
            }


            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }


            if (txtHourlyRate.Text.Equals(""))
            {
                MessageBox.Show("Hourly Rate must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHourlyRate.Focus();
                return;
            }

            

            //save data - 2nd semester

            Sitters sitter = new Sitters(Convert.ToInt32(txtSitterID.Text), txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNo.Text, dtpDOB.Value, txtCounty.Text, txtTown.Text, txtStreet.Text, txtEirCode.Text, cboLanguage.Text, cboChildCareCertified.Text, cboMedicalCertified.Text, chkMonday.Text, chkTuesday.Text, chkWednesday.Text, chkThursday.Text, chkFriday.Text, chkSaturday.Text, chkSunday.Text, txtDescription.Text, txtHourlyRate.Text);

            sitter.AddSitter();

            //display confirmation message
            MessageBox.Show("Sitter " + txtSitterID.Text + " has been registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            //txtSitterID.Text = firstSitterID.GetNextSitterID().ToString("0000");
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();
            dtpDOB.Value = new DateTime(2006, 12, 31);
            txtCounty.Clear();
            txtTown.Clear();
            txtStreet.Clear();
            txtEirCode.Clear();
            cboChildCareCertified.SelectedIndex = -1;
            cboMedicalCertified.SelectedIndex = -1;
            cboLanguage.SelectedIndex = -1;
            txtDescription.Clear();
            txtHourlyRate.Clear();
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;
            chkSunday.Checked = false;

            
            txtSitterID.Text = Sitters.GetNextSitterID().ToString();

            txtFirstName.Focus();
        }

        
    }
}
