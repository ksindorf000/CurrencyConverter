using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class EUR : Money
    {
        public EUR(double _amount) : base(_amount)
        {
            amount = _amount;
            symbol = "€";
            currency = "EUR";

        }


        public override string ConvertFromUSD()
        {
            rate = 1.06576;
            result = amount / rate;
            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromEUR()
        {
            rate = 1;
            result = amount / rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromGBP()
        {
            rate = .086427;
            result = amount / rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromAUD()
        {
            rate = 1.4111;
            result = amount / rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromXBT()
        {
            rate = 848.419;
            result = amount * rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

    }
}
