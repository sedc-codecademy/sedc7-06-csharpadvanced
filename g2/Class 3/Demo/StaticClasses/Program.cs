using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class TemperatureConvertor
    {
        public static double CelsiusToFarenheit(string C)
        {
            double celsius = double.Parse(C);
            double farenheit = (celsius * 1.8) + 32;
            return farenheit;
        }
        public static double FarenheitToCelsius(string F)
        {
            double fareheit = double.Parse(F);
            double celsius = (fareheit - 32) / 1.8;
            return celsius;
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public static int count = 0;
        public static int Count()
        {
            return count;
        }
        public Cat()
        {
            Console.WriteLine("Unnamed cat");
            count++;
        }

        public Cat(string name) : this()
        {
            Console.WriteLine($"Named cat: {name}");
            this.Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Static classes
            //Console.WriteLine("--------------- TemperatureConvertor ---------------");

            //Console.WriteLine("Select the convertor direction");
            //Console.WriteLine("1. From Celsius to Fahrenheit.");
            //Console.WriteLine("2. From Fahrenheit to Celsius.");

            //string selection = Console.ReadLine();
            //double F, C = 0;
            //switch (selection)
            //{
            //    case "1":
            //        Console.Write("Enter the Celsius temperature: ");
            //        F = TemperatureConvertor.CelsiusToFarenheit(Console.ReadLine());
            //        Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
            //        break;
            //    case "2":
            //        Console.Write("Enter the Farenheit temperature: ");
            //        C = TemperatureConvertor.FarenheitToCelsius(Console.ReadLine());
            //        Console.WriteLine("Temperature in Celsius: {0:F2}", C);
            //        break;
            //}

            #endregion

            #region Static Methods
            //Console.WriteLine("--------------- Instance Count ---------------");

            //Cat catTom = new Cat();
            //Cat catGarfield = new Cat("Garfield");
            //Console.WriteLine($"Created cats count: {Cat.Count()}");

            #endregion

            Console.ReadLine();
        }
    }
}
