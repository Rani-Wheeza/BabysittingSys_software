using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysittingSys
{
    class DataBase
    {
        //The first connection string below is used when using your laptop/PC. Check the host name and use the username and password set when 
        //you installed Oracle.
        public const String connectionString = "Data Source = localhost/orcl; User ID = T00244793; Password = ca4#mptyxU9i;"; //school desktop

        //public const String connectionString = "Data Source = localhost/orcl; User ID = C##User1; Password = 123456;"; // home desktop

        //When in MTU labs use the connection string that has your t-number and password instead
        //public const String connectionString = "Data Source = studentoracle:1521/orcl; User ID = tnnnnnnnnn; Password = **********;"; 
    }
}
