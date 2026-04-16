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
    public partial class frmSearchSitters : Form
    {
        public frmSearchSitters()
        {
            InitializeComponent();
        }

        private void frmSearchSitters_Load(object sender, EventArgs e)
        {
            dgvSearchSitter.ReadOnly = true;
            dgvSearchSitter.AllowUserToDeleteRows = false;
            dgvSearchSitter.AllowUserToAddRows = false;
            dgvSearchSitter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            dgvSearchSitter.DataSource = ds.Tables["Sitter_By_ID"];

            Convert.ToInt32(txtSitterID.Text);

            if (!txtSitterID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Sitter ID must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSitterID.Focus();
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSitterID.Clear();
            dgvSearchSitter.DataSource = null;
            dgvSearchSitter.Rows.Clear();
            dgvSearchSitter.Refresh();

            txtSitterID.Focus();
        }
    }
}
