using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BabysittingSys
{
    /*internal class Sitters
    {
    }*/

    public class Sitters
    {
        public int SitterID;
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNo;
        public DateTime DOB;
        public string County;
        public string Town;
        public string Street;
        public string EirCode;
        public string Language;
        public string ChildCareCertified;
        public string MedicalCertified;
        public string Availabilty;
        public string Description;
        public string HourlyRate;

        public Sitters() 
        { 
            SitterID = 0;
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNo = "";
            DOB = DateTime.Now;
            County = "";
            Town = "";
            Street = "";
            EirCode = "";
            Language = "";
            ChildCareCertified = "";
            MedicalCertified = "";
            Availabilty = "";
            Description = "";
            HourlyRate = "";
        
        }

        public Sitters(int sitterID,string firstName, string lastName, string email, string phoneNo, DateTime dob, string county, string town, string street, string eirCode, string language, string childCareCertified, string medicalCertified, string availabilty, string description, string hourlyRate)
        {
            SitterID = sitterID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNo = phoneNo;
            DOB = dob;
            County = county;
            Town = town;
            Street = street;
            EirCode = eirCode;
            Language = language;
            ChildCareCertified = childCareCertified;
            MedicalCertified = medicalCertified;
            Description = description;
            HourlyRate = hourlyRate;


        }

        //GETTERS
        public int getSitterID() { return SitterID; }
        public string getFirstName() { return FirstName;} 
        public string getLastName() { return LastName;}
        public string getEmail() { return Email;}
        public string getPhoneNo() { return PhoneNo;}
        public DateTime getDOB() { return DOB; }
        public string getCounty() { return County;}
        public string getTown() { return Town;}
        public string getStreet() { return Street;}
        public string getEirCode() { return EirCode;}
        public string getLanguage() { return Language;}
        public string getChildCareCertified() { return ChildCareCertified;}
        public string getMedicalCertified() {return MedicalCertified;}
        public string getDescription() { return Description;}
        public string getHourlyRate() { return HourlyRate;}

        //SETTERS
        public void setSitterID(int sitterID) { SitterID = sitterID; }
        public void setFirstName(string firstName) { FirstName = firstName; }
        public void setLastName(string lastName) { LastName = lastName; }
        public void setEmail(string email) { Email = email; }
        public void setPhoneNo(string phoneNo) { PhoneNo = phoneNo; }
        public void setDOB(DateTime dob) { DOB = dob; }
        public void setCounty(string county) { County = county; }
        public void setTown(string town) { Town = town; }
        public void setStreet(string street) { Street = street; }
        public void setEirCode(string eirCode) { EirCode = eirCode; }
        public void setLanguage(string language) { Language = language; }
        public void setChildCareCertified(string childCareCertified) { ChildCareCertified = childCareCertified; }
        public void setMedicalCertified(string micalCertified) { MedicalCertified = micalCertified; }
        public void setDescription(string description) { Description = description; }
        public void setHourlyRate(string hourlyRate) { HourlyRate = hourlyRate; }

        public static DataSet getSitterID(int sitterID)
        {
            DataSet ds = new DataSet();

            //to open the db connection
            OracleConnection conn = new OracleConnection(/*connectionString*/);

            conn.Open();

            string strSQL = "SELECT * FROM Sitter ORDER BY SitterID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Sitter");

            conn.Close();

            return ds;

        }

        public static int GetNextSitterID()

        {


            //Define the SQL query to be executed - only one value returned here

            string sqlQuery = "SELECT MAX(SitterID) FROM Sitters";


            //Execute the SQL query

            //OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery); // not sure what to change check later


            //Does data reader contain a value or is it null?

            int nextId;


            dr.Read();


            if (dr.IsDBNull(0)) //the data reader is empty so no rows have yet been added to the table

                nextId = 1;

            else

                nextId = dr.GetInt32(0) + 1;


            //close the OracleDataReader and the DB connection

            dr.Close();


            return nextId;

        }

    }
}
