using DataFromXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Miscellaneous_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Using LINQ Concat method create one sequence that contains each array's values, one after the other.
            int[] numsA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numsB = { 1, 3, 5, 7, 8 };

            var allNumbers = numsA.Concat(numsB);
            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }

            // Concat to create one sequence that contains the names of all customers and products, including any duplicates.
            var custNames = customers.Select(c => c.CompanyName);
            var prodNames = products.Select(p => p.ProductName);

            var allNames = custNames.Concat(prodNames);
            foreach (var item in allNames)
            {
                Console.WriteLine(item);
            }

            //Using LINQ Sequence Equal method check if two sequences match on all elements in the same order.
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };

            bool match = wordsA.SequenceEqual(wordsB);
            Console.WriteLine("The sequences match: {0}", match);
        }
    }
}