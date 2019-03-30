using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                {
                    Console.Write("Enter the Celsius temperature: ");
                    var fahrenheit = TemperatureConvertor.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", fahrenheit);
                    break;
                }
                case "2":
                {
                    Console.Write("Enter the Fahrenheit temperature: ");
                    var celsius = TemperatureConvertor.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", celsius);
                    break;
                }
            }
        }
    }
}
