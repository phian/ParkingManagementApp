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
    public class Staff_Info_DAL
    {
        //Hàm lấy thông tin toàn bộ các nhân viên từ cơ sở dữ liệu
        List<Staff_Info_DTO> List_Info = new List<Staff_Info_DTO>();
        public DataSet Get_Staff_Info()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT * from Nhanvien";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        //Hàm đồng bộ thông tin nhân viên từ csdl
        public void Display_Staff_Info() //Lấy thông tin tài khoản nhân viên từ database, thêm nó vào list "Account"
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) // khởi tạo kết nối đến database
            {
                connection.Open(); // Mở kết nối đến database

                string Select_all = "SELECT * from NhanVien";

                SqlCommand sqlcmd = new SqlCommand(Select_all, connection); // Truy xuất dữ liệu từ database
                SqlDataReader Data_reader = sqlcmd.ExecuteReader(); // biến để đọc dữ liệu truy xuất và lưu vào list

                while (Data_reader.Read())
                {
                    Staff_Info_DTO Staff = new Staff_Info_DTO(); // biến để lưu trữ các thông tin được đọc ra và đưa vào list

                    Staff.ID = (int)Data_reader["ID"];
                    Staff.TEN = (string)Data_reader["Ten"]; // đọc dữ liệu đã truy xuất
                    Staff.NGAYSINH = (DateTime)Data_reader["NgaySinh"];
                    List_Info.Add(Staff); // Lưu dữ liệu đã đọc vào list "Info"
                }

                connection.Close(); // Đóng kết nối đến database
            }
        }
        //Hàm thêm thông tin 1 nhân viên mới vào cơ sở dữ liệu
        public void Add_New_Staff_Info(string FULLNAME, DateTime DOB, string GIOITINH)
        {
            string Insert_into = "INSERT INTO NhanVien VALUES (@FULLNAME, @DOB, @Sex)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                  
                    cmdInsert.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = FULLNAME;
                    cmdInsert.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                    cmdInsert.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = GIOITINH;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                   
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        //Hàm thay đổi thông tin 1 nhân viên trong cơ sở dữ liệu
        public void Update_Staff_Info(int id, string FULLNAME, DateTime DOB, String Gioitinh)
        {
            string Update_set = "UPDATE NhanVien SET Ten=@FULLNAME, NgaySinh=@DOB, GIOITINH=@Gioitinh WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    cmdInsert.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = FULLNAME;
                    cmdInsert.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                    cmdInsert.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = Gioitinh;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        //Hàm xoá thông tin 1 nhân viên khỏi cơ sở dữ liệu
        public void Delete_Staff_Info(int ID)
        {
            string Delete_from = "DELETE FROM NhanVien WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
           
                }
                catch (Exception)
                {
                   
                }
        }

    }
}
