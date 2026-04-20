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
        public frmListSitters()
        {
            InitializeComponent();
        }

        public static void formatGrid(DataGridView dg)

        {

           /* dg.Columns["ID"].Width = 30;

            dg.Columns["ID"].DefaultCellStyle.Format = "000";

            dg.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dg.Columns["Quantity"].Width = 70;

            dg.Columns["Quantity"].DefaultCellStyle.Format = "000";

            dg.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dg.Columns["Price"].Width = 60;

            dg.Columns["Price"].DefaultCellStyle.Format = "N2";

            dg.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;*/

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
