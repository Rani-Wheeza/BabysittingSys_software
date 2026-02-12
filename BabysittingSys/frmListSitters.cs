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

    }
}
