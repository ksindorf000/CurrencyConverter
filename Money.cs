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

        public Money(double _amount, string _currency)
        {
            amount = _amount;
            currency = _currency;
        }

        public virtual string Conversion(string convertTo)
        {
            rate = 0;
            symbol = "$";
            result = amount * rate;
            return $"{symbol} {result}";
        }
        
    }
}
