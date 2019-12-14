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
   public  class Staff_Account_DAL
    {
        // List để lưu dữ liệu mật khẩu truy xuất từ database (xét xem nhân viên có nhập đúng mk đăng nhập hay không)
        List<Staff_Account_DTO> List_accounts = new List<Staff_Account_DTO>();

        // Hàm để lưu thông tin password của nhân viên lấy từ database
        public void Get_Account_Info() //Lấy thông tin tài khoản nhân viên từ database, thêm nó vào list "Account"
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) // khởi tạo kết nối đến database
            {
                connection.Open(); // Mở kết nối đến database

                string Select_all = "SELECT * from TaiKhoan";

                SqlCommand sqlcmd = new SqlCommand(Select_all, connection); // Truy xuất dữ liệu từ database
                SqlDataReader Data_reader = sqlcmd.ExecuteReader(); // biến để đọc dữ liệu truy xuất và lưu vào list

                while (Data_reader.Read())
                {
                    Staff_Account_DTO Staff = new Staff_Account_DTO(); // biến để lưu trữ các thông tin được đọc ra và đưa vào list

                    Staff.ID = (int)Data_reader["ID"];
                    Staff.USERNAME = (string)Data_reader["Username"]; // đọc dữ liệu đã truy xuất
                    Staff.PASS = (string)Data_reader["Pass"];
                    Staff.LOAITAIKHOAN = (int)Data_reader["LoaiTaiKhoan"];

                    List_accounts.Add(Staff); // Lưu dữ liệu đã đọc vào list "Account"
                }

                connection.Close(); // Đóng kết nối đến database
            }
        }
        //Hàm lấy thông tin phục vụ chức năng "Quản lý tài khoản" 
        //UC_AccountList
        public DataSet Get()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT NhanVien.ID, NhanVien.Ten,NhanVien.NgaySinh,NhanVien.GIOITINH, TaiKhoan.Username,TaiKhoan.Pass,TaiKhoan.LoaiTaiKhoan from TaiKhoan, NhanVien WHERE TaiKhoan.ID=NhanVien.ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
                
        //Xoá tài khoản đăng nhập ứng dụng
        public void Delete(int ID)
        {
            string Delete_from = "DELETE FROM TaiKhoan WHERE ID=@ID";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    cmdInsert.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Đã xoá tài khoản thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Tạo mới tai khoản đăng nhập ứng dụng
        public void CreateAccount(string USERNAME, string PASS, int LOAITAIKHOAN)
        {
            string Update_set = "INSERT INTO TaiKhoan VALUES (@USERNAME, @PASS, @LoaiTaiKhoan)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    
                    cmdInsert.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = USERNAME;
                    cmdInsert.Parameters.Add("@PASS", SqlDbType.VarChar).Value = PASS;
                    cmdInsert.Parameters.Add("@LoaiTaiKhoan", SqlDbType.Int).Value = LOAITAIKHOAN;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Tạo tài khoản thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int LoginAccount(string UserName, string Password)
        {
            Get_Account_Info(); // Gọi hàm để add thông tin tk user vào list để xét đăng nhập
            //Vòng lặp để xét xem mật khẩu và user name đã dc nhập đúng hay chưa(xét từ đầu tới cuối)
            for (int i = 0; i < List_accounts.Count; i++)
            {
                // Nếu nhập đúng thì ẩn form nhập password và hiển thị form tiếp theo
                if (List_accounts[i].USERNAME == UserName && checkPass(Password, List_accounts[i].PASS))
                {
                    //CheckUser = true;
                    // Xét xem phân quyền là admin hay nhân viên để trả về giá trị tương ứng và gọi form tương ứng
                    if (List_accounts[i].LOAITAIKHOAN == 0)
                        return 0; // return 0 trong TH là nhân viên
                    else
                        return 1;
                }
            }

            return 2; // return 1 trong TH là quản lý
        }
        private bool checkPass(string Entered_password, string Saved_password)
        {
            try
            {
                if (Entered_password.Equals(Saved_password))
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            return false;
        }
    }
}
