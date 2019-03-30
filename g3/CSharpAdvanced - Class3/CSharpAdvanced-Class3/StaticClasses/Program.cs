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
    public static class GallonsToLiters
    {
        //3.78541178
        public static double GallonToLiter(double gallon)
        {
            return gallon * 3.7854;
        }
        public static double LiterToGallon(double liter)
        {
            return liter / 3.7854;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double galoni = 10;
            Console.WriteLine("{0} galoni = {1} litri",
                galoni,GallonsToLiters.GallonToLiter(galoni));
            double litri = 5.5;
            Console.WriteLine("{0} litri = {1} galoni",
                litri, GallonsToLiters.LiterToGallon(litri));

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
            //  }
        }
    }
}
