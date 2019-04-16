using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Set_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - Distinct Returns distinct values from a collection
            - Except Returns the difference between two sequences, which means the elements of one collection that do not appear
                in the second collection
            - Intersect Returns the intersection of two sequences, which means elements that appear in both the collections
            - Union Returns unique elements from two sequences, which means unique elements that appear in either of the two sequences
            */
            #endregion

            //load all the products, customer, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            void line() => Console.WriteLine();

            //Linq 46: This sample uses Distinct to remove duplicate elements in a sequence of factors of 300
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            #region Linq 46
            //var uniqueFactors = factorsOf300.Distinct();
            //Console.WriteLine("Prime factors of 300:");
            //foreach (var f in uniqueFactors)
            //{
            //    Console.WriteLine(f);
            //}
            //line();
            #endregion

            //Linq 47:Distinct to find the unique Category IDs.
            #region Linq 47
            //var categoryIDs = products.Select(p => p.CategoryID).OrderBy(c => c).Distinct();
            //foreach (var item in categoryIDs)
            //{
            //    Console.WriteLine(item);
            //}
            //line();
            #endregion

            //Linq 48: Union to create one sequence that contains the unique values from both arrays.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            #region Linq 48
            //var uniqueNumbers = numbersA.Union(numbersB);
            //Console.WriteLine("Unique numbers from both arrays:");
            //foreach (var n in uniqueNumbers)
            //{
            //    Console.WriteLine(n);
            //}
            //line();
            #endregion

            //Linq 49: Union to create one sequence that contains the unique first letter 
            //         from both product and customer names.
            #region Linq 49
            //var prodFirstChars = products.Select(p => p.ProductName[0]);
            //var custFirstChars = customers.Select(c => c.CompanyName[0]);
            //var uniqueFirstLetters = prodFirstChars.Union(custFirstChars);
            //foreach (var item in uniqueFirstLetters)
            //{
            //    Console.WriteLine(item);
            //}
            //line();
            #endregion

            //Linq 50: Intersect to create one sequence that contains the common values shared by both arrays.
            int[] A = { 0, 2, 4, 5, 6, 8, 9 };
            int[] B = { 1, 3, 5, 7, 8 };
            #region Linq 50
            //var commonNumbers = A.Intersect(B);
            //Console.WriteLine("Common numbers shared by both arrays:");
            //foreach (var n in commonNumbers)
            //{
            //    Console.WriteLine(n);
            //}
            //line();
            #endregion

            //Linq 51: Intersect to create one sequence that contains the common first letter 
            //         from both product and customer names.
            #region Linq 51
            //var prodFirstChars = products.Select(p => p.ProductName[0]);
            //var custFirstChars = customers.Select(c => c.CompanyName[0]);
            //var commontFirstChars = prodFirstChars.Intersect(custFirstChars);
            //foreach (var item in commontFirstChars)
            //{
            //    Console.WriteLine(item);
            //}
            //line();
            #endregion

            //Linq 52: Except to create a sequence that contains the values from numbers A that 
            //         are not also in numbers B.
            #region Linq 52
            //var exceptNumbers = A.Except(B);
            //foreach (var n in exceptNumbers)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            Console.ReadLine();
        }

    }
}
