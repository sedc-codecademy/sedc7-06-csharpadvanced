using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Miscellaneous_Operators {
    class Program {
        static void Main(string[] args) {
            
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 94: oncat to create one sequence that contains each array's values, one after the other.
            int[] numsA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numsB = { 1, 3, 5, 7, 8 };

            var allNumbers = numsA.Concat(numsB);
            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers) {
                Console.WriteLine(n);
            }

            //Linq 95: Concat to create one sequence that contains the names 
            //of all customers and products, including any duplicates.
            var custNames = customers.Select(c => c.CompanyName);
            var prodNames = products.Select(p => p.ProductName);

            var allNames = custNames.Concat(prodNames);
            //foreach (var item in allNames) {
            //    Console.WriteLine(item);
            //}

            //Linq 96: EqualAll to see if two sequences match on all elements in the same order.
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };
            bool match = wordsA.SequenceEqual(wordsB);
            Console.WriteLine("The sequences match: {0}", match);

            //Linq 97: EqualAll to see if two sequences match on all elements in the same order.
            wordsB = new string[] { "cherry", "blueberry", "apple" };
            match = wordsA.SequenceEqual(wordsB);
            Console.WriteLine("The sequences match: {0}", match);

        }
    }
}
