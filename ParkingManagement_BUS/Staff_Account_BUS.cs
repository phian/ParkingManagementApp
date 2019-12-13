using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagement_DAL;
namespace ParkingManagement_BUS
{
    public class Staff_Account_BUS
    {
        Staff_Account_DAL Account = new Staff_Account_DAL(); // Đối tượng để thực thi các thao tác đối với GUI

        // Hàm gọi khi người dùng đăng nhập vào ứng dụng
        public int LoginAccount(string UserName, string Password)
        {
            return Account.LoginAccount(UserName, Password);

        }
        public DataSet Get()
        {
            return Account.Get();
        }
        public void ChangePassword(int ID, string USERNAME, string NEWPASS)
        {
            Account.ChangePassword(ID, USERNAME, NEWPASS);
        }
        public void CreateAccount(string USERNAME, string PASS, int LoaiTaiKhoan)
        {
            Account.CreateAccount(USERNAME, PASS, LoaiTaiKhoan);
        }
        public void DeleteAccount(int ID)
        {
            Account.Delete(ID);
        }
    }
}
