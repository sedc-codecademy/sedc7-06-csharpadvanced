using System.Collections.Generic;

namespace Comparer
{
    public class ProductQuantityComparer : IComparer<Product>
    {
        public int Compare(Product product1, Product product2)
        {
            if (product1 != null && product2 != null)
            {
                return product1.Quantity - product2.Quantity;
            }

            return 0;
        }
    }
}
