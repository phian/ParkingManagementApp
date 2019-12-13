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
                    Staff.ID_taikhoan = (int)Data_reader["ID_taikhoan"];
                    List_Info.Add(Staff); // Lưu dữ liệu đã đọc vào list "Info"
                }

                connection.Close(); // Đóng kết nối đến database
            }
        }
        //Hàm thêm thông tin 1 nhân viên mới vào cơ sở dữ liệu
        public void Add_New_Staff_Info(string FULLNAME, string DOB,string ID_TaiKhoan)
        {
            string Insert_into = "INSERT INTO NhanVien VALUES (@FULLNAME, @DOB,@ID_TaiKhoan)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = FULLNAME;
                    cmdInsert.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;
                    cmdInsert.Parameters.Add("@ID_TaiKhoan",SqlDbType.VarChar).Value=ID_TaiKhoan;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thêm thông tin nhân viên, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Hàm thay đổi thông tin 1 nhân viên trong cơ sở dữ liệu
        public void Update_Staff_Info(int id, string FULLNAME, string DOB,int ID_TaiKhoan)
        {
            string Update_set = "UPDATE NhanVien SET Ten=@FULLNAME, NgaySinh=@DOB WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@ID_TaiKhoan", SqlDbType.VarChar).Value = ID_TaiKhoan;
                    cmdInsert.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = FULLNAME;
                    cmdInsert.Parameters.Add("@DOB", SqlDbType.SmallDateTime).Value = DOB;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sửa thông tin nhân viên thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thay đổi thông tin nhân viên, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Hàm xoá thông tin 1 nhân viên khỏi cơ sở dữ liệu
        public void Delete_Staff_Info(string ID)
        {
            string Delete_from = "DELETE FROM NhanVien WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xoá thông tin nhân viên thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xoá nhân viên này, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

    }
}
