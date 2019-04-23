using DataFromXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grouping_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Use LINQ Group By method to partition a list of numbers by their remainder when divided by 5
            //Both Lambda/SQL approach
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numberGroups = from n in numbers
                               group n by n % 5 into g
                               select new { Remainder = g.Key, Numbers = g };

            foreach (var g in numberGroups)
            {
                Console.Write("Numbers with a remainder of {0} when divided by 5: ", g.Remainder);
                foreach (var n in g.Numbers)
                    Console.Write(n + " ");
                Console.WriteLine();
            }

            var numberGroups2 = numbers
                                    .GroupBy(x => x % 5)
                                    .Select(y => new { Remainder = y.Key, Numbers = y });

            foreach (var g in numberGroups2)
            {
                Console.Write("Numbers with a remainder of {0} when divided by 5: ", g.Remainder);
                foreach (var n in g.Numbers)
                    Console.Write(n + " ");
                Console.WriteLine();
            }


            //Use LINQ Group By method to partition a list of words by their first letter
            //Both Lambda/SQL approach
            //Print the results with added ordering by the first letter
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            var wordGroups = words.GroupBy(g => g[0]).Select(w => new { FirstLetter = w.Key, Words = w });

            foreach (var g in wordGroups)
            {
                Console.Write("Words with first letter {0}:", g.FirstLetter);
                foreach (var word in g.Words)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }

            var wordGroups2 = from w in words
                              group w by w[0] into g
                              select new { FirstLetter = g.Key, Words = g };

            //printing with added ordering
            foreach (var g in wordGroups2.OrderBy(c => c.FirstLetter).Select(w => w))
            {
                Console.Write("Words with first letter {0}:", g.FirstLetter);
                foreach (var word in g.Words)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }
        }
    }
}