using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class XBT : Money
    {
        public XBT(double _amount) : base(_amount)
        {
            amount = _amount;
            symbol = "฿";
            currency = "XBT";

        }


        public override string ConvertFromUSD()
        {
            rate = .00111;
            result = amount * rate;
            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromEUR()
        {
            rate = .00118;
            result = amount * rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromGBP()
        {
            rate = .00136;
            result = amount * rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromAUD()
        {
            rate = .00084;
            result = amount * rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromXBT()
        {
            rate = 1;
            result = amount * rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

    }
}
