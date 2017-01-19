using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {

        /*****************************************
        * Main()
        *****************************************/
        static void Main(string[] args)
        {
            double amount = 100;

            Console.WriteLine("Conversions to USD: \n");
            ConvertToUSD(amount);

            Console.WriteLine("\nConversions to EUR: \n");
            ConvertToEUR(amount);

            Console.WriteLine("\nConversions to XBT: \n");
            ConvertToXBT(amount);

        }

        /*****************************************
        * ConvertToUSD()
        *****************************************/
        private static void ConvertToUSD(double amount)
        {
            string result;
            //USD to USD
            Money convertUSD = new USD(amount);
            result = convertUSD.ConvertFromUSD();
            Console.WriteLine(result + $" from {amount}USD");

            //EUR to USD
            Money convertEUR = new USD(amount);
            result = convertEUR.ConvertFromEUR();
            Console.WriteLine(result + $" from {amount}EUR");

            //GBP to USD
            Money convertGBP = new USD(amount);
            result = convertGBP.ConvertFromGBP();
            Console.WriteLine(result + $" from {amount}GBP");

            //AUD to USD
            Money convertJPY = new USD(amount);
            result = convertJPY.ConvertFromAUD();
            Console.WriteLine(result + $" from {amount}AUD");

            //XBT to USD
            Money convertXBT = new USD(amount);
            result = convertXBT.ConvertFromXBT();
            Console.WriteLine(result + $" from {amount}XBT");
        }

        /*****************************************
        * ConvertToEUR()
        *****************************************/
        private static void ConvertToEUR(double amount)
        {
            string result;
            //USD to EUR
            Money convertUSD = new USD(amount);
            result = convertUSD.ConvertFromUSD();
            Console.WriteLine(result + $" from {amount}USD");

            //EUR to EUR
            Money convertEUR = new USD(amount);
            result = convertEUR.ConvertFromEUR();
            Console.WriteLine(result + $" from {amount}EUR");

            //GBP to EUR
            Money convertGBP = new USD(amount);
            result = convertGBP.ConvertFromGBP();
            Console.WriteLine(result + $" from {amount}GBP");

            //AUD to EUR
            Money convertJPY = new USD(amount);
            result = convertJPY.ConvertFromAUD();
            Console.WriteLine(result + $" from {amount}AUD");

            //XBT to EUR
            Money convertXBT = new USD(amount);
            result = convertXBT.ConvertFromXBT();
            Console.WriteLine(result + $" from {amount}XBT");
        }

        /*****************************************
        * ConvertToXBT()
        *****************************************/
        private static void ConvertToXBT(double amount)
        {
            string result;
            //USD to XBT
            Money convertUSD = new XBT(amount);
            result = convertUSD.ConvertFromUSD();
            Console.WriteLine(result + $" from {amount}USD");

            //EUR to XBT
            Money convertEUR = new XBT(amount);
            result = convertEUR.ConvertFromEUR();
            Console.WriteLine(result + $" from {amount}EUR");

            //GBP to XBT
            Money convertGBP = new XBT(amount);
            result = convertGBP.ConvertFromGBP();
            Console.WriteLine(result + $" from {amount}GBP");

            //AUD to XBT
            Money convertJPY = new XBT(amount);
            result = convertJPY.ConvertFromAUD();
            Console.WriteLine(result + $" from {amount}AUD");

            //XBT to XBT
            Money convertXBT = new XBT(amount);
            result = convertXBT.ConvertFromXBT();
            Console.WriteLine(result + $" from {amount}XBT");
        }
    }
}
