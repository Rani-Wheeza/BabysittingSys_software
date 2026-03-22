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
        private int SitterID;
        private string FirstName;
        private string LastName;
        private string Email;
        private string PhoneNo;
        private DateTime DOB;
        private string County;
        private string Town;
        private string Street;
        private string EirCode;
        private string Language;
        private string ChildCareCertified;
        private string MedicalCertified;
        private string Monday;
        private string Tuesday;
        private string Wednesday;
        private string Thursday;
        private string Friday;
        private string Saturday;
        private string Sunday;
        private string Description;
        private string HourlyRate;

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
            Monday = "";
            Tuesday = "";
            Wednesday = "";
            Thursday = "";
            Friday = "";
            Saturday = "";
            Sunday = "";
            Description = "";
            HourlyRate = "";
        
        }

        public Sitters(int sitterID,string firstName, string lastName, string email, string phoneNo, DateTime dob, string county, string town, string street, string eirCode, string language, string childCareCertified, string medicalCertified, string monday, string tuesday, string wednesday, string thursday, string friday, string saturday, string sunday, string description, string hourlyRate)
        {
            setSitterID(sitterID);
            setFirstName(firstName);
            setLastName(lastName);
            setEmail(email);
            setPhoneNo(phoneNo);
            setDOB(dob);
            setCounty(county);
            setTown(town);
            setStreet(street);
            setEirCode(eirCode);
            setLanguage(language);
            setChildCareCertified(childCareCertified);
            setMedicalCertified(medicalCertified);
            setMonday(monday);
            setTuesday(tuesday);
            setWednesday(wednesday);
            setThursday(thursday);
            setFriday(friday);
            setSaturday(saturday);
            setSunday(sunday);
            setDescription(description);
            setHourlyRate(hourlyRate);


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
        public string getMonday() { return Monday; }
        public string getTuesday() { return Tuesday; }
        public string getWednesday() { return Wednesday; }
        public string getThursday() { return Thursday; }
        public string getFriday() { return Friday; }
        public string getSaturday() { return Saturday; }
        public string getSunday() { return Sunday; }
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
        public void setMedicalCertified(string medicalCertified) { MedicalCertified = medicalCertified; }
        public void setMonday(string monday) { Monday = monday; }
        public void setTuesday(string tuesday) { Tuesday = tuesday; }
        public void setWednesday(string wednesday) { Wednesday = wednesday; }
        public void setThursday(string thursday) { Thursday = thursday; }
        public void setFriday(string friday) { Friday = friday; }
        public void setSaturday(string saturday) { Saturday = saturday; }
        public void setSunday(string sunday) { Sunday = sunday; }
        public void setDescription(string description) { Description = description; }
        public void setHourlyRate(string hourlyRate) { HourlyRate = hourlyRate; }

        public static DataSet getSitters()
        {
            DataSet ds = new DataSet();

            //to open the db connection
            OracleConnection conn = new OracleConnection(DataBase.connectionString);

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
            int nextID = 0;

            //to open the db connection
            //string orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            string strSQL = "SELECT MAX(SitterID) FROM Slitter";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                nextID = Convert.ToInt32(result) + 1;
            }
            else
            {
                nextID = 1005; // Start from 1 if there are no sitters in the database
            }
            conn.Close();

            return nextID;
        }



        public void AddSitter()
        {
            //to open the db connection
            //string orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";


            string strSQL = "INSERT INTO SITTERS VALUES (" + this.SitterID + ",'" + this.FirstName + "','" + this.LastName + "','" + this.Email + "','" + this.PhoneNo + "','" + this.DOB + "','" + this.County + "','" + this.Town + "','" + this.Street + "','" + this.EirCode + "','" + this.ChildCareCertified + "','" + this.MedicalCertified + "','" + this.Language + "','" + this.Monday + "','" + this.Tuesday + "','" + this.Wednesday + "','" + this.Thursday + "','" + this.Friday + "','" + this.Saturday + "','" + this.Sunday + "','" + this.Description + "','" + this.HourlyRate + "')";

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public static DataSet GetSitterByID(int sitterID)
        {
            DataSet ds = new DataSet();

            //to open the db connection
            //String orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";// is redundant

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            String strSQL = "SELECT * FROM Sitter WHERE SitterID = " + sitterID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Sitter_by_ID");

            conn.Close();

            return ds;

        }

    }
}
