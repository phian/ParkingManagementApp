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
    public partial class MainForm : Form
    {
        public int Account_Type;
        Staff_Only_Form staff_only;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Staff_Only_Form_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff_only = new Staff_Only_Form();
            staff_only.Account_Type = Account_Type;
            staff_only.ShowDialog();
            this.Show();
        }
    }

}

