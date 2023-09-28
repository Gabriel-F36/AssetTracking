using Asset_tracking_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackinglevel2
{
    internal class Printing
    {
        // conversion rates (2023-09-28)
        private double USD = 1;
        private double SEK = 11.04;
        private double EUR = 0.95;
        private double localPrice;

        private DateTime currentDate = DateTime.Now;
        
        // Prints a list in a nice table format
        public void PrintTableOfContent(List<Product> productList)
        {
            Console.WriteLine(
                "Type".PadRight(15) + 
                "Brand".PadRight(15) + 
                "Model".PadRight(15) + 
                "Office".PadRight(15) + 
                "Purchase Date".PadRight(15) + 
                "Price (USD)".PadRight(15) + 
                "Currency".PadRight(15) + 
                "Local price");

            Console.WriteLine(
                "----".PadRight(15) + 
                "-----".PadRight(15) + 
                "-----".PadRight(15) + 
                "------".PadRight(15) + 
                "-------------".PadRight(15) + 
                "-----------".PadRight(15) + 
                "--------".PadRight(15) + 
                "-----------");

            foreach (Product p in productList)
            {
                if ((365*3) - CheckEndOfLife(p.PurchaseDate) < 180)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                if ((365 * 3) - CheckEndOfLife(p.PurchaseDate) < 90)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }

                if (p.Currency.ToLower().Trim() == "eur")
                {
                    localPrice = p.Price * EUR;
                }
                else if (p.Currency.ToLower().Trim() == "sek")
                {
                    localPrice = p.Price * SEK;
                }
                else if (p.Currency.ToLower().Trim() == "usd")
                {
                    localPrice = p.Price * USD;
                }
                
                Console.Write(
                       p.GetType().Name.PadRight(15) +
                       p.Brand.PadRight(15) +
                       p.Model.PadRight(15) +
                       p.Office.PadRight(15) +
                       p.PurchaseDate.PadRight(15) +
                       p.Price.ToString().PadRight(15) +
                       p.Currency.PadRight(15) +
                       localPrice.ToString("#.##"));
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        // Checking how old a product is
        private int CheckEndOfLife(string date)
        {
            DateTime Date = Convert.ToDateTime(date);
            TimeSpan timeSpan = currentDate - Date;
            int daysBetween = timeSpan.Days;
            //daysBetween = (365 * 3) - daysBetween;
            return daysBetween;
        }
    }
}
