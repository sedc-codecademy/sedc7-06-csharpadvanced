using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Quantifiers {
    class Program {
        static void Main(string[] args) {
            
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Any - simple:
            //Linq 67: This sample uses Any to determine if any of the words in the 
            //array contain the substring 'ei'.
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));
            Console.WriteLine("There is a word in the list that contains 'ei': {0}", iAfterE);

            //Any grouped:
            //Linq 69: This sample uses Any to return a grouped a list of products only for 
            //categories that have at least one product that is out of stock.

            var outOfStockProdGroups = 
                products.GroupBy(g => g.CategoryID)
                    .Select(g => new { Category = g.Key, Products = g })
                    .Where(g => g.Products.Any(p => p.UnitsInStock == 0));

            foreach (var g in outOfStockProdGroups.OrderBy(p=>p.Category)) {
                Console.Write(g.Category + ": ");
                foreach (var p in g.Products) {
                    Console.Write(p.ProductName + " ");
                }
                Console.WriteLine();
            }


            //Linq 70: This sample uses All to determine whether an array contains only odd numbers.
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
            bool onlyOdd = numbers.All(n => n % 2 == 1);
            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);

            Action line = () => Console.WriteLine();
            line();
            var inStockProdGroups =
                products.GroupBy(g => g.CategoryID)
                    .Select(g => new { Category = g.Key, Products = g })
                    .Where(g => g.Products.All(p => p.UnitsInStock > 0));

            foreach (var g in inStockProdGroups.OrderBy(p => p.Category)) {
                Console.Write(g.Category + ": ");
                foreach (var p in g.Products) {
                    Console.Write(p.ProductName + " ");
                }
                Console.WriteLine();
            }

            //Make an analyzis for the differences between Any() and All()

        }
    }
}
