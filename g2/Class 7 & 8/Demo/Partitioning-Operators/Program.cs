using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Partitioning_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - Take() extension method returns the specified number of elements starting from the first element
            - TakeWhile() extension method returns elements from the given collection until the specified condition is true
            - Skip() skips the specified number of element starting from first element and returns rest of the elements
            - SkipWhile() skips elements in the collection till the specified condition is true
            */
            #endregion

            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            Action line = () => Console.WriteLine();

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Linq 20: get only the first 3 elements of the array.
            #region Linq 20
            //var first3Nums = numbers.Take(3);
            //Console.WriteLine("First 3 elements: {0}", string.Join(" ", first3Nums));
            #endregion

            //Linq 21: get the first 3 orders from customers in London.
            #region Linq 21
            //var first3LondonCustomers = customers.Where(c => c.City == "London").Take(3);
            //Customer.PrintCustomers(first3LondonCustomers);
            //line();
            //var first3LondonCustomers2 = (from c in customers
            //                         where c.City == "London"
            //                         select c
            //                             ).Take(3);
            //Customer.PrintCustomers(first3LondonCustomers2);
            #endregion

            //Linq 22: get all but the first 4 elements of the array.
            #region Linq 22
            //var allButFirst4Nums = numbers.Skip(4);
            //Console.WriteLine("all without first four: {0}", string.Join(" ", allButFirst4Nums));
            #endregion

            //Linq 23: get all but the first 1 from customers in 'Rio de Janeiro'
            #region Linq 23
            //var allButFirstOneRio = customers.Where(c => c.City == "Rio de Janeiro").Skip(1);
            //Customer.PrintCustomers(allButFirstOneRio);
            #endregion

            //Linq 24: TakeWhile to return elements starting from the beginning of the array 
            //         until a number is hit that is not less than 6.
            #region Linq 24
            //var firstNumsLessThan6 = numbers.TakeWhile(n => n < 6);
            //Console.WriteLine("First less than 6: {0}", string.Join(" ", firstNumsLessThan6));
            #endregion

            //Linq 25: TakeWhile to return elements starting from the beginning of the array until 
            //         a number is hit that is less than its position in the array.
            #region Linq 25
            //var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
            //Console.WriteLine("First numbers not less than their position: {0}", string.Join(" ", firstSmallNumbers));
            #endregion

            //Linq 26: SkipWhile to get the elements of the array starting from the first 
            //         element divisible by 3.
            //         { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }
            #region Linq 26
            //var skipNotDivisibleBy3 = numbers.SkipWhile(n => n % 3 != 0);
            //Console.WriteLine("Skip all numbers not divisible by 3: {0}", string.Join(" ", skipNotDivisibleBy3));
            #endregion

            //Linq 27: SkipWhile to get the elements of the array starting from the first element less 
            //         than its position.
            #region Linq 27
            //var laterNumbers = numbers.SkipWhile((n, index) => n >= index);
            //Console.WriteLine("Skip first numbers greater then their position: {0}", string.Join(" ", laterNumbers));
            #endregion

            Console.ReadLine();
        }
    }
}
