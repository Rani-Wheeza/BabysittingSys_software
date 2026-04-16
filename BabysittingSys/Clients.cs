using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabysittingSys
{
   
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
        public string Description; //switched from public to private
        //changed back to public because i was getting errors

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

            String strSQL = "SELECT * FROM Clients ORDER BY ClientID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Client");

            conn.Close();

            return ds;

        }

        public static int GetNextClientID()
        {
            int nextID = 0;

            //to open the db connection
            //string orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            string strSQL = "SELECT MAX(ClientID) FROM Clients";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                nextID = Convert.ToInt32(result) + 1;
            }
            else
            {
                nextID = 1005; // Start from 1 if there are no clients in the database
            }
            conn.Close();

            return nextID;
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

           
        }

        public static DataSet GetClientByID(int clientID)
        {
            DataSet ds = new DataSet();

            //to open the db connection
            //String orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";// is redundant

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            String strSQL = "SELECT * FROM Clients WHERE ClientID = " + clientID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Client_by_ID");

            conn.Close();

            return ds;

        }

        public void UpdateClient()
        {
            string strSQL = "UPDATE CLIENTS SET " + "FirstName = '" + this.FirstName + "'," + "LastName = '" + this.LastName + "'," + "Email = '" + this.Email + "'," + "PhoneNo = '" + this.PhoneNo + "'," + "County = '" + this.County + "'," + "Town = '" + this.Town + "'," + "Street = '" + this.Street + "'," + "EirCode = '" + this.EirCode + "'," + "NoOfChildren = '" + this.NoOfChildren + "'," + "AgeOfChild = '" + this.AgeOfChild + "'," + "Language = '" + this.Language + "'," + "Description = '" + this.Description + "' " + "WHERE ClientID = " + this.ClientID;

            OracleConnection conn = new OracleConnection(DataBase.connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
