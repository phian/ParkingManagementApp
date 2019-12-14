using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagement_DAL;
namespace ParkingManagement_BUS
{
    public class Staff_Info_BUS
    {
        Staff_Info_DAL temp = new Staff_Info_DAL();

        public DataSet Get()
        {
            return temp.Get_Staff_Info();
        }
        public void Update(int ID, string FULLNAME, DateTime DOB, string Gioitinh)
        {
            temp.Update_Staff_Info(ID, FULLNAME, DOB, Gioitinh);
        }
        public void Delete(int ID)
        {
            temp.Delete_Staff_Info(ID);
        }
        public void Add(string FULLNAME, DateTime DOB,string GIOITINH)
        {
            temp.Add_New_Staff_Info(FULLNAME, DOB,GIOITINH);
        }
    }
}
