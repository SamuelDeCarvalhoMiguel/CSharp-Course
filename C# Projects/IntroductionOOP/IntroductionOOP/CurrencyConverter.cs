using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOOP
{
    internal class CurrencyConverter
    {

        public static double Iof = 6.0;

        public static double DollarToReal (double price, double amountBought)
        {
            double total = price * amountBought;
            return total + total * Iof / 100;
        }

    }
}
