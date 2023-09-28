using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracking_1
{
    internal class Laptop : Product
    {
        public Laptop(string brand, string model, string office, string purchaseDate, string currency, int price) : base(brand, model, office, purchaseDate, currency, price)
        {

        }
    }
}
