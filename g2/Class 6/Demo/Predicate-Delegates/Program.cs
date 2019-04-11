using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegates
{
    class Program
    {
        public delegate bool SomeOperation(string x);

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static bool IsPalindrom(string s)
        {
            string revert = String.Join("", s.Reverse());
            if (s.ToLower() == revert.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            #region Info
            /*
            - C# includes built-in generic delegate types Func, Action and Predicate, so that you don't need to define custom delegates
            - Predicate is built-in delegate type defined in the System namespace
            - Predicate delegate has one input parameters and one out parameter
            - Predicate delegate must return a bool value
            - Predicate delegate can be used with an anonymous method or lambda expression
            */
            #endregion

            SomeOperation del1 = IsUpperCase;
            Console.WriteLine($"del1 - IsUpperCase(UP) = {del1("UP")}");

            Predicate<string> predDel1 = IsUpperCase;
            Console.WriteLine($"predDel1 - IsUpperCase(Up) = {predDel1("Up")}");

            SomeOperation del2 = IsPalindrom;

            Console.WriteLine(del2("Madam"));
            Console.ReadLine();
        }
    }
}
