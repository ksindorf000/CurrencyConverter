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
        static string convertTo = "USD";
        static string toConvert;
        static string userEntry;

        /*****************************************
        * Main()
        *****************************************/
        static void Main(string[] args)
        {
            //string result;

            //Money convertTo = new USD(100);
            //result = convertTo.ConvertFromEUR();
            //Console.WriteLine(result);

            
            bool valid = true;

            while (valid)
            {
                GetInput();
                //GetConvertTo();
                Console.WriteLine($"Amount: {amount} Currency Type to Convert: {toConvert} \n");
                Conversion(toConvert);
                Console.ReadLine();
                Console.Clear();
            }
        }

        /***********************************************************************
        * GetInput()
        *   Accepts and validates user input for currency types & amount 
        ***********************************************************************/
        public static void GetInput()
        {
            bool valid = false;

            while (!valid)
            {
                //Check for all components of valid entry (decimal point, letters, digits)
                Console.WriteLine("\n Please enter the amount and the type of currency to convert (1.00 USD): ");
                userEntry = Console.ReadLine().ToUpper();

                if (!userEntry.Contains(".") || !userEntry.Any(char.IsDigit))
                {
                    Console.WriteLine("Please be sure that your amount is formatted like so: 0.00");
                    valid = false;
                }
                else
                {
                    AmountFromString(userEntry);
                    valid = true;
                }

                if (!userEntry.Any(char.IsLetter))
                {
                    Console.WriteLine("Please be sure that you have entered a valid currency type (USD).");
                    valid = false;
                }
                else
                {
                    toConvert = string.Join("", userEntry.Where(char.IsLetter));
                    valid = ValidateCurencyType(toConvert);
                }

            }
        }

        /**********************************************************************************
        * AmountFromString()
        *   Creates the amount from the userEntry string
        **********************************************************************************/
        private static void AmountFromString(string userEntry)
        {
            var sb = new StringBuilder();

            foreach (var c in userEntry.Where(c => c == '.' || Char.IsDigit(c)))
            {
                sb.Append(c);
            }

            amount = Convert.ToDouble(sb.ToString());
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
                valid = true;
            }
            return valid;
        }

        /**********************************************************************************
        * Conversion()
        *   Creates object of correct type and converts currency
        **********************************************************************************/
        private static void Conversion(string toConvert, string convertTo)
        {
            if (toConvert == "USD")
            {
                Money usd = new USD(amount);
                usd.Conversion(convertTo);
            }
            else if (toConvert == "EUR")
            {
                Money eur = new EUR(amount);
                eur.Conversion(convertTo);
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
    }
}
