﻿using System;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class USD : Money
    {
        public USD(double _amount) : base(_amount)
        {
            symbol = "$";
            amount = _amount;
            currency = "USD";
        }

        public override string ConvertFromUSD()
        {
            result = amount * 1;
            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromEUR()
        {
            rate = 0.94038;
            result = amount / rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromGBP()
        {
            rate = 0.81067;
            result = amount / rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromAUD()
        {
            rate = 1.32371;
            result = amount / rate;

            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

        public override string ConvertFromXBT()
        {
            rate = 904.341;
            result = amount * rate;
            formatResult = result.ToString("N2");

            return $"{symbol}{formatResult} {currency}";
        }

    }
}