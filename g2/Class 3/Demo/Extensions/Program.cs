using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }

    public static class StringExtensions
    {
        public static string QuoteText(this string text, string quote)
        {
            return $"{quote}{text}{quote}";
        }

        public static string QuoteText(this string text)
        {
            return $"a{text}a";
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public Cat(string name)
        {
            this.Name = name;
        }
    }

    public static class CatExtensions
    {
        public static void AddTypeToName(this Cat c)
        {
            c.Name = $"{c.GetType().ToString()} - {c.Name}";
        }

        public static void Quote(this Cat c)
        {
            c.Name = $"a{c.Name}a";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region String Extensions
            //Console.WriteLine("---------------- String Extensions ----------------");

            //string myText = "My test text";
            //string myText2 = "My test text";
            //myText = myText.QuoteText();
            //Console.WriteLine($"My quoted text: {myText}");
            //myText2 = myText2.QuoteText("\"");
            //Console.WriteLine($"My quoted text: {myText2}");

            #endregion

            #region Int extensions
            //Console.WriteLine("---------------- Int Extensions ----------------");

            //int myNumber = 50;
            //int limit = 30;
            //Console.WriteLine($"{myNumber} is greater than {limit}: {myNumber.IsGreaterThan(limit)}");

            #endregion

            #region Cat Extensions
            Console.WriteLine("---------------- Cat Extensions ----------------");
            Cat catGarfield = new Cat("Garfield");
            Console.WriteLine($"Cat name: {catGarfield.Name}");
            //catGarfield.AddTypeToName();
            catGarfield.Quote();
            Console.WriteLine($"Cat new name: {catGarfield.Name}");

            #endregion

            Console.ReadLine();
        }
    }
}
