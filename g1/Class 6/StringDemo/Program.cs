using System;
using System.Linq;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> a1 = s =>
            {
                string revert = string.Join("", s.Reverse());
                Console.WriteLine(s.ToLower() == revert.ToLower() ? "E palindrom" : "Ne e palindrom");
            };

            Action<string> a2 = s => { Console.WriteLine($"Ima: {s.Split(' ').Length} zborovi"); };

            Action<string> a3 = s =>
            {
                string revert = string.Join("", s.Reverse());
                Console.WriteLine(revert);
            };

            a1 += a2;
            a1 += a3;

            a1("Ana e radar");
            a1("Madam");
        }
    }
}
