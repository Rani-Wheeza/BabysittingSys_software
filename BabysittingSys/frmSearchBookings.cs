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
        frmAdminDashBoard Parent;

        public frmSearchBookings()
        {
            InitializeComponent();
        }

        public frmSearchBookings(frmAdminDashBoard parent)
        {
            InitializeComponent();
            this.Parent = parent;   
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
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

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
        }

        private void mnuClientList_Click(object sender, EventArgs e)
        {
            frmLIstClients nextForm = new frmLIstClients();
            this.Hide();
            nextForm.Show();
        }

        private void mnuSearchClient_Click(object sender, EventArgs e)
        {
            frmSearchClient nextForm = new frmSearchClient();
            this.Hide();
            nextForm.Show();
        }

        private void mnuSitterList_Click(object sender, EventArgs e)
        {
            frmListSitters nextForm = new frmListSitters();
            this.Hide();
            nextForm.Show();
        }

        private void mnuSearchSitter_Click(object sender, EventArgs e)
        {
            frmSearchSitters nextForm = new frmSearchSitters();
            this.Hide();
            nextForm.Show();
        }

        private void mnuBookingList_Click(object sender, EventArgs e)
        {
            frmListBookings nextForm = new frmListBookings();
            this.Hide();
            nextForm.Show();
        }

        private void mnuSearchBooking_Click(object sender, EventArgs e)
        {
            frmSearchBookings nextForm = new frmSearchBookings();
            this.Hide();
            nextForm.Show();
        }

        private void generateYearlySitterAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerateYearlySitterAnalysis nextForm = new frmGenerateYearlySitterAnalysis();
            this.Hide();
            nextForm.Show();
        }

        private void mnugenerateYearlyBookingAnalysis_Click(object sender, EventArgs e)
        {
            frmGenerateYearlyBookingAnalysis nextForm = new frmGenerateYearlyBookingAnalysis();
            this.Hide();
            nextForm.Show();
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
