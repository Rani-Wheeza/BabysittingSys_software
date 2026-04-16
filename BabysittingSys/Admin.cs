using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysittingSys
{
    public class Admin
    {
        private int AdminID;
        private string Email;
        private string Password;

        public Admin()
        {
            AdminID = 0;
            Email = "";
            Password = "";
        }

        public Admin(int adminID, string email, string password)
        {
            setAdminID(adminID);
            setEmail(email);
            setPassword(password);
            
        }

        //Getters
        public int getAdminID() { return AdminID; }
        public string getEmail() { return Email; }
        public string getPassword() { return Password; }

        //Setters
        public void setAdminID(int adminID) { this.AdminID = adminID; }
        public void setEmail(string email) { this.Email = email; }
        public void setPassword(string password) { this.Password = password; }

        public static DataSet CheckAdminLogin(int adminID, string email, string password) 
        { 
            DataSet ds = new DataSet();

            OracleConnection conn = new OracleConnection(DataBase.connectionString);
            conn.Open();

            string strSQL = "SELECT * FROM ADMIN WHERE AdminID = " + adminID + "Email = '" + email + "Password = '" + password + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Admin_Login");

            conn.Close();
            return ds;
        }//Don't forget to make an Admin table
    }
}
