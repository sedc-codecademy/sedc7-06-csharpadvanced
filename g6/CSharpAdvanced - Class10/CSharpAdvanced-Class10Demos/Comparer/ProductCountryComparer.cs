using System;
using System.Collections.Generic;

namespace Comparer
{
    public class ProductCountryComparer : IComparer<Product>
    {
        public int Compare(Product product1, Product product2)
        {
            if (product1.Country != null && product2.Country != null)
            {
                return String.CompareOrdinal(product1.Country, product2.Country);
            }

            return 0;
        }
    }
}
