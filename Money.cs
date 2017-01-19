using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Money
    {
        public double amount;
        public double rate;
        public string currency;
        public string symbol;
        public double result;
        public string formatResult;

        public Money(double _amount)
        {
            amount = _amount;
        }

        public virtual string ConvertFromUSD()
        {
            return "Unable to convert.";
        }

        public virtual string ConvertFromEUR()
        {
            return "Unable to convert.";
        }

        public virtual string ConvertFromGBP()
        {
            return "Unable to convert.";
        }

        public virtual string ConvertFromAUD()
        {
            return "Unable to convert.";
        }

        public virtual string ConvertFromXBT()
        {
            return "Unable to convert.";
        }

    }
}
