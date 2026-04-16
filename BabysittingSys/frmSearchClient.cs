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
    public partial class frmSearchClient : Form
    {
        public frmSearchClient()
        {
            InitializeComponent();
        }

        private void frmSearchClient_Load(object sender, EventArgs e)
        {
            dgvSearchClient.ReadOnly = true;
            dgvSearchClient.AllowUserToDeleteRows = false;
            dgvSearchClient.AllowUserToAddRows = false;
            dgvSearchClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            if (ds.Tables["Client_By_ID"].Rows.Count == 0)
            {
                MessageBox.Show("No Client found with that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientID.Focus();
                return;
            }

            dgvSearchClient.DataSource = ds.Tables["Client_By_ID"];

            Convert.ToInt32(txtClientID.Text);

            if (!txtClientID.Text.All(char.IsDigit)) 
            { 
                MessageBox.Show("Client ID must be numeric", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtClientID.Focus();
                return;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClientID.Clear();
            dgvSearchClient.DataSource = null;
            dgvSearchClient.Rows.Clear();
            dgvSearchClient.Refresh();

            txtClientID.Focus();
        }
    }
}
