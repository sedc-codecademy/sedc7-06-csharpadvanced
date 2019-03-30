using System;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hi there, how are you?";
            string shortenString = myString.Shorten(8);
            Console.WriteLine(myString);
            Console.WriteLine("Shorten: " + shortenString);

            string quoted = myString.Shorten(8).QuoteString();
            Console.WriteLine(quoted);

            string broj = "100";
            Console.WriteLine(broj.IsNumericType());
            Console.WriteLine(broj.IsNotNumericType());
            Console.WriteLine(broj.IsDigit());
            double epsilon = double.Epsilon;
            Console.WriteLine(epsilon.IsNumericType());
            Console.WriteLine(epsilon);
        }
    }
}
