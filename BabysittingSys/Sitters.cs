using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BabysittingSys
{
   
    public class Sitters
    {
        private int AvailabilityID;
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
            AvailabilityID = 0;
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

        public Sitters(int AvailabilityID,int sitterID,string firstName, string lastName, string email, string phoneNo, DateTime dob, string county, string town, string street, string eirCode, string language, string childCareCertified, string medicalCertified, string monday, string tuesday, string wednesday, string thursday, string friday, string saturday, string sunday, string description, string hourlyRate)
        {
            setAvailabilityID(AvailabilityID);
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
        public int getAvailabilityID() { return AvailabilityID; }
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
        public void setAvailabilityID(int availabilityID) {AvailabilityID = availabilityID;}
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

            string strSQL = "SELECT * FROM Sitters ORDER BY SitterID";

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

            string strSQL = "SELECT MAX(SitterID) FROM Sitters";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                nextID = Convert.ToInt32(result) + 1;
            }
            else
            {
                nextID = 2005; // Start from 1 if there are no sitters in the database
            }
            conn.Close();

            return nextID;
        }



        public void AddSitter()
        {
            //to open the db connection
            //string orabd = "Data Source = studentOracle:1521/orcl; User ID = T00244793; Password = ca4#mptyxU9i;";

            //Insert into Sitters table
            string strSQL1 = "INSERT INTO SITTERS VALUES (" + this.SitterID + ",'" + this.FirstName + "','" + this.LastName + "','" + this.Email + "','" + this.PhoneNo + "'," + 
                            "TO_DATE('" + this.DOB.ToString("dd-MM-yyyy") + "','DD-MM-YYYY'),'" + this.County + "','" + this.Town + "','" + this.Street + "','" + this.EirCode + "','" + 
                            this.ChildCareCertified + "','" + this.MedicalCertified + "','" + this.Language + "','" + this.Description + "','" + this.HourlyRate + "')";
                    

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            OracleCommand cmd1 = new OracleCommand(strSQL1, conn);

            cmd1.ExecuteNonQuery();

            //Insert Into S_Availability table
            string strSQL2 = "INSERT INTO S_Availability VALUES (" + this.AvailabilityID + "," + this.SitterID + ",'" + this.Monday + "','" + this.Tuesday + "','" + 
                              this.Wednesday + "','" + this.Thursday + "','" + this.Friday + "','" + this.Saturday + "','" + this.Sunday + "')";

            OracleCommand cmd2 = new OracleCommand(strSQL2, conn);
            cmd2.ExecuteNonQuery();

            conn.Close();


        }

        public static DataSet GetSitterByID(int sitterID)
        {
            DataSet ds = new DataSet();

            //to open the db connection
            
            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            //String strSQL = "SELECT * FROM Sitters WHERE SitterID = " + sitterID;

            //This is being used since sitters information is split between 2 tables.
            /*string strSQl = "SELECT s.*, a.Monday, a.Tuesday, a.Wednesday, a.Thursday, a.Friday, a.Saturday, a.Sunday " + 
                            "FROM Sitters s " + "JOIN S_Availability a ON s.SitterID = a.SitterID " + "WHERE s.SitterID = " + sitterID;*/

            string strSQL = "SELECT s.*, a.*" + "FROM SITTERS s, S_Availability a " + "WHERE s.SitterID = a.SItterID " +
                            "AND s.SitterID = " + sitterID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Sitter_By_ID");

            conn.Close();

            return ds;

        }

        public static int GetNextAvailabilityID()
        {
            int nextID = 0;

            OracleConnection conn = new OracleConnection(DataBase.connectionString);
            conn.Open();

            string strSQL = "SELECT MAX(AvailabilityID) FROM S_Availability";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                nextID = Convert.ToInt32(result) + 1;

            }
            else
            {
                nextID = 4005;

            }

            conn.Close();
            return nextID;
        }

        public static DataSet GetAllSitters() 
        {
            DataSet ds = new DataSet();
            OracleConnection conn = new OracleConnection(DataBase.connectionString);
            conn.Open();

            string strSQL = "SELECT s.SitterID, s.FirstName, s.LastName, s.Email, s.PhoneNo, s.DOB, s.County, s.Town, s.Street, s.Eircode, " +
                            "s.ChildCareCertified, s.MedicalCertified, s.Languages, s.Description, s.HourlyRate, a.Monday, a.Tuesday, a.Wednesday, a.Thursday, " +
                            "a.Friday, a.Saturday, a.Sunday " +
                            "FROM Sitters s, S_Availability a " +
                            "WHERE s.SitterID = a.SitterID " +
                            "ORDER BY s.SitterID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "All_Sitters");

            conn.Close();

            return ds;
        }

        public void UpdateSitter()
        {
            OracleConnection conn = new OracleConnection(DataBase.connectionString);
            conn.Open();

            string safeFirstName = this.FirstName.Replace("'", "''");
            string safeLastName = this.LastName.Replace("'", "''");
            string safeEmail = this.Email.Replace("'", "''");
            string safePhoneNo = this.PhoneNo.Replace("'", "''");
            string safeCounty = this.County.Replace("'", "''");
            string safeTown = this.Town.Replace("'", "''");
            string safeStreet = this.Street.Replace("'", "''");
            string safeEirCode = this.EirCode.Replace("'", "''");
            string safeChildCareCertified = this.ChildCareCertified.Replace("'", "''");
            string safeMedicalCertified = this.MedicalCertified.Replace("'", "''");
            string safeLanguage = this.Language.Replace("'", "''");
            string safeDescription = this.Description.Replace("'", "''");
            string safeHourlyRate = this.HourlyRate.Replace("'", "''");

            string strSQL1 = "UPDATE SITTERS SET " +
                             "FirstName = '" + safeFirstName + "', " +
                             "LastName = '" + safeLastName + "', " +
                             "Email = '" + safeEmail + "', " +
                             "PhoneNo = '" + safePhoneNo + "', " +
                             "DOB = TO_DATE('" + this.DOB.ToString("dd-MM-yyyy") + "','DD-MM-YYYY'), " +
                             "County = '" + safeCounty + "', " +
                             "Town = '" + safeTown + "', " +
                             "Street = '" + safeStreet + "', " +
                             "EirCode = '" + safeEirCode + "', " +
                             "ChildCareCertified = '" + safeChildCareCertified + "', " +
                             "MedicalCertified = '" + safeMedicalCertified + "', " +
                             "Languages = '" + safeLanguage + "', " +
                             "Description = '" + safeDescription + "', " +
                             "HourlyRate = '" + safeHourlyRate + "' " +
                             "WHERE SitterID = " + this.SitterID;

            OracleCommand cmd1 = new OracleCommand(strSQL1, conn);
            cmd1.ExecuteNonQuery();

            string strSQL2 = "UPDATE S_Availability SET " +
                             "Monday = '" + this.Monday + "', " +
                             "Tuesday = '" + this.Tuesday + "', " +
                             "Wednesday = '" + this.Wednesday + "', " +
                             "Thursday = '" + this.Thursday + "', " +
                             "Friday = '" + this.Friday + "', " +
                             "Saturday = '" + this.Saturday + "', " +
                             "Sunday = '" + this.Sunday + "' " +
                             "WHERE SitterID = " + this.SitterID;

            OracleCommand cmd2 = new OracleCommand(strSQL2, conn);
            cmd2.ExecuteNonQuery();

            conn.Close();


            /*OracleConnection conn = new OracleConnection( DataBase.connectionString);
            conn.Open();

            string strSQL1 = "UPDATE SITTERS SET " + "FirstName = '" + this.FirstName + "', " + "LastName = '" + this.LastName + "', " + "Email = '" + this.Email + "', " + "PhoneNo = '" + this.PhoneNo + "', " +
                            "DOB = TO_DATE('" + this.DOB.ToString("dd-MM-yyyy") + "','DD-MM-YYYY'),'" + "County = '" + this.County + "', " + "Town = '" + this.Town + "', " + "Street = '" + this.Street + "', " + "Eircode = '" + this.EirCode + "','" +
                             "ChildCareCertified = '" + this.ChildCareCertified + "', " + "MedicalCertified = '" + this.MedicalCertified + "', " + "Languages = '" + this.Language + "', " + "Description = '" + this.Description + "', " + "HourlyRate = '" + this.HourlyRate + "' " + 
                             "WHERE SitterID = " + this.SitterID;

            OracleCommand cmd1 = new OracleCommand(strSQL1, conn);
            cmd1.ExecuteNonQuery();

            string strSQL2 = "UPDATE S_Availability SET "+ "Monday = '" + this.Monday + "', " + "Tuesday = '" + this.Tuesday + "', " + "Wednesday = '" +
                              this.Wednesday + "', " + "Thursday = '" + this.Thursday + "', " + "Friday = '" + this.Friday + "', " + "Saturday = '" + this.Saturday + "', " + "Sunday = '" + this.Sunday + "' " +
                              "WHERE SitterID = " + this.SitterID;

            OracleCommand cmd2 = new OracleCommand(strSQL2, conn);
            cmd2.ExecuteNonQuery();

            conn.Close();*/
            //Failed to find what is missing to prevent ir fomr updatng the data.
            //It does retrive it but for some in bits and pieces. If its newly in put data it is fully retrived while if it is data already in the table is does not fill in the combo boxes

        }


        public void DeleteSitter()
        {
            OracleConnection conn = new OracleConnection(DataBase.connectionString);
            conn.Open();

            string strSQL1 = "DELETE FROM S_Availability WHERE SitterID = " + this.SitterID;

            OracleCommand cmd1 = new OracleCommand(strSQL1, conn);
            cmd1.ExecuteNonQuery();

            string strSQL2 =  "DELETE FROM SITTERS WHERE SitterID = " + this.SitterID;

            OracleCommand cmd2 = new OracleCommand(strSQL2, conn);
            cmd2.ExecuteNonQuery();

            conn.Close();
        }


        public static DataSet GetAvailableSitters(string dayName) 
        {
            DataSet ds = new DataSet();
            OracleConnection conn = new OracleConnection( DataBase.connectionString);
            conn.Open();

            string strSQL = "SELECT s.SitterID, s.FirstName || ' ' || s.LastName AS SitterName " +
                            "FROM SITTERS s, S_Availability a " + 
                            "WHERE s.SitterID = a.SitterID " + "AND a. " + dayName + " = 'Yes' " + 
                            "ORDER BY s.SitterID";

            OracleCommand cmd = new OracleCommand( strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds, "AvailableSitters");

            conn.Close();
            return ds;
        }
    }
}
