using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace fixação_herança_e_polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string priceTag()
        {
            return Name
                + "(used) $"
                + Price.ToString("F2",CultureInfo.InvariantCulture)
                + $"Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}
