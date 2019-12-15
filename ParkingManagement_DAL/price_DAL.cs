using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingManagement_DTO;
namespace ParkingManagement_DAL
{
    public class price_DAL
    {
        
        public void getPriceFromDB(price_DTO price)// Lấy thông tin giá từ DB
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) // khởi tạo kết nối đến database
            {
                connection.Open(); // Mở kết nối đến database

                string Select_all = "SELECT * from PhiGuiXe";

                SqlCommand sqlcmd = new SqlCommand(Select_all, connection); // Truy xuất dữ liệu từ database
                SqlDataReader Data_reader = sqlcmd.ExecuteReader(); // biến để đọc dữ liệu truy xuất và lưu vào list

                while (Data_reader.Read())
                {
                    price.ID = (int)Data_reader["ID"];
                    price.PRICEDAY = (Decimal)Data_reader["PhiNgay"];
                    price.PRICENIGHT = (Decimal)Data_reader["PhiQuaDem"];
                }
                connection.Close(); // Đóng kết nối đến database
            }
        }
        public bool Update_PRICE(price_DTO price)
        {
            string Update_set = "UPDATE PhiGuiXe SET PhiNgay= @phingay,PhiQuaDem = @phiquadem  WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.Int).Value = price.ID;
                    cmdInsert.Parameters.Add("@phingay", SqlDbType.Decimal).Value = price.PRICEDAY;
                    cmdInsert.Parameters.Add("@phiquadem", SqlDbType.Decimal).Value = price.PRICENIGHT;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
            }
            return true;
        }
    }
}
