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
using ParkingManagement_DTO;
namespace ParkingManagement_GUI
{

    public partial class UC_PriceEdit : UserControl
    {
        public price_DTO priceDTO = new price_DTO();
        public price_BUS priceBUS = new price_BUS();
        public UC_PriceEdit()
        {
            InitializeComponent();
            getPriceFromDB(priceDTO);
        }
        void getPriceFromDB(price_DTO priceDTO)
        {
            priceBUS.displayPrice(priceDTO);
            priceDay_TxtB.Text = priceDTO.PRICEDAY.ToString();
            priceNight_TxtB.Text = priceDTO.PRICENIGHT.ToString();
        }

        private void UC_PriceEdit_Load(object sender, EventArgs e)
        {
            priceNight_TxtB.Enabled = false;
            priceDay_TxtB.Enabled = false;
        }

        private void savePrice_Btn_Click(object sender, EventArgs e)
        {
            priceDTO.PRICEDAY = Decimal.Parse(priceDay_TxtB.Text);
            priceDTO.PRICENIGHT = Decimal.Parse(priceNight_TxtB.Text);
            if(priceBUS.Update_Price(priceDTO))
            {
                getPriceFromDB(priceDTO);
                MessageBox.Show("Xác nhận thao tác thành công");
                UC_PriceEdit_Load(sender, e);
            }
        }
        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            UC_PriceEdit_Load(sender,e );
        }

        private void editPrice_Btn_Click(object sender, EventArgs e)
        {
            priceDay_TxtB.Enabled = true;
            priceNight_TxtB.Enabled = true; ;
        }
    }
}
