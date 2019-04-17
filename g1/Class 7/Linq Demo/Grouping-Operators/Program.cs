using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;
using DataFromXml.Models;
using DataFromXml.Services;

namespace Grouping_Operators {
    class Program {
        static void Main(string[] args) {
            //load all the products, customers, orders
            List<Product> products = ProductService.GetAllProducts();
            List<Customer> customers = CustomerService.GetAllCustomers();
            List<Order> orders = OrderService.GetAllOrders();

            //Linq 40: This sample uses group by to partition a list of numbers 
            //by their remainder when divided by 5.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //sql-like solution
            var numberGroups = from n in numbers
                               group n by n % 5 into g
                               select new { Remainder = g.Key, Numbers = g };

            foreach (var g in numberGroups) {
                Console.Write("Numbers with a remainder of {0} when divided by 5: ", g.Remainder);
                foreach (var n in g.Numbers) 
                    Console.Write(n+" "); 
                Console.WriteLine();
            }

            //lambda-like solution
            var numberGroups2 = numbers
                                    .GroupBy(x => x % 5)
                                    .Select(y => new { Remainder = y.Key, Numbers = y });

            foreach (var g in numberGroups2) {
                Console.Write("Numbers with a remainder of {0} when divided by 5: ", g.Remainder);
                foreach (var n in g.Numbers)
                    Console.Write(n + " ");
                Console.WriteLine();
            }


            //Linq 41: This sample uses group by to partition a list of words by their first letter.
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            //lambda-like solution:
            var wordGroups = words.GroupBy(g => g[0]).Select(w => new { FirstLetter = w.Key, Words = w });

            foreach (var g in wordGroups) {
                Console.Write("Words with first letter {0}:", g.FirstLetter);
                foreach (var word in g.Words) {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }

            //sql-like solution:
            var wordGroups2 = from w in words
                              group w by w[0] into g
                              select new { FirstLetter = g.Key, Words = g };

            //printing with added ordering
            foreach (var g in wordGroups2.OrderBy(c => c.FirstLetter).Select(w => w)){
                Console.Write("Words with first letter {0}:", g.FirstLetter);
                foreach (var word in g.Words) {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
