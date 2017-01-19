namespace CurrencyConverter
{
    internal class USD : Money
    {
        public USD(double _amount, string _currency) : base(_amount, _currency)
        {
            symbol = "$";
        }

        public override string Conversion(string toConvert)
        {
            if (toConvert == "EUR")
            {
                rate = .94125;
            }


            result = amount * rate;

            return $"{result} {currency}";
        }

    }
}