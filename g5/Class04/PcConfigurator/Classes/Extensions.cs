using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public static class Extensions
    {
        public static string WithCurrency(this double value, string currency)
        {
            return $"{value:0,0.00}{currency}";
        }

        public static string PriceWithCurrency (this IPrice priced, string currency)
        {
            return string.Empty;
        }
    }
}
