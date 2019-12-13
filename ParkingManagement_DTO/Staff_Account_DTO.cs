using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement_DTO
{
    public class Staff_account
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string username;
        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }
        private string pass;
        public string PASS
        {
            get { return pass; }
            set { pass = value; }
        }
        private int loaitaikhoan;
        public int LOAITAIKHOAN
        {
            get { return loaitaikhoan; }
            set { loaitaikhoan = value; }
        }
    }
}
