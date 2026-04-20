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
    public partial class frmLIstClients : Form
    {
        public frmLIstClients()
        {
            InitializeComponent();
        }

        private void frmLIstClients_Load(object sender, EventArgs e)
        {
            dgvDisplayClients.ReadOnly = true;
            dgvDisplayClients.AllowUserToAddRows = false;
            dgvDisplayClients.AllowUserToDeleteRows = false;
            dgvDisplayClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDisplayClients_Click(object sender, EventArgs e)
        {
            DataSet ds = Clients.GetAllClients();
            dgvDisplayClients.DataSource = ds.Tables["Clients"];

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvDisplayClients.DataSource = null;
        }

        
    }
}
