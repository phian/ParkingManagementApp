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
    public partial class Staff_Only_Form : Form
    {
        public int Account_Type;
        public Staff_Only_Form()
        {
            InitializeComponent();
        }
        UC_StaffMana StaffManage = new UC_StaffMana();
        UC_Note Note = new UC_Note();
        UC_PriceEdit priceEdit = new UC_PriceEdit();
        UC_Analytics analytics = new UC_Analytics();
        public void admin_and_other()
        {
            if (Account_Type == 1)
            {
                Staff_Btn.Visible = true;
                Staff_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\admin.png");
            }
            else
            {
                Staff_Btn.Visible = false;
                Staff_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\user.png");
            }
        }

        private void Staff_Only_Form_Load(object sender, EventArgs e)
        {
            admin_and_other();
            
        }

        private void Note_Btn_Click(object sender, EventArgs e)
        {
            GoFullscreen(false);
            Staff_acti_Panel.Controls.Clear();
            Staff_acti_Panel.Controls.Add(Note);
            
        }
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        
        private void Staff_Btn_Click(object sender, EventArgs e)
        {
            
            Staff_acti_Panel.Controls.Clear();
            Staff_acti_Panel.Controls.Add(StaffManage);
        }

        private void priceEdit_Btn_Click(object sender, EventArgs e)
        {
            Staff_acti_Panel.Controls.Clear();
            Staff_acti_Panel.Controls.Add(priceEdit);
        }
    }
}
