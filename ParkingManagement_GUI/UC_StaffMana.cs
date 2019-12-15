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
using System.Globalization;

namespace ParkingManagement_GUI
{
    public partial class UC_StaffMana : UserControl
    {
        
        public int Add_or_save;
        public int id;
        public string Pass;
        public  string Confirm_Pass;
        public  string User_name;
        public string Full_name;
        public DateTime DOB;
        public string Gioitinh;
        public int Account_Type;
        public UC_StaffMana()
        {
            InitializeComponent();
            account_BUS = new Staff_Account_BUS();
            info_BUS = new Staff_Info_BUS();
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
            ConfirmPass_Txtb.UseSystemPasswordChar = true;
            PassWord_Txtb.UseSystemPasswordChar = true;
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
            Add_or_save = 0;
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
            Add_or_save = 1;
            unFormLoad();
            ButtonDisable();
            ButtonUnHide();
        }
        public void DeleteData(object sender, EventArgs e)
        { 
            try
            {
                if (MessageBox.Show
                 ("Bạn có chắc chắn muốn xóa thông tin này. CÁC DỮ LIỆU LIÊN QUAN ĐẾN MÃ LOẠI SẢN PHẨM NÀY SẼ ĐỀU BỊ XÓA",
                  "Thông báo",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    info_BUS.Delete(id);
                    account_BUS.DeleteAccount(id);
                    MessageBox.Show("Xác nhận thao tác thành công");
                    showAllAccountInfo();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Thao tác không thành công!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddData(object sender, EventArgs e) //Hàm nhập dữ liệu vào Database
        {
            try
            {
                account_BUS.CreateAccount(User_name, Pass, Account_Type);
                info_BUS.Add(Full_name, DOB, Gioitinh);
                MessageBox.Show("Xác nhận thao tác thành công!");
            }
            catch(Exception)
            {
                MessageBox.Show("Thao tác không thành công!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Hàm thay đổi thông tin nhân viên trong CSDL
        public void EditData(object sender, EventArgs e) //Hàm nhập dữ liệu vào Database
        {try
            {
                account_BUS.UpdateAccount(id, User_name, Pass, Account_Type);
                info_BUS.Update(id, Full_name, DOB, Gioitinh);
                MessageBox.Show("Xác nhận thao tác thành công!");
            }
            catch(Exception)
            {
                MessageBox.Show("Thao tác không thành công!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            DeleteData(sender, e);
            showAllAccountInfo();
        }
        // Ham kiểm tra dữ liệu nhập vào
        private bool checkData()
        {
            
            if (string.IsNullOrEmpty(UserName_Txtb.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserName_Txtb.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(PassWord_Txtb.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PassWord_Txtb.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(ConfirmPass_Txtb.Text))
            {
                MessageBox.Show("Bạn chưa xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmPass_Txtb.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(FullName_Txtb.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FullName_Txtb.Focus();
                return false;
            }
            if (PassWord_Txtb.Text.Equals(ConfirmPass_Txtb.Text)==false)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác, vui lòng kiểm tr lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmPass_Txtb.Focus();
                return false;
            }
            if (Sex_CBB.SelectedItem==null)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Sex_CBB.Focus();
                return false;
            }
            return true;
        }

        private void seenOrunseen_Btn_Click(object sender, EventArgs e)
        {
            if (PassWord_Txtb.UseSystemPasswordChar == true)
                PassWord_Txtb.UseSystemPasswordChar = false;
            else
                PassWord_Txtb.UseSystemPasswordChar = true;
        }

        private void seenORunseen1_Btn_Click(object sender, EventArgs e)
        {
            if (ConfirmPass_Txtb.UseSystemPasswordChar == true)
                ConfirmPass_Txtb.UseSystemPasswordChar = false;
            else
                ConfirmPass_Txtb.UseSystemPasswordChar = true;
        }

        private void FullName_Txtb_Leave(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("vn-VN", false).TextInfo;
            FullName_Txtb.Text = textInfo.ToTitleCase(FullName_Txtb.Text.ToLower()); //Chuyển tất cả về chữ thường sau đó đổi kiểu chữ hoa chữ cái đầu tiên
        }
        private bool Set_varialbe_name()
        {
            if (checkData())
            {
                User_name = UserName_Txtb.Text;
                Pass = PassWord_Txtb.Text;
                Confirm_Pass = ConfirmPass_Txtb.Text;
                Full_name = FullName_Txtb.Text;
                DOB = Birth_DT.Value;
                Gioitinh = Sex_CBB.SelectedItem.ToString();
                if (AccountType_Cbb.SelectedItem.ToString() == "Quản trị")
                    Account_Type = 1;
                else
                    Account_Type = 0;
                return true;
            }
            return false;
        }
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if(Add_or_save==0)
            {
                if (Set_varialbe_name())
                {
                    Set_varialbe_name();
                    AddData(sender, e);
                    //Gọi sự kiện nút Huỷ - Hiển thị lại các nút chức năng ban đầu
                    Cancel_Btn_Click(sender, e);
                    //Sau khi thêm dữ liệu mới vào database thì cập nhật dữ liệu mới lên datagridview
                    showAllAccountInfo();
                }
            }
            else
            {
                if (Set_varialbe_name())
                {
                    Set_varialbe_name();
                    EditData(sender, e);
                    //Gọi sự kiện nút Huỷ - Hiển thị lại các nút chức năng ban đầu
                    Cancel_Btn_Click(sender, e);
                    //Sau khi thêm dữ liệu mới vào database thì cập nhật dữ liệu mới lên datagridview
                    showAllAccountInfo();
                }
            }
        }
    }
}
