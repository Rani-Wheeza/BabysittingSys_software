using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysittingSys
{
    public class Bookings
    {
        //public string BookingID { get; set; } public string ParentID { get; set; } public string BabysitterID { get; set; } public DateTime StartTime { get; set; } public DateTime EndTime { get; set; } public decimal TotalCost { get; set; } public Bookings(string bookingID, string parentID, string babysitterID, DateTime startTime, DateTime endTime, decimal totalCost) { BookingID = bookingID; ParentID = parentID; BabysitterID = babysitterID; StartTime = startTime; EndTime = endTime; TotalCost = totalCost; }

        private int BookingID;
        private int ClientID;
        private string ClientName;
        private string ClientEmail;
        private string ClientPhoneNo;
        private int SitterID;
        private string SitterName;
        private string SitterEmail;
        private string SitterPhoneNo;
        private string HourlyRate;
        private DateTime BookDate;
        private DateTime BookTime;
        private string Duration;
        private string TotalCost;
        private string Payement;

        public Bookings()
        {
            BookingID = 0;
            ClientID = 0;
            ClientName = "";
            ClientEmail = "";
            ClientPhoneNo = "";
            SitterID = 0;
            SitterName = "";
            SitterEmail = "";
            SitterPhoneNo = "";
            HourlyRate = "";
            BookDate = DateTime.Now;
            BookTime = DateTime.Now;
            Duration = "";
            TotalCost = "";
            Payement = "";

        }

        public Bookings(int bookingID, int clientID, string clientName, string clientEmail, string clientPhoneNo, int sitterID, string sitterName, string sitterEmail, string sitterPhoneNo, string hourlyRate, DateTime bookDate, DateTime bookTime, string duration, string totalCost, string payement)
        {
            setBookingID(bookingID);
            setClientID(clientID);
            setClientName(clientName);
            setClientEmail(clientEmail);
            setClientPhoneNo(clientPhoneNo);
            setSitterID(sitterID);
            setSitterName(sitterName);
            setSitterEmail(sitterEmail);
            setHourlyRate(hourlyRate);
            setBookDate(bookDate);
            setBookTime(bookTime);
            setDuration(duration);
            setTotalCost(totalCost);
            setPayment(payement);
        }

        //Getters
        public int getBookingID() { return BookingID; }
        public int getClientID() { return ClientID; }
        public string getClientName() { return ClientName; }
        public string getClientEmail() { return ClientEmail; }
        public string getClientPhoneNo() { return ClientPhoneNo; }
        public int getSitterID() { return SitterID; }
        public string getSitterName() { return SitterName; }
        public string getSitterEmail() { return SitterEmail; }
        public string getSitterPhoneNo() { return SitterPhoneNo; }
        public string getHourlyRate() { return HourlyRate; }
        public DateTime getBookDate() { return BookDate; }
        public DateTime getBookTime() { return BookTime; }
        public string getDuration() { return Duration; }
        public string getTotalCost() { return TotalCost; }
        public string getPayement() { return Payement; }

        //Setters
        public void setBookingID(int bookingID) { BookingID = bookingID; }
        public void setClientID(int clientID) { ClientID = clientID; }
        public void setClientName(string clientName) { ClientName = clientName; }
        public void setClientEmail(string clientEmail) { ClientEmail = clientEmail; }
        public void setClientPhoneNo(string clientPhoneNo) { ClientPhoneNo = clientPhoneNo; }
        public void setSitterID(int sitterID) { SitterID = sitterID; }
        public void setSitterName(string sitterName) { SitterName = sitterName; }
        public void setSitterEmail(string sitterEmail) { SitterEmail = sitterEmail; }
        public void setSitterPhoneNo(string sitterPhoneNo) { SitterPhoneNo = sitterPhoneNo; }
        public void setHourlyRate(string hourlyRate) { HourlyRate = hourlyRate; }
        public void setBookDate(DateTime bookDate) { BookDate = bookDate; }
        public void setBookTime(DateTime bookTime) { BookTime = bookTime; }
        public void setDuration(string duration) { Duration = duration; }
        public void setTotalCost(String totalCost) { TotalCost = totalCost; }
        public void setPayment(string payment) { Payement = payment; }


        public static DataSet getBookings()
        {
            DataSet ds = new DataSet();

            //to open the db connection
            
            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            String strSQL = "SELECT * FROM Bookings ORDER BY BookingID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Booking");

            conn.Close();

            return ds;

        }

        public static int GetNextBookingID()
        {
            int nextID = 0;

            //to open the db connection
           
            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            string strSQL = "SELECT MAX(BookingID) FROM Bookings";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                nextID = Convert.ToInt32(result) + 1;
            }
            else
            {
                nextID = 3005; // Start from 1 if there are no clients in the database
            }
            conn.Close();

            return nextID;
        }



        public void AddBooking()
        {
            //to open the db connection
           

            string strSQL = "INSERT INTO BOOKINGS VALUES (" + this.BookingID + ",'" + this.ClientID + "','" + this.ClientName +  "','" + this.ClientEmail + "','" + 
                            this.ClientPhoneNo + "','" + this.SitterID+ "','" + this.SitterName + "','" + this.SitterEmail + "','" + this.SitterPhoneNo + "','" + 
                            this.HourlyRate + "','" + "TO_DATE('" + this.BookDate.ToString("dd-MM-yyyy") + "','DD-MM-YYYY')," + 
                            "TO_DATE('" + this.BookTime.ToString("HH:mm") + "','HH24:MI')," + this.Duration + "','" + this.TotalCost + "','" + this.Payement + "')";

            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();


        }

        public static DataSet GetBookingByID(int bookingID)
        {
            DataSet ds = new DataSet();

            //to open the db connection
            
            OracleConnection conn = new OracleConnection(DataBase.connectionString);

            conn.Open();

            String strSQL = "SELECT * FROM Bookings WHERE BookingID = " + bookingID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "Booking_By_ID");

            conn.Close();

            return ds;

        }



    }
            
    
    
}
