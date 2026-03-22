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
        private int ClientID;
        private string FirstName;
        private string LastName;
        private string Email;
        private string PhoneNo;
        private string County;
        private string Town;
        private string Street;
        private string EirCode;
        private string NoOfChildren;
        private string AgeOfChild;
        private string Language;
        private string Description; //switched from public to private

        public Clients()
        {
            ClientID = 0;
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNo = "";
            County = "";
            Town = "";
            Street = "";
            EirCode = "";
            NoOfChildren = "";
            AgeOfChild = "";
            Language = "en-US";
            Description = ""; //this. was redundant

        }

        public Clients(int clientID, string firstName, string lastName, string email, string phoneNo, string county, string town, string street, string eirCode, string noOfChildren, string ageOfChild, string language, string description)
        {
            setClientID(clientID);
            setFirstName(firstName);
            setLastName(lastName);
            setEmail(email);
            setPhoneNo(phoneNo);
            setCounty(county);
            setTown(town);
            setStreet(street);
            setEirCode(eirCode);
            setNoOfChildren(noOfChildren);
            setAgeOfChildren(ageOfChild);
            setLanguage(language);
            setDescription(description); // refrenced stters
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


        public static DataSet getClients()
        {
            DataSet ds = new DataSet();

            //to open the db connection
            //String orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";// is redundant

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            String strSQL = "SELECT * FROM Client ORDER BY ClientID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Client");

            conn.Close();

            return ds;

        }



        public void AddClient()
        {
            //to open the db connection
            //string orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";


            string strSQL = "INSERT INTO CLIENTS VALUES (" + this.ClientID + ",'" + this.FirstName + "','" + this.LastName + "','" + this.Email + "','" + this.PhoneNo + "','" + this.County + "','" + this.Town + "','" + this.Street + "','" + this.EirCode + "','" + this.NoOfChildren + "','" + this.AgeOfChild + "','" + this.Language + "','" + this.Description + "')";

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close() ;

            /* try
             {
                 using (OracleConnection conn = new OracleConnection(DataBase.connectionString))
                 {
                     conn.Open();,

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
                 return false;
             }*/
        }

        public static Clients GetClientByID(int clientID)
        {
            Clients client = null;
                        
            string orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";

           
            using (OracleConnection conn = new OracleConnection(orabd))
            {
                conn.Open();

                string strSQL = "SELECT * FROM CLIENTS WHERE ClientID = :ClientID";

                using (OracleCommand cmd = new OracleCommand(strSQL, conn))
                {
                    cmd.Parameters.Add(":ClientID", OracleDbType.Int32).Value = clientID;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            client = new Clients();

                            client.ClientID = reader.GetInt32(0);
                            client.FirstName = reader.GetString(1);
                            client.LastName = reader.GetString(2);
                            client.Email = reader.GetString(3);
                            client.PhoneNo = reader.GetString(4);
                            client.County = reader.GetString(5);
                            client.Town = reader.GetString(6);
                            client.Street = reader.GetString(7);
                            client.EirCode = reader.GetString(8);
                            client.NoOfChildren = reader.GetString(9);
                            client.AgeOfChild = reader.GetString(10);
                            client.Language = reader.GetString(11);
                            client.Description = reader.GetString(12);
                            //Description = reader.GetString(reader.GetOrdinal("Description"))
                            
                        }
                    }
                }

            }
            return client;


        }
    }
}
