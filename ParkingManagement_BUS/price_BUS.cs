using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagement_DAL;
using ParkingManagement_DTO;
namespace ParkingManagement_BUS
{
    public class price_BUS
    {
        price_DAL price = new price_DAL();
        public void displayPrice(price_DTO priceDTO)
        {
            price.getPriceFromDB(priceDTO);
        }
        public bool Update_Price(price_DTO priceDTO)
        {
           return price.Update_PRICE(priceDTO);
        }
    }
}
