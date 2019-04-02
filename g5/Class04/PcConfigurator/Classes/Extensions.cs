using CSharpAdvanced_Class4.Interfaces;
using System.Globalization;

namespace CSharpAdvanced_Class4
{
    public static class Extensions
    {
        public static string WithCurrency(this double value, string currency)
        {
            return $"{value:N2}{currency}";
        }

        public static string PriceWithCurrency (this IPrice priced, string currency)
        {
            return priced.GetTotalPrice().WithCurrency(currency);
        }
    }
}
