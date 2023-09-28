using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracking_2
{
    internal class Product
    {
        public Product()
        {

        }
        // Constructor
        public Product(string brand, string model, string office, string purchaseDate, string currency, int price)
        {
            Brand = brand;
            Model = model;
            Office = office;
            PurchaseDate = purchaseDate;
            Currency = currency;
            Price = price;
        }
        // Get and set for all variables
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Office { get; set; }
        public string PurchaseDate { get; set; }
        public string Currency { get; set; }
        public int Price { get; set; }
    }
}
