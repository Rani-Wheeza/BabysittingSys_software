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
    public partial class frmListSitters : Form
    {
        frmAdminDashBoard parentForm;

        public frmListSitters()
        {
            InitializeComponent();
        }

        public frmListSitters(frmAdminDashBoard parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
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

        public static void formatGrid(DataGridView dg)

        {

            dg.Columns["ID"].Width = 30;

            dg.Columns["ID"].DefaultCellStyle.Format = "000";

            dg.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dg.Columns["Quantity"].Width = 70;

            dg.Columns["Quantity"].DefaultCellStyle.Format = "000";

            dg.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dg.Columns["Price"].Width = 60;

            dg.Columns["Price"].DefaultCellStyle.Format = "N2";

            dg.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void frmListSitters_Load(object sender, EventArgs e)
        {
            dgvDisplaySitters.ReadOnly = true;
            dgvDisplaySitters.AllowUserToAddRows = false;
            dgvDisplaySitters.AllowUserToDeleteRows = false;
            dgvDisplaySitters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDisplaySitters_Click(object sender, EventArgs e)
        {
            DataSet ds = Sitters.GetAllSitters();
            dgvDisplaySitters.DataSource = ds.Tables["All_Sitters"];
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvDisplaySitters.DataSource = null;
        }

       
    }
}
