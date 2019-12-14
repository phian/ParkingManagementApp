using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement_GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.ActiveControl = UserNamePB;
        }

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
                PasswordTxb.Text = "Password";
                PasswordTxb.Font = new Font("Century Gothic", 14.25f, FontStyle.Italic);
                PasswordTxb.ForeColor = Color.DarkGray;
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
            MainForm mainForm = new MainForm();

            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
