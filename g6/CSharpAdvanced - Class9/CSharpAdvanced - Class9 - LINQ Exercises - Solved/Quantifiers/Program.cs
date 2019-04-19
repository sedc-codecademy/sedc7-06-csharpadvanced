using DataFromXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Any grouped
            //Use LINQ to return a grouped a list of products only for 
            //categories that have at least one product that is out of stock.
            //Both Lambda/SQL approach
            var outOfStockProdGroups =
                products.GroupBy(g => g.CategoryID)
                    .Select(g => new { Category = g.Key, Products = g })
                    .Where(g => g.Products.Any(p => p.UnitsInStock == 0));

            foreach (var g in outOfStockProdGroups.OrderBy(p => p.Category))
            {
                Console.Write(g.Category + ": ");
                foreach (var p in g.Products)
                {
                    Console.Write(p.ProductName + " ");
                }
                Console.WriteLine();
            }

            Action line = () => Console.WriteLine();
            line();
            var inStockProdGroups =
                products.GroupBy(g => g.CategoryID)
                    .Select(g => new { Category = g.Key, Products = g })
                    .Where(g => g.Products.All(p => p.UnitsInStock > 0));

            foreach (var g in inStockProdGroups.OrderBy(p => p.Category))
            {
                Console.Write(g.Category + ": ");
                foreach (var p in g.Products)
                {
                    Console.Write(p.ProductName + " ");
                }
                Console.WriteLine();
            }

            //Make an analyzis for the differences between Any() and All()
        }
    }
}