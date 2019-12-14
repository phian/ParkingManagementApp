using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingManagement_BUS;
namespace ParkingManagement_GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.ActiveControl = UserNamePB;
        }
        
        Staff_Account_BUS Staff = new Staff_Account_BUS();
        MainForm main_form;

        // event when user enter the textbox
        private void UserNameTxb_Enter(object sender, EventArgs e)
        {
            if (UserNameTxb.Text.Equals("User name"))
            {
                UserNameTxb.Text = "";
                UserNameTxb.Font = new Font(FontFamily.GenericSansSerif, 14.25f, FontStyle.Regular);
                UserNameTxb.ForeColor = Color.Black;
            }
        }

        // // event when user leave the textbox
        private void UserNameTxb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTxb.Text) && string.IsNullOrWhiteSpace(UserNameTxb.Text))
            {
                UserNameTxb.Text = "User name";
                UserNameTxb.Font = new Font("Century Gothic", 14.25f, FontStyle.Italic);
                UserNameTxb.ForeColor = Color.DarkGray;
            }
        }

        // event when user enter the password box
        private void PasswordTxb_Enter(object sender, EventArgs e)
        {
            if (PasswordTxb.Text.Equals("Password"))
            {
                PasswordTxb.UseSystemPasswordChar = true;
                PasswordTxb.Text = "";
                PasswordTxb.Font = new Font(FontFamily.GenericSansSerif, 14.25f, FontStyle.Regular);
                PasswordTxb.ForeColor = Color.Black;
            }
        }

        // event when user leave the password box
        private void PasswordTxb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTxb.Text) && string.IsNullOrWhiteSpace(PasswordTxb.Text))
            {
                PasswordTxb.UseSystemPasswordChar = false;
                PasswordTxb.Text = "Password";
                PasswordTxb.Font = new Font("Century Gothic", 14.25f, FontStyle.Italic);
                PasswordTxb.ForeColor = Color.DarkGray;

                this.ActiveControl = UserNamePB;
            }
        }

        // event when user click the form to unfocus the TextBoxes
        private void LoginForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = UserNamePB;
        }

        // event when user click the image to unfocus the TextBoxes
        private void LoginHeaderImage_Click(object sender, EventArgs e)
        {
            this.ActiveControl = UserNamePB;
        }

        // event when user click the image to unfocus the TextBoxes
        private void LoginScreenMainImg_Click(object sender, EventArgs e)
        {
            this.ActiveControl = UserNamePB;
        }

        // event whe user click log in button
        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (Staff.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 0|| Staff.LoginAccount(UserNameTxb.Text, PasswordTxb.Text) == 1)
            {
                this.Hide();
                main_form = new MainForm();
                main_form.Account_Type = Staff.LoginAccount(UserNameTxb.Text, PasswordTxb.Text);
                main_form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng! Vui lòng nhập lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Sau khi kiểm tra hết các tk có trong database nếu không giống cái nào thì reset lại ô nhập
                UserNameTxb.Text = "";
                PasswordTxb.Text = "";
                UserNameTxb.Select(); // Focus lại vào ô nhập user name
                return;
            }
        }


    }
}
