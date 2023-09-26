using Asset_tracking_2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackinglevel2
{
    internal class AddProduct
    {
        // Adds a phone object to a list of products
        public void Phone(List<Product> list) 
        {
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Office: ");
            string office = Console.ReadLine();
        tryDate:
            Console.Write("Purchase date (yyyy-mm-dd): ");
            string date = Console.ReadLine();
            if (!DateTime.TryParse(date, out DateTime purchaseDate))
            {
                new AppMessages().TryAgainDate();
                goto tryDate;
            }

            Console.Write("Curreny: ");
            string curreny = Console.ReadLine().ToUpper();

        tryPrice:
            Console.Write("Price: ");            
            string price = Console.ReadLine();
            if (!int.TryParse(price, out int value))
            {
                new AppMessages().TryAgainInt();
                goto tryPrice;
            }
            

            list.Add(new Phone(brand, model, office, date, curreny, value));
        }

        // Adds a Computer object to a list of products
        public void Computer(List<Product> list)
        {
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Office: ");
            string office = Console.ReadLine();
        tryDate:
            Console.Write("Purchase date (yyyy-mm-dd): ");
            string date = Console.ReadLine();
            if (!DateTime.TryParse(date, out DateTime notAUsedVariable))
            {
                new AppMessages().TryAgainDate();
                goto tryDate;
            }

            Console.Write("Curreny: ");
            string curreny = Console.ReadLine().ToUpper();

        tryPrice:
            Console.Write("Price: ");
            string price = Console.ReadLine();
            if (!int.TryParse(price, out int value))
            {
                new AppMessages().TryAgainInt();
                goto tryPrice;
            }


            list.Add(new Phone(brand, model, office, date, curreny, value));
        }
    }
}
