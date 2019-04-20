using System.Collections.Generic;

namespace Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product("HDD", 100, 20.50,"Macedonia"),
                new Product("HDD", 10, 12.70,"Iraq"),
                new Product("CPU", 20, 11.50,"USA")
            };
        }
    }
}
