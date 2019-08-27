using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Course1.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name + "(Used) $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufactured Date: " + ManufactureDate.ToString("dd/MM/yyyy")+")";
        }
    }
}
