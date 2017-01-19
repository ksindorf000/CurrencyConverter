using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static double amount;
        static List<string> currency = new List<string>()
        {
            "USD", "EUR", "GBP", "INR", "AUD", "CAD", "ZAR", "NZD", "JPY"
        };
        static string convertTo;
        static string toConvert;

        /*****************************************
        * Main()
        *****************************************/
        static void Main(string[] args)
        {
            GetCurrency();
        }

        /*****************************************
        * GetCurrency()
        *   Accepts and validates user input
        *   Creates an object of <T> Money
        *****************************************/
        public static void GetCurrency()
        {
            string userEntry;
            string digits;
            bool valid = true;

            currency.ForEach(Console.Write);
            Console.WriteLine("\n Please enter the amount and the type of currency to convert (1.00 USD): ");
            userEntry = Console.ReadLine();

            if (!userEntry.Contains("."))
            {
                Console.WriteLine("Please be sure that your amount is formatted like so: 0.00");
            }

            digits = string.Join("", userEntry.Where(char.IsDigit));
            valid = double.TryParse(digits, out amount);

            convertTo = string.Join("", userEntry.Where(char.IsLetter));
            
            if (!currency.Contains(convertTo))
            {
                Console.WriteLine($"{convertTo} is not an available currency.");
            }

            Console.WriteLine(amount + "\n " + convertTo);
        }
    }
}
