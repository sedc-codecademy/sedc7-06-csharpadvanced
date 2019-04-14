using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Ordering_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - OrderBy Sorts the elements in the collection based on specified fields in ascending or decending order
            - OrderByDescending	Sorts the collection based on specified fields in descending order. Only valid in method syntax
            - ThenBy Only valid in method syntax. Used for second level sorting in ascending order
            - ThenByDescending Only valid in method syntax. Used for second level sorting in descending order
            - Reverse Only valid in method syntax. Sorts the collection in reverse order
            */
            #endregion

            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 28: sort a list of words alphabetically
            #region Linq 28
            //string[] words = { "cherry", "apple", "blueberry" };
            //var sortedWords = words.OrderBy(w => w);
            //Console.WriteLine("Sorted: {0}", string.Join(" ", sortedWords));
            #endregion

            //Linq 30: sort a list of products by name
            #region Linq 30
            //var sortedProducts = products.OrderBy(p => p.ProductName);
            //Product.PrintProducts(sortedProducts);
            #endregion

            string[] words2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Linq 31: OrderBy clause with a custom comparer to do a case-insensitive sort 
            //         of the words in an array.
            #region linq 31
            //var sortedWords2 = words2.OrderBy(str => str, new CaseInsensitiveComparer());
            //Console.WriteLine("Sorted 2: {0}", string.Join(" ", sortedWords2));
            #endregion

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //Linq 35: This sample uses a compound orderby to sort a list of digits, first by length 
            //         of their name, and then alphabetically by the name itself.
            #region Linq 35
            //var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);
            //foreach (var d in sortedDigits)
            //{
            //    Console.WriteLine(d);
            //}
            #endregion

            //Linq 36: This sample uses an OrderBy and a ThenBy clause with a custom comparer to 
            //         sort first by word length and then by a case-insensitive sort of the words in an array.
            #region Linq 36
            //var sortedWords3 = words2.OrderBy(a => a.Length).ThenBy(a => a, new CaseInsensitiveComparer());
            //Console.WriteLine("Sorted 3: {0}", string.Join(" ", sortedWords3));
            #endregion

            //Linq 37: Compound orderby to sort a list of products, first by category, 
            //         and then by unit price, from highest to lowest.
            #region Linq 37
            //var sortedProducts2 = products.OrderBy(p => p.CategoryID).ThenByDescending(p => p.UnitPrice);
            //Product.PrintProducts(sortedProducts2);
            #endregion

            //...words2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Linq 38: This sample uses an OrderBy and a ThenBy clause with a custom comparer to sort first 
            //         by word length and then by a case-insensitive descending sort of the words in an array
            #region Linq 38
            //var sortedWords4 = words2.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());
            //Console.WriteLine("Sorted 4: {0}", string.Join(" ", sortedWords4));
            #endregion

            //Linq 39: Reverse the elements of the sub-list of list "digits" 
            //         that have the second character as 'i';
            #region Linq 39
            //var reversedDigits = digits.Where(d => d[1] == 'i').Reverse();
            //foreach (var item in reversedDigits)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            Console.ReadLine();
        }

        public class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
                //OrdinalIgnoreCase is for using binary sort
            }
        }
    }
}
