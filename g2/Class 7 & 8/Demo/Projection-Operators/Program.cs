using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Projection_Operators
{
    class Program
    {
        class PetOwner
        {
            public string Name { get; set; }
            public List<string> Pets { get; set; }
        }

        static void Main(string[] args)
        {
            #region Info
            /*
            - Select operator always returns an IEnumerable collection which contains elements based on a transformation function
                similar to the Select clause of SQL that produces a flat result set
            */
            #endregion

            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 6: This sample uses select to produce a sequence of ints one higher 
            //        than those in an existing array of ints.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            #region Linq 6
            //var incrNumbers = numbers.Select(n => n + 1);
            //Console.WriteLine(string.Join(" ", incrNumbers));

            //var incrNumbers2 = (from n in numbers
            //                    select n + 1);
            //Console.WriteLine(string.Join(" ", incrNumbers2));
            #endregion

            //Linq 7: This sample uses select to return a sequence of just the names of a 
            //list of products
            #region Linq 7
            //var productNames = products.Select(p => p.ProductName);
            //foreach (var pn in productNames)
            //{
            //    Console.WriteLine(pn);
            //}
            #endregion

            //Linq 8: This sample uses select to produce a sequence of strings representing the text 
            //        version of a sequence of ints.
            //        Select the string representation (text) of the elements in numbers array 
            //        using strings array
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            #region Linq 8
            //var textNums = numbers.Select(n => strings[n]);
            //Console.WriteLine(string.Join(" ", textNums));
            #endregion

            //Select - Anonymous Types
            //Linq 9: This sample uses select to produce a sequence of the uppercase and lowercase 
            //        versions of each word in the original array
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            #region Linq 9
            //var upperLowerWords = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            //foreach (var ul in upperLowerWords)
            //{
            //    Console.WriteLine("Uppercase: {0}, Lowercaser: {1} ", ul.Upper, ul.Lower);
            //}
            #endregion

            //Select - Anonymous Types
            //Linq 10: This sample uses select to produce a sequence containing text representations 
            //         of digits and whether number is even or odd.
            #region Linq 10
            //var digitOddEvens = numbers.Select(n => new { Digit = strings[n], Even = (n % 2 == 0) });
            //foreach (var d in digitOddEvens)
            //{
            //    Console.WriteLine("The digit {0} is {1}", d.Digit, d.Even ? "even" : "odd");
            //}

            //var digitOddEvens2 = from n in numbers
            //                     select new { Digit = strings[n], Even = (n % 2 == 0) };
            //foreach (var d in digitOddEvens2)
            //{
            //    Console.WriteLine("The digit {0} is {1}", d.Digit, d.Even ? "even" : "odd");
            //}
            #endregion

            //Select - Anonymous Types
            //Linq 11: This sample uses select to produce a sequence containing some properties of
            //         Products, 
            //         including UnitPrice which is renamed to Price in the resulting type.
            #region Linq 11
            //var productInfos = products.Select(p => new { p.ProductName, p.CategoryID, Price = p.UnitPrice });
            //foreach (var pi in productInfos)
            //{
            //    Console.WriteLine($"{pi.ProductName} | {pi.CategoryID} | {pi.Price}");
            //}
            #endregion

            //Select - Indexed
            //Linq 12: This sample uses an indexed Select clause to determine if the value of
            //          ints in an array 
            //         match their position in the array.
            #region Linq 12
            var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });
            foreach (var n in numsInPlace)
            {
                Console.WriteLine("{0}: {1}", n.Num, n.InPlace);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
