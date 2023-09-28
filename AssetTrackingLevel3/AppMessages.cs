using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackinglevel2
{
    internal class AppMessages
    {
        // Predifined messages
        public void Instructions() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type of product to add | Enter 'C' for computer and 'P' for phones | Enter 'exit' when all products are added");
            Console.ResetColor();
        }
        public void TryAgainInt()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("It wasn't a valid number, try again");
            Console.ResetColor();

        }
        public void TryAgainDate()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Not valid. Check the format of the given date");
            Console.ResetColor();

        }
        public void SuccessfulAdd()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Product added successfully");
            Console.ResetColor();
        }
        public void CurrencyNotFound()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Currency not found");
            Console.ResetColor();
        }
    }
}
