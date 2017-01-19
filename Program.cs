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
            bool valid = true;

            while (valid)
            {
                GetInput();
                GetConvertTo();
            }
        }

        /***********************************************************************
        * GetInput()
        *   Accepts and validates user input for currency types & amount 
        ***********************************************************************/
        public static void GetInput()
        {
            string userEntry;
            string digits;
            bool valid = false;

            while (!valid)
            {
                //Check for all components of valid entry (decimal point, letters, digits)
                Console.WriteLine("\n Please enter the amount and the type of currency to convert (1.00 USD): ");
                userEntry = Console.ReadLine().ToUpper();

                if (!userEntry.Contains("."))
                {
                    Console.WriteLine("Please be sure that your amount is formatted like so: 0.00");
                    valid = false;
                }
                else if (!userEntry.Any(char.IsLetter))
                {
                    Console.WriteLine("Please be sure that you have entered a valid currency type (USD).");
                    valid = false;
                }
                else if (!userEntry.Any(char.IsDigit))
                {
                    Console.WriteLine("Please be sure that you have entered a valid amount (1.00)." +
                        "Do not include the currency symbol ($).");
                    valid = false;
                }
                else
                {
                    digits = string.Join("", userEntry.Where(char.IsDigit));
                    valid = double.TryParse(digits, out amount);
                    toConvert = string.Join("", userEntry.Where(char.IsLetter));
                    valid = ValidateCurencyType(toConvert);
                }
            }
        }

        /**********************************************************************************
        * GetConvertTo()
        *   Gets currency to be converted to
        **********************************************************************************/
        private static void GetConvertTo()
        {
            bool valid = false;

            Console.Clear();

            while (!valid)
            {
                Console.WriteLine($"Amount: {amount} Currency Type to Convert: {toConvert} \n");
                Console.WriteLine("Please enter the currency type you would like to convert to: ");
                convertTo = Console.ReadLine().ToUpper();
                valid = ValidateCurencyType(convertTo);
            }
        }

        /**********************************************************************************
        * ValidateCurrencyType()
        *   Validates currency type and creates object of type Money
        **********************************************************************************/
        private static bool ValidateCurencyType(string currencyType)
        {
            bool valid;

            if (!currency.Contains(currencyType))
            {
                Console.WriteLine($"{currencyType} is not an available currency.");
                valid = false;
            }
            else
            {
                Console.WriteLine(amount + "\n " + currencyType);
                valid = true;
            }
            return valid;
        }

        /**********************************************************************************
        * CreateObject()
        *   Creates object of correct type
        **********************************************************************************/
        private static void CreateObject(string currencyType)
        {
            if (currencyType == "USD")
            {
                var usd = new USD(amount, currencyType);
            }
        }

    }
}
