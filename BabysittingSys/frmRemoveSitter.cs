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
    public partial class frmRemoveSitter : Form
    {
        frmHome Parent;
        public frmRemoveSitter()
        {
            InitializeComponent();
        }

        public frmRemoveSitter(frmHome parent)
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

        private void mnuRegisterSitter_Click(object sender, EventArgs e)
        {
            frmRegisterSitter nextForm = new frmRegisterSitter(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateSitter_Click(object sender, EventArgs e)
        {
            frmUpdateSitter nextForm = new frmUpdateSitter(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
        }


        private void cboSitterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSitterID.Text == "2003")
            {
                txtFirstName.Text = "Sarah";
                txtLastName.Text = "O'Grady";
                txtEmail.Text = "sarah2@gmail.com";
                txtPhoneNo.Text = "0848261852";
                dtpDOB.Value = new DateTime(2004, 4, 21);
                txtCounty.Text = "Dublin";
                txtTown.Text = "Swords";
                txtStreet.Text = "14 Oakview Drive";
                txtEirCode.Text = "K67 A9F2";
                cboLanguage.SelectedIndex = 2;
                cboChildCareCertified.SelectedIndex = 0;
                cboMedicalCertified.SelectedIndex = 0;
                chkMonday.Checked = true;
                chkTuesday.Checked = false;
                chkWednesday.Checked = false;
                chkThursday.Checked = false;
                chkFriday.Checked = false;
                chkSaturday.Checked = true;
                chkSunday.Checked = true;
                txtDescription.Text = "Friendly and responsible sitter with 3+ years of experience caring for " +
                    "children of all ages. I love crafts, outdoor play, and keeping kids engaged.";
                txtHourlyRate.Text = "13.50";
            }

            else if (cboSitterID.Text == "2004")
            {
                txtFirstName.Text = "Aoife";
                txtLastName.Text = "Murphy";
                txtEmail.Text = "murphy.a@gmail.com";
                txtPhoneNo.Text = "0850379963";
                dtpDOB.Value = new DateTime(2006, 6, 23);
                txtCounty.Text = "Cork";
                txtTown.Text = "Midleton";
                txtStreet.Text = "22 Riverside Walk";
                txtEirCode.Text = "P25 D3K4";
                cboLanguage.SelectedIndex = 4;
                cboChildCareCertified.SelectedIndex = 0;
                cboMedicalCertified.SelectedIndex = 1;
                chkMonday.Checked = false;
                chkTuesday.Checked = true;
                chkWednesday.Checked = true;
                chkThursday.Checked = true;
                chkFriday.Checked = false;
                chkSaturday.Checked = true;
                chkSunday.Checked = false;
                txtDescription.Text = "Qualified childcare worker with first-aid training, available for evening and " +
                    "weekend babysitting. I’m patient, reliable, and great with routines.";
                txtHourlyRate.Text = "15.00";
            }

            else if (cboSitterID.Text == "2005")
            {
                txtFirstName.Text = "Ciara";
                txtLastName.Text = "Donnelly";
                txtEmail.Text = "ciaradonnelly@gmail.com";
                txtPhoneNo.Text = "0827386277";
                dtpDOB.Value = new DateTime(2000, 2, 27);
                txtCounty.Text = "Galway";
                txtTown.Text = "Oranmore";
                txtStreet.Text = "8 Castle Road";
                txtEirCode.Text = "H91 T2W7";
                cboLanguage.SelectedIndex = 9;
                cboChildCareCertified.SelectedIndex = 0;
                cboMedicalCertified.SelectedIndex = 0;
                chkMonday.Checked = true;
                chkTuesday.Checked = true;
                chkWednesday.Checked = true;
                chkThursday.Checked = true;
                chkFriday.Checked = true;
                chkSaturday.Checked = false;
                chkSunday.Checked = false;
                txtDescription.Text = "Energetic college student studying early childhood education. I enjoy " +
                    "helping with homework, light meals, and fun activities.";
                txtHourlyRate.Text = "14.80";
            }
        }

        private void frmRemoveSitter_Load(object sender, EventArgs e)
        {
            cboSitterID.Items.Add("2003");
            cboSitterID.Items.Add("2004");
            cboSitterID.Items.Add("2005");
        }

        private void btnRemoveSitter_Click(object sender, EventArgs e)
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

            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("Phone Number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }

            if (dtpDOB.MaxDate.Equals(""))
            {
                MessageBox.Show("County must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }

            if (txtCounty.Text.Equals(""))
            {
                MessageBox.Show("A Date must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (txtEirCode.Text.Equals(""))
            {
                MessageBox.Show("EirCode must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEirCode.Focus();
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

            if (txtHourlyRate.Text.Equals(""))
            {
                MessageBox.Show("Hourly Rate must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHourlyRate.Focus();
                return;
            }

            //atleast one has to be selceted to move on with saving the data.
            if (!chkMonday.Checked && !chkTuesday.Checked && !chkWednesday.Checked && !chkThursday.Checked && !chkFriday.Checked && !chkSaturday.Checked && !chkSunday.Checked)
            {
                MessageBox.Show("Selecet at least one available day(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkMonday.Focus();
                return;//fixed, i think 
            }

            //save data - 2nd semester


            //Cormation message
            MessageBox.Show("Are you sure you want to delete sitter details", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //Reset UI
            grpRemoveSitter.Visible = false;

        }

    }
}
