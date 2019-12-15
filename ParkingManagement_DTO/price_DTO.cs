using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement_DTO
{
    public class price_DTO
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private Decimal priceday;
        public Decimal PRICEDAY
        {
            get { return priceday; }
            set { priceday = value; }
        }
        private Decimal pricenight;
        public Decimal PRICENIGHT
        {   get { return pricenight; }
            set { pricenight = value; }
        }

    }
}
