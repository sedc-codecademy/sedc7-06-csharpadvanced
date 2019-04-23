using DataFromXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordering_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            // Sort a list of words alphabetically and print the result using Join method
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = words.OrderBy(w => w);
            Console.WriteLine("Sorted: {0}", string.Join(" ", sortedWords));

            //Use LINQ Order By method to sort a list of digits, first by length of their name, and then alphabetically by the name itself
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);
            foreach (var d in sortedDigits)
            {
                Console.WriteLine(d);
            }

            //Use LINQ Order By method to sort a list of products, first by category and then by unit price, from highest to lowest.
            var sortedProducts2 = products.OrderBy(p => p.CategoryID).ThenByDescending(p => p.UnitPrice);
            Product.PrintProducts(sortedProducts2);
        }
    }
}