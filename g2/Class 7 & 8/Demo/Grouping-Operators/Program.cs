using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Grouping_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - GroupBy operator returns groups of elements based on some key value.
            Each group is represented by IGrouping<TKey, TElement> object
            - ToLookup is the same as GroupBy; the only difference is the execution of GroupBy
            is deferred whereas ToLookup execution is immediate
            */
            #endregion

            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            Action line = () => Console.WriteLine();

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Linq 39: This sample uses group by to partition a list of numbers 
            //         in two groups odd or even
            #region Linq 39
            //var groupsOddEven = from n in numbers
            //                   group n by n % 2;
            //foreach (var g in groupsOddEven)
            //{
            //    Console.Write("Numbers with a remainder of {0} when divided by 2: ", g.Key);
            //    foreach (var n in g)
            //    {
            //        Console.Write(n + " ");
            //    }
            //    Console.WriteLine();
            //}

            //line();

            //var groupsOddEven2 = numbers.GroupBy(x => x % 2);
            //foreach (var g in groupsOddEven2)
            //{
            //    Console.Write("Numbers with a remainder of {0} when divided by 2: ", g.Key);
            //    foreach (var n in g)
            //    {
            //        Console.Write(n + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            //Linq 40: This sample uses group by to partition a list of numbers 
            //         by their remainder when divided by 5.
            #region Linq 40
            //var numberGroups = from n in numbers
            //                   group n by n % 5 into g
            //                   select new { Remainder = g.Key, Numbers = g };
            //foreach (var g in numberGroups)
            //{
            //    Console.Write("Numbers with a remainder of {0} when divided by 5: ", g.Remainder);
            //    foreach (var n in g.Numbers)
            //        Console.Write(n + " ");
            //    Console.WriteLine();
            //}

            //line();

            //var numberGroups2 = numbers
            //                        .GroupBy(x => x % 5)
            //                        .Select(y => new { Remainder = y.Key, Numbers = y });
            //foreach (var g in numberGroups2)
            //{
            //    Console.Write("Numbers with a remainder of {0} when divided by 5: ", g.Remainder);
            //    foreach (var n in g.Numbers)
            //        Console.Write(n + " ");
            //    Console.WriteLine();
            //}
            #endregion

            //Linq 41: This sample uses group by to partition a list of words by their first letter.
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            #region Linq 41
            //var wordGroups = words.GroupBy(g => g[0]).Select(w => new { FirstLetter = w.Key, Words = w });
            //foreach (var g in wordGroups)
            //{
            //    Console.Write("Words with first letter {0}:", g.FirstLetter);
            //    foreach (var word in g.Words)
            //    {
            //        Console.Write(word + " ");
            //    }
            //    Console.WriteLine();
            //}

            //line();

            //var wordGroups2 = from w in words
            //                  group w by w[0] into g
            //                  select new { FirstLetter = g.Key, Words = g };
            ////printing with added ordering
            //foreach (var g in wordGroups2.OrderBy(c => c.FirstLetter).Select(w => w))
            //{
            //    Console.Write("Words with first letter {0}:", g.FirstLetter);
            //    foreach (var word in g.Words)
            //    {
            //        Console.Write(word + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
