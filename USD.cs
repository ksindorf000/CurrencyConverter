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

        public override string Conversion()
        {
            rate = 0.94038;
            result = amount / rate;

            return $"{symbol}{result} {currency}";
        }


    }
}