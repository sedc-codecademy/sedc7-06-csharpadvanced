using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced_Class4
{
    public static class Extensions
    {
        public static string PriceWithCurrency(this double value, string currency)
        {
            return value + " " + currency;
        }
    }
}
