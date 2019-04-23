﻿using System;

namespace Exceptions1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 100;
            int divisor = 0;
            int calculated;

            // We are trying to divide with zero. If we didn't had a try/catch block here
            // our application will crash and thats something we want to avoid. Users of our 
            // application need to see some frendly message when something unexpected happens
            // instead of some error that doesn't tell much.
            try
            {
                calculated = num / divisor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during division.");
                Console.WriteLine("Message: {0}\n", ex.Message);
                Console.WriteLine("Source: {0}\n", ex.Source);
                Console.WriteLine("Target site: {0}\n", ex.TargetSite);
                Console.WriteLine("Stack trace: {0}\n", ex.StackTrace);

                calculated = int.MaxValue;
            }

            Console.WriteLine("Result = {0}", calculated);

            try
            {
                calculated = num / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero occurred.");
                Console.WriteLine("Message: {0}\n", ex.Message);
                calculated = int.MaxValue;
            }
            finally
            {
                Console.WriteLine("Clearing up any resources. Closing connections to database, etc...");
            }
            Console.WriteLine("Result = {0}", calculated);
        }
    }
}