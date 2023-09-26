using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracking_2
{
    internal class Computer : Product
    {
        public Computer(string brand, string model, string office, string purchaseDate, string currency, int price) : base(brand, model, office, purchaseDate, currency, price)
        {

        }
    }
}
