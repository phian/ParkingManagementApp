using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingManagement_BUS;
namespace ParkingManagement_GUI
{
    public partial class UC_StaffMana : UserControl
    {
        public UC_StaffMana()
        {
            InitializeComponent();
            account_BUS = new Staff_Account_BUS();
            showAllAccountInfo();
        }
        Staff_Account_BUS account_BUS;
        public void showAllAccountInfo()
        {
            DataTable dt = account_BUS.Get().Tables[0];
            AccountInfo_Dtgrv.DataSource = dt;
            AccountInfo_Dtgrv.AutoResizeColumns();
        }
        private void AccountInfo_Dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                //UserName_Txtb.Text = AccountInfo_Dtgrv.Rows[index].Cells["FULLNAME"].Value.ToString();
                //PassWord_Txtb.Text = AccountInfo_Dtgrv.Rows[index].Cells["DOB"].Value.ToString();
                //ConfirmPass_Txtb.Text = AccountInfo_Dtgrv.Rows[index].Cells["LOCA"].Value.ToString();
                //FullName_Txtb.Text = AccountInfo_Dtgrv.Rows[index].Cells["PHONE"].Value.ToString();
                //Birth_DT.Text= AccountInfo_Dtgrv.Rows[index].Cells["DOB"].Value.ToString();
                //AccountType_Cbb.SelectedValue= AccountInfo_Dtgrv.Rows[index].Cells["DOB"].Value.ToString();
                //if (string.Equals("0", AccountInfo_Dtgrv.Rows[index].Cells["SEX"].Value.ToString()))
                //{
                //    rb_male.Checked = true;
                //}
                //else if (string.Equals("1", dgv_st.Rows[index].Cells["SEX"].Value.ToString()))
                //{
                //    rb_female.Checked = true;
                //}
            }
        }

    }
}
