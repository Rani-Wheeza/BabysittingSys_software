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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
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

        private void mnuRegisterClient_Click(object sender, EventArgs e)
        {
            frmRegisterClient nextForm = new frmRegisterClient(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuUpdateClient_Click(object sender, EventArgs e)
        {
            frmUpdateClient nextForm = new frmUpdateClient(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRemoveClient_Click(object sender, EventArgs e)
        {
            frmRemoveClient nextForm = new frmRemoveClient(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuRegisterSitter_Click(object sender, EventArgs e)
        {
            frmRegisterSitter nextForm = new frmRegisterSitter(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuUpdateSitter_Click(object sender, EventArgs e)
        {
            frmUpdateSitter nextForm = new frmUpdateSitter(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRemoveSitter_Click(object sender, EventArgs e)
        {
            frmRemoveSitter nextForm = new frmRemoveSitter(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuMakeBooking_Click(object sender, EventArgs e)
        {
            frmMakeBooking nextForm = new frmMakeBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateBooking_Click(object sender, EventArgs e)
        {
            frmUpdateBooking nextForm = new frmUpdateBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuCancelBooking_Click(object sender, EventArgs e)
        {
            frmCancelBooking nextForm = new frmCancelBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuGenerateYearBookingAnalysis_Click(object sender, EventArgs e)
        {
            frmGenerateYearlyBookingAnalysis nextForm = new frmGenerateYearlyBookingAnalysis(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuGenerateYearlySitterAnalysis_Click(object sender, EventArgs e)
        {
            frmGenerateYearlySitterAnalysis nextForm = new frmGenerateYearlySitterAnalysis(this);
            this.Hide();
            nextForm.Show();
        }  



    }
}
