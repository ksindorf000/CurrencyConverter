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

        public Money(double _amount)
        {
            amount = _amount;
        }

        public virtual string Conversion()
        {
            return "Unable to convert.";
        }

    }
}
