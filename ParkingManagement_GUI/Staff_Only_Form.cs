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
        public Staff_Only_Form()
        {
            InitializeComponent();
        }
        private void Staff_Acc_Btn_Click(object sender, EventArgs e)
        {
            AddSaveDe_Panel.Visible = true;
            AddSaveDe_Panel.Enabled = true;
            Staff_acti_Panel.Controls.Clear();
            Staff_acti_Panel.Controls.Add(StaffManage);
        }
        UC_StaffMana StaffManage = new UC_StaffMana();
        private void Staff_Only_Form_Load(object sender, EventArgs e)
        {
            AddSaveDe_Panel.Visible = false;
            AddSaveDe_Panel.Enabled = false;

        }
    }
}
