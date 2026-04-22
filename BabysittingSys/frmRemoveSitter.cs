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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSitterID.Text.Equals(""))
            {
                MessageBox.Show("Sitter ID must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSitterID.Focus();
                return;
            }

            DataSet ds = Sitters.GetSitterByID(Convert.ToInt32(txtSitterID.Text));

            if (ds.Tables["Sitter_By_ID"].Rows.Count == 0)
            {
                MessageBox.Show("No Sitter found with that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSitterID.Focus();
                return;
            }

            DataRow dr = ds.Tables["Sitter_By_ID"].Rows[0];

            txtFirstName.Text = dr["FirstName"].ToString();
            txtLastName.Text = dr["LastName"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            txtPhoneNo.Text = dr["PhoneNo"].ToString();
            dtpDOB.Text = dr["DOB"].ToString();
            txtCounty.Text = dr["County"].ToString();
            txtTown.Text = dr["Town"].ToString();
            txtStreet.Text = dr["Street"].ToString();
            txtEirCode.Text = dr["EirCode"].ToString();
            cboLanguage.Text = dr["Language"].ToString();
            cboChildCareCertified.Text = dr["ChildCareCertified"].ToString();
            cboMedicalCertified.Text = dr["MedicalCertified"].ToString();
            txtDescription.Text = dr["Description"].ToString();
            txtHourlyRate.Text = dr["HourlyRate"].ToString();

            chkMonday.Checked = dr["Monday"].ToString() == "Yes";
            chkTuesday.Checked = dr["Tuesday"].ToString() == "Yes";
            chkWednesday.Checked = dr["Wednesday"].ToString() == "Yes";
            chkThursday.Checked = dr["Thursday"].ToString() == "Yes";
            chkFriday.Checked = dr["Friday"].ToString() == "Yes";
            chkSaturday.Checked = dr["Saturday"].ToString() == "Yes";
            chkSunday.Checked = dr["Sunday"].ToString() == "Yes";
        }
                

        private void frmRemoveSitter_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRemoveSitter_Click(object sender, EventArgs e)
        {
            if (txtSitterID.Text.Equals(""))
            {
                MessageBox.Show("Sitter ID must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSitterID.Focus();
                return;
            }

            //save data - 2nd semester


            //Cormation message
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete sitter details", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.No) 
            {
                return;
            
            }

            Sitters sitters = new Sitters();
            sitters.setSitterID(Convert.ToInt32(txtSitterID.Text));

            sitters.DeleteSitter();

            MessageBox.Show("Sitter deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtSitterID.Clear();
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

            txtSitterID.Focus();

            //Reset UI
            grpRemoveSitter.Visible = false;

        }

        
    }
}
