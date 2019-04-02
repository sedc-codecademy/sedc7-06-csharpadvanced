using System;

namespace StaticClasses
{
    /// <summary>
    /// Static class is basically the same as a non-static class, but there is one difference: 
    /// A static class CANNOT be instantiated. In other words, you caannot use the new keyword
    /// to create a variable of the class type.Because there is no instance variable, you access
    /// the members of a static class by using the class name itself. 
    /// If static keyword is applied to a class, all the members of the class must be static..
    /// </summary>
    public static class TemperatureConvertor
    {
        /// <summary>
        ///  Method for converting celsius to farenheit
        ///  Since this is a static method, we call this 
        ///  method with className.methodName  => TemperatureConvertor.CelsiusToFahrenheit(10) 
        /// </summary>
        /// <param name="C"></param>
        /// <returns></returns>
        public static double CelsiusToFarenheit(string C)
        {
            double celsius = double.Parse(C);
            double farenheit = (celsius * 1.8) + 32;
            return farenheit;
        }

        /// <summary>
        ///  Method for converting farenheit to celsius
        ///  Since this is a static method, we call this 
        ///  method with className.methodName  => TemperatureConvertor.FarenheitToCelsius(10) 
        /// </summary>
        /// <param name="F"></param>
        /// <returns></returns>
        public static double FarenheitToCelsius(string F)
        {
            double fareheit = double.Parse(F);
            double celsius = (fareheit - 32) / 1.8;
            return celsius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // We ask for user input, choose which conversion you want
            // if the user press 1 we are doing conversion from celsius to fahrenheit
            // if user press 2, we are doing conversion from fahrenheit to celsius
            // and base of user input we are calling the corresonding static method
            // for conversion and just print the conversion on the console..
            // TODO : For excercise here you can implement validation, what if user enters other value
            // TODO : different from 1 and 2 ? We need to validate that input and return message that
            // TODO : input is invalid...

            Console.WriteLine("Select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");

            string selection = Console.ReadLine();
            double F, C = 0;
            switch (selection)
            {
                case "1":
                    Console.Write("Enter the Celsius temperature: ");
                    F = TemperatureConvertor.CelsiusToFarenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;
                case "2":
                    Console.Write("Enter the Farenheit temperature: ");
                    C = TemperatureConvertor.FarenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;
            }
        }
    }
}