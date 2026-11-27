using System;
using System.Collections.Generic;
using System.Text;

namespace Pr33_Delegates
{
    public static class Bonuses
    {
        static double TenPercent(double amount)
        {
            return amount * 0.10;
        }

        static double FlatTwolfAmountMoreThanFive(double amount)
        {
            if (amount > 5)
                return 2.0;
            return 0.0;
        }
    }
}
