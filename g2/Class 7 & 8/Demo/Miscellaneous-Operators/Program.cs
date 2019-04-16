using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Miscellaneous_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - Concat method appends two sequences of the same type and returns a
                new sequence (collection)
            - SequenceEqual method checks whether the number of elements, value of each element
                and order of elements in two collections are equal or not
            */
            #endregion

            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 94: Concat to create one sequence that contains each array's values, one after the other.
            int[] numsA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numsB = { 1, 3, 5, 7, 8 };
            #region Linq 94
            //var allNumbers = numsA.Concat(numsB);
            //Console.WriteLine("All numbers from both arrays:");
            //foreach (var n in allNumbers)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            //Linq 95: Concat to create one sequence that contains the names 
            //         of all customers and products, including any duplicates.
            #region Linq 95
            //var custNames = customers.Select(c => c.CompanyName);
            //var prodNames = products.Select(p => p.ProductName);
            //var allNames = custNames.Concat(prodNames);
            //foreach (var item in allNames)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //Linq 96: EqualAll to see if two sequences match on all elements in the same order.
            //         try to match A with B and A with C
            //var wordsA = new string[] { "cherry", "apple", "blueberry" };
            //var wordsB = new string[] { "cherry", "apple", "blueberry" };
            //var wordsC = new string[] { "cherry", "blueberry", "apple" };
            //#region Linq 96
            //bool match = wordsA.SequenceEqual(wordsB);
            //Console.WriteLine("The sequences A match B: {0}", match);
            //match = wordsA.SequenceEqual(wordsC);
            //Console.WriteLine("The sequences A match C: {0}", match);
            #endregion

            Console.ReadLine();
        }
    }
}
