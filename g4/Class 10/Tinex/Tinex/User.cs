using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinex
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ProductType FavoriteType { get; set; }

        public void ReadPromotion(ProductType product)
        {
            Console.WriteLine($"Mr/Ms: {Name}, The product {product} is on sale");
            if (product == FavoriteType) Console.WriteLine("MY FAVORITE!");
        }
    }
}
