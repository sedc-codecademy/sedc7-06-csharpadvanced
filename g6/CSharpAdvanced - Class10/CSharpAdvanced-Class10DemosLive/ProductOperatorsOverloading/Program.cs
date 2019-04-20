using System;

namespace ProductOperatorsOverloading
{
    class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public Product()
            {

            }

            public Product(string name, int quantity, double price)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
            }

            public static Product operator ++(Product product)
            {
                product.Quantity++;
                return product;
            }

            //public static Product operator+(Product product, int increment)
            //{

            //}

            public static bool operator > (Product p1, Product p2)
            {
                return p1.Price > p2.Price;
            }

            public static bool operator <(Product p1, Product p2)
            {
                return p1.Price < p2.Price;
            }
        }

        static void Main(string[] args)
        {
            var product1 = new Product("HDD", 10, 30.5);

            Console.WriteLine(product1.Quantity);

            product1++;

            Console.WriteLine(product1.Quantity);
        }
    }
}