using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Ordering_Operators {
    class Program {

        public class CaseInsensitiveComparer : IComparer<string> {
            public int Compare(string x, string y) {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
                //OrdinalIgnoreCase is for using binary sort
            }
        }

        static void Main(string[] args) {
            
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 28: sort a list of words alphabetically; OrderBy()
            string[] words = { "cherry", "apple", "blueberry" }; 

            //Linq 30: sort a list of products by name
            var sortedProducts = products.OrderBy(p => p.ProductName);
            //Product.PrintProducts(sortedProducts);

            //Linq 31: OrderBy clause with a custom comparer to do a case-insensitive sort 
            //of the words in an array.
            string[] words2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords2 = words2.OrderBy(str => str, new CaseInsensitiveComparer());
            Console.WriteLine("Sorted 2: {0}", string.Join(" ", sortedWords2));

            //Linq 35: This sample uses a compound orderby to sort a list of digits, first by length 
            //of their name, and then alphabetically by the name itself.
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);
            foreach (var d in sortedDigits) {
                Console.WriteLine(d);
            }

            //Linq 36: This sample uses an OrderBy and a ThenBy clause with a custom comparer to 
            //sort first by word length and then by a case-insensitive sort of the words in an array.
            var sortedWords3 = words2.OrderBy(a => a.Length).ThenBy(a => a, new CaseInsensitiveComparer());
            Console.WriteLine("Sorted 3: {0}", string.Join(" ", sortedWords3));

            //Linq 37: compound orderby to sort a list of products, first by category, 
            //and then by unit price, from highest to lowest.
            var sortedProducts2 = products.OrderBy(p => p.CategoryID).ThenByDescending(p => p.UnitPrice);
            //Product.PrintProducts(sortedProducts2);

            //...words2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Linq 38: This sample uses an OrderBy and a ThenBy clause with a custom comparer to sort first 
            //by word length and then by a case-insensitive descending sort of the words in an array.
            var sortedWords4 = words2.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());
            Console.WriteLine("Sorted 4: {0}", string.Join(" ", sortedWords4));

            //Linq 39: Reverse the elements of the sub-list of list "digits" 
            //that have the second character as 'i';
            var reversedDigits = digits.Where(d => d[1] == 'i').Reverse();
            foreach (var item in reversedDigits) {
                Console.WriteLine(item);
            }

        }
        
    }
}
