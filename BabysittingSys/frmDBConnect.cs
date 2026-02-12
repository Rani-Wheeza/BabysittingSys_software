using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BabysittingSys
{
    public partial class frmDBConnect : Form
    {
        //Creating an object to connect to an Oracle DB using an Oracle DB connection string (defined in the class DBConnect)
        OracleConnection conn = new OracleConnection(DataBase.connectionString);

        public frmDBConnect()
        {
            InitializeComponent();
        }

        private void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open) 
            { 
                conn.Close();
                lbClosed.Text = "CLOSED";
                lbClosed.ForeColor = Color.Red;
                Application.Exit();
            }

            else
            {
                conn.Open();
                lbClosed.Text = "OPEN";
                lbClosed.ForeColor = Color.Green;
            }

        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
        }

        /*private void frmDBConnect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Console.WriteLine("The was closed");
        }*///this was not nesscary

       
    }
}
