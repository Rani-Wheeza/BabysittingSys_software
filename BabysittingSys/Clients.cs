using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabysittingSys
{
    /*internal class Clients
    {
    }*/

    public class Clients
    {
        public int ClientID;
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNo;
        public string County;
        public string Town;
        public string Street;
        public string EirCode;
        public string NoOfChildren;
        public string AgeOfChild;
        public string Language;
        public string Description;

        public Clients()
        {
            this.ClientID = 0;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.PhoneNo = "";
            this.County = "";
            this.Town = "";
            this.Street = "";
            this.EirCode = "";
            this.NoOfChildren = "";
            this.AgeOfChild = "";
            this.Language = "en-US";
            this.Description = "";

        }

        public Clients(int clientID, string firstName, string lastName, string email, string phoneNo, string county, string town, string street, string eirCode, string noOfChildren, string ageOfChild, string language, string description)
        {
            ClientID = clientID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNo = phoneNo;
            County = county;
            Town = town;
            Street = street;
            EirCode = eirCode;
            NoOfChildren = noOfChildren;
            AgeOfChild = ageOfChild;
            Language = language;
            Description = description;
        }

        //GETTERS
        public int getClientID() { return ClientID; }
        public string getFirstName() { return FirstName; }
        public string getLastName() { return LastName; }
        public string getEmail() { return Email; }
        public string getPhoneNo() { return PhoneNo; }
        public string getCounty() { return County; }
        public string getTown() { return Town; }
        public string getStreet() { return Street; }
        public string getEirCode() { return EirCode; }
        public string getNoOfChildren() { return NoOfChildren; }
        public string getAgeOfChild() { return AgeOfChild; }
        public string getLanguage() { return Language; }
        public string getDescription() { return Description; }

        //SETTERS
        public void setClientID(int clientID) { ClientID = clientID; }
        public void setFirstName(string firstName) { FirstName = firstName; }
        public void setLastName(string lastName) { LastName = lastName; }
        public void setEmail(string email) { Email = email; }
        public void setPhoneNo(string phoneNo) { PhoneNo = phoneNo; }
        public void setCounty(string county) { County = county; }
        public void setTown(string town) { Town = town; }
        public void setStreet(string street) { Street = street; }
        public void setEirCode(string eirCode) { EirCode = eirCode; }
        public void setNoOfChildren(string noOfChildren) { NoOfChildren = noOfChildren; }
        public void setAgeOfChildren(string ageOfChildren) { AgeOfChild = ageOfChildren; }
        public void setLanguage(string language) { Language = language; }
        public void setDescription(string description) { Description = description; }


        public static DataSet getClientID(int clientID)
        {
            DataSet ds = new DataSet();

            //to open the db connection
            string orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";

            OracleConnection conn = new OracleConnection(orabd);

            conn.Open();

            string strSQL = "SELECT * FROM Client ORDER BY ClientID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Client");

            conn.Close();

            return ds;

        }

        

        public bool addClient()
        {
            //to open the db connection
            string orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";


            string strSQL = "INSERT INTO CLIENTS (ClientID,FirstName, LastName, Email, PhoneNo, County, Town, Street, EirCode, NoOfChildren, AgeOfChild, Language, Description) " +
                "VALUES (:ClientID, :FirstName, :LastName, :Email, :PhoneNo, :County, :Town, :Street, :EirCode, :NoOfChildren, :AgeOfChild, :Language, :Description)";

            try
            {
                using (OracleConnection conn = new OracleConnection(orabd))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(strSQL, conn))
                    {
                        cmd.Parameters.Add(":ClientID", OracleDbType.Int32).Value = ClientID;
                        cmd.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = FirstName;
                        cmd.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = LastName;
                        cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = Email;
                        cmd.Parameters.Add(":PhoneNo", OracleDbType.Varchar2).Value = PhoneNo;
                        cmd.Parameters.Add(":County", OracleDbType.Varchar2).Value = County;
                        cmd.Parameters.Add(":Town", OracleDbType.Varchar2).Value = Town;
                        cmd.Parameters.Add(":Street", OracleDbType.Varchar2).Value = Street;
                        cmd.Parameters.Add(":EirCode", OracleDbType.Varchar2).Value = EirCode;
                        cmd.Parameters.Add(":NoOfChildren", OracleDbType.Varchar2).Value = NoOfChildren;
                        cmd.Parameters.Add(":AgeOfChildren", OracleDbType.Varchar2).Value = AgeOfChild;
                        cmd.Parameters.Add(":Language", OracleDbType.Varchar2).Value = Language;
                        cmd.Parameters.Add(":Description", OracleDbType.Varchar2).Value = Description;
                        //cmd.Parameters.Add(new OracleParameter("Description", client.Description));

                        int rowsInserted = cmd.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            return true;
                            //Console.WriteLine("Client added successfully.");
                        }
                        else
                        {
                            return false;
                            //Console.WriteLine("Failed to add client.");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding client: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
