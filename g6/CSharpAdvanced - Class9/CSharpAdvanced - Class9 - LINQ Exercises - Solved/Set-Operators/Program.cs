﻿using DataFromXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Set_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            void line() => Console.WriteLine();

            //Linq 46:
            //Remove duplicate elements in a sequence of factors of 300.
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            var uniqueFactors = factorsOf300.Distinct();
            Console.WriteLine("Prime factors of 300:");
            foreach (var f in uniqueFactors)
            {
                Console.WriteLine(f);
            }
            line();
            Console.WriteLine("---------");

            //Find the unique Category IDs.
            var categoryIDs = products.Select(p => p.CategoryID).OrderBy(c => c).Distinct();
            foreach (var item in categoryIDs)
            {
                Console.WriteLine(item);
            }

            line();

            //Using LINQ Union method Create one sequence that contains the unique values from both arrays
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var uniqueNumbers = numbersA.Union(numbersB);

            Console.WriteLine("Unique numbers from both arrays:");
            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }

            line();

            //Create one sequence that contains the unique first letter 
            //from both product and customer names.
            var prodFirstChars = products.Select(p => p.ProductName[0]);
            var custFirstChars = customers.Select(c => c.CompanyName[0]);
            var uniqueFirstLetters = prodFirstChars.Union(custFirstChars);
            foreach (var item in uniqueFirstLetters)
            {
                Console.WriteLine(item);
            }
            line();
            Console.WriteLine("-----------------");

            //Using LINQ Intersect method to create one sequence that contains the common first letter 
            //from both Product and Customer names.
            var commontFirstChars = prodFirstChars.Intersect(custFirstChars);
            foreach (var item in commontFirstChars)
            {
                Console.WriteLine(item);
            }
            line();

            //Try to understand Intersect/Except in action
            //Intersect to create one sequence that contains the common values shared by both arrays.
            Console.WriteLine("----------------");
            int[] A = { 0, 2, 4, 5, 6, 8, 9 };
            int[] B = { 1, 3, 5, 7, 8 };
            var commonNumbers = A.Intersect(B);
            Console.WriteLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
            {
                Console.WriteLine(n);
            }
            line();
            Console.WriteLine("----------------");
            //Except to create a sequence that contains the values from numbers A that 
            //are not also in numbers B
            var exceptNumbers = A.Except(B);
            foreach (var n in exceptNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}