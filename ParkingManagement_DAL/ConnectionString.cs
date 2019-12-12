using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace ParkingManagement_DAL
{
    public class ConnectionString
    {
        // Đường dẫn database
        public static string connectionString = "Data Source=" + Dns.GetHostName() + ";Initial Catalog=PARKINGMANAGE;Integrated Security=True";
        public SqlConnection GetConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
