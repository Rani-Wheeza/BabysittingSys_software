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
    public partial class frmRemoveClient : Form
    {
        frmHome Parent;
        public frmRemoveClient()
        {
            InitializeComponent();
        }

        public frmRemoveClient(frmHome parent)
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
            frmRegisterClient nextForm = new frmRegisterClient(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateClient_Click(object sender, EventArgs e)
        {
            frmUpdateClient nextForm = new frmUpdateClient(this.Parent);
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
            frmUpdateBooking nextForm = new frmUpdateBooking(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuCancelBooking_Click(object sender, EventArgs e)
        {
            frmCancelBooking nextForm = new frmCancelBooking(this.Parent);
            this.Hide();
            nextForm.Show();
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
        }

        private void frmRemoveClient_Load(object sender, EventArgs e)
        {
            /*cboClientID.Items.Add("1013");
            cboClientID.Items.Add("1024");
            cboClientID.Items.Add("1015");*/
        }

        /*private void cboClientID_SelectedIndexChanged(object sender, EventArgs e)
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
        }*/

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtClientID.Text.Equals(""))
            {
                MessageBox.Show("Client ID must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientID.Focus();
                return;
            }

            DataSet ds = Clients.GetClientByID(Convert.ToInt32(txtClientID.Text));

            if (ds.Tables["Client_By_ID"].Rows.Count == 0)
            {
                MessageBox.Show("No Client found with that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientID.Focus();
                return;
            }

            DataRow dr = ds.Tables["Client_By_ID"].Rows[0];

            txtFirstName.Text = dr["FirstName"].ToString();
            txtLastName.Text = dr["LastName"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            txtPhoneNo.Text = dr["PhoneNo"].ToString();
            txtCounty.Text = dr["County"].ToString();
            txtTown.Text = dr["Town"].ToString();
            txtStreet.Text = dr["Street"].ToString();
            txtEirCode.Text = dr["EirCode"].ToString();
            cboNoOfChildren.Text = dr["NoOfChildren"].ToString();
            cboAgeOfChild.Text = dr["AgeOfChild"].ToString();
            cboLanguage.Text = dr["Languages"].ToString();
            txtDescription.Text = dr["Description"].ToString();

        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            
            //save data - 2nd semester
            if (txtClientID.Text.Equals(""))
            {
                MessageBox.Show("Client ID must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientID.Focus();
                return;
            }

            //Cormation message
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete client details", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.No) 
            { 
                return;
            }

            Clients client = new Clients();
            client.ClientID = Convert.ToInt32(txtClientID.Text);

            client.DeleteClient();

            MessageBox.Show("Client deleted sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Reset UI
            txtClientID.Clear();
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

            txtClientID.Focus();

            grpRemoveClient.Visible = false;
        }

       
    }
}
