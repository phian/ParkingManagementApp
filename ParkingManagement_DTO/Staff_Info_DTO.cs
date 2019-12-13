using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement_DTO
{
    class Staff_Info
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string ten;
        public string TEN
        {
            get { return ten; }
            set { ten = value; }
        }
        private DateTime ngaysinh;
            public DateTime NGAYSINH
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
    }
}
