using System;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Long string for an example. 
            string text = "C# Advanced is a comprehensive subject full of demos, exercises and hands on activities.";

            // Here we are calling the extension method Shorten on the text string and saying
            // that we want to take the first 6 words from it and QuouteString() method
            // just wraps that string in quotes.
            string thumbtailDescription = text.Shorten(6).QuoteString();

            //Printing the short version from the string in the console..
            Console.WriteLine(thumbtailDescription);

            Console.ReadLine();
        }
    }
}