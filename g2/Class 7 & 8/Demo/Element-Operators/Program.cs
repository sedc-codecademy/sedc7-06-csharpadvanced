using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Element_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - First: Returns the first element of a collection, or the first element that satisfies a condition
            - FirstOrDefault: Returns the first element of a collection, or the first element that satisfies a condition
                Returns a default value if index is out of range
            - Last: Returns the last element of a collection, or the last element that satisfies a condition
            - LastOrDefault: Returns the last element of a collection, or the last element that satisfies a condition
                Returns a default value if no such element exists
            - Single: Returns the only element of a collection, or the only element that satisfies a condition
            - SingleOrDefault: Returns the only element of a collection, or the only element that satisfies a condition
                Returns a default value if no such element exists, throws an exception if there is more than one element
            - ElementAt: Returns the element at a specified index in a collection
            - ElementAtOrDefault: Returns the element at a specified index in a collection or a default value if the index is out of range
            */
            #endregion
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();
            
            Action line = () => Console.WriteLine();

            //Linq 58: This sample uses First to return the first matching element as a Product, 
            //         instead of as a sequence containing a Product.
            #region Linq 58
            //Product product12 = (from p in products
            //                     where p.ProductID == 12  //try with 122
            //                     select p).First();
            //product12.PrintProduct(product12);
            //line();
            //Product product12_2 = products.Where(p => p.ProductID == 12).First();
            //product12_2.PrintProduct(product12_2);
            #endregion

            //Linq 59: This sample uses Last to find the last element in the array that starts with 't'.
            #region Linq 59
            //string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //string startsWithT = strings.Last(s => s[0] == 't');
            //Console.WriteLine("Last string starting with 't': {0}", startsWithT);
            #endregion

            //Linq 60: find single product with ID
            #region Linq 60
            //var productByID = products.Single(p => p.ProductID == 2);
            //productByID.PrintProduct(productByID);
            //line();
            //var productByID2 = products.SingleOrDefault(p => p.ProductID == 222);
            //productByID2.PrintProduct(productByID2);
            #endregion

            //Linq 61: This sample uses FirstOrDefault to try to return the first element of the sequence, 
            //         unless there are no elements, in which case the default value for that type is returned.
            #region Linq 61
            //int[] numbers = { }; //empty array
            //int firstNumOrDefault = numbers.FirstOrDefault();
            //Console.WriteLine(firstNumOrDefault);
            #endregion

            //Linq 62: This sample uses FirstOrDefault to return the first product whose ProductID is 789 
            //         as a single Product object, unless there is no match, in which case null is returned.
            #region Linq 62
            //Product product789 = products.FirstOrDefault(p => p.ProductID == 789);
            //Console.WriteLine("Product 789 exists: {0}", product789 != null);
            #endregion

            //Linq 64: This sample uses ElementAt to retrieve the second number greater than 5 from an array.
            #region Linq 64
            //int[] numbers2 = { 5, 4, 1, 2, 3, 6, 8, 7, 9, 0 };
            //int secondGreaterThan5 = (from n in numbers2
            //                          where n > 5
            //                          select n
            //                          ).ElementAt(1);
            //Console.WriteLine("Second number > 5: {0}", secondGreaterThan5);
            //line();
            //int secondGreaterThenFive = numbers2.Where(n => n > 5).ElementAtOrDefault(111);
            //Console.WriteLine("Second number > 5: {0}", secondGreaterThenFive);
            #endregion

            Console.ReadLine();
        }
    }
}
