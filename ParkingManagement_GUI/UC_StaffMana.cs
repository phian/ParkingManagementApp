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
        public int id;
        public UC_StaffMana()
        {
            InitializeComponent();
            account_BUS = new Staff_Account_BUS();
            formLoad();
            showAllAccountInfo();
        }
        Staff_Account_BUS account_BUS;
        Staff_Info_BUS info_BUS;
        
        public void showAllAccountInfo()
        {
            DataTable dt = account_BUS.Get().Tables[0];
            AccountInfo_Dtgrv.DataSource = dt;
            AccountInfo_Dtgrv.AutoResizeColumns();
        }
        void unFormLoad()
        {
            ToolBox_Panel.Enabled = true;
        }
        void ButtonDisable()
        {
            Add_Btn.Enabled= false;
            Edit_Btn.Enabled = false;
            Delete_Btn.Enabled = false;
        }
        void ButtonEnable()
        {
            Add_Btn.Enabled = true;
            Edit_Btn.Enabled = true;
            Delete_Btn.Enabled = true;
        }
        void ButtonHide()
        {
            Save_Btn.Visible = false;
            Cancel_Btn.Visible = false;
        }
        void ButtonUnHide()
        {
            Save_Btn.Visible = true;
            Cancel_Btn.Visible = true;
        }
        void formLoad()
        {
            ToolBox_Panel.Enabled = false;
            ButtonHide();
            //FullName_Txtb.Enabled = false;
            //UserName_Txtb.Enabled = false;
            //PassWord_Txtb.Enabled = false;
            //ConfirmPass_Txtb.Enabled = false;
            //Birth_DT.Enabled = false;
            //Sex_CBB.Enabled = false;
            //AccountType_Cbb.Enabled = false;
        }
        //Đồng bộ các trường thông tin từ datagridview lên các textbox
        private void AccountInfo_Dtgrv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                id = int.Parse(AccountInfo_Dtgrv.Rows[index].Cells["ID"].Value.ToString());
                UserName_Txtb.Text = AccountInfo_Dtgrv.Rows[index].Cells["Username"].Value.ToString();
                PassWord_Txtb.Text = AccountInfo_Dtgrv.Rows[index].Cells["PassWord"].Value.ToString();
                ConfirmPass_Txtb.Text = AccountInfo_Dtgrv.Rows[index].Cells["ConfirmPass"].Value.ToString();
                FullName_Txtb.Text = AccountInfo_Dtgrv.Rows[index].Cells["Fullname"].Value.ToString();
                Birth_DT.Text = AccountInfo_Dtgrv.Rows[index].Cells["Birth"].Value.ToString();
                Sex_CBB.Text = AccountInfo_Dtgrv.Rows[index].Cells["Sex"].Value.ToString();
                if(int.Parse(AccountInfo_Dtgrv.Rows[index].Cells["AccountType"].Value.ToString())==1)
                {
                    AccountType_Cbb.Text = "Quản trị";
                }
                else
                {
                    AccountType_Cbb.Text = "Nhân viên";
                }
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            unFormLoad();
            ButtonDisable();
            ButtonUnHide();
            FullName_Txtb.Clear();
            UserName_Txtb.Clear(); 
            PassWord_Txtb.Clear();
            ConfirmPass_Txtb.Clear();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            formLoad();
            ButtonEnable();
         
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            unFormLoad();
            ButtonDisable();
            ButtonUnHide();
        }
        public void DeleteData(object sender, EventArgs e)
        {
            account_BUS = new Staff_Account_BUS();
            info_BUS = new Staff_Info_BUS();
            try
            {
                DialogResult DelData = MessageBox.Show("Bạn có muốn xóa thông tin nhân viên này?", "Thông báo", MessageBoxButtons.YesNo); //Hiện thông báo xác nhận xóa
                if (DelData == DialogResult.Yes) //nếu chọn yes thì sẽ execute lệnh bên dưới để xóa
                {
                    info_BUS.Delete(id);
                    account_BUS.DeleteAccount(id);
                }
            }
            catch(Exception ez)
            {
                MessageBox.Show(ez.ToString());
            }
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            DeleteData(sender, e);
            showAllAccountInfo();
        }
    }
}
