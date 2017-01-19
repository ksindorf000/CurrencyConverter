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

    }
}
