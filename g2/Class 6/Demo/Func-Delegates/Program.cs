using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegates
{
    class Program
    {
        public delegate int SomeOperation(int i, int j);

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            #region Info
            /*
            - C# includes built-in generic delegate types Func, Action and Predicate, so that you don't need to define custom delegates
            - Func is built-in delegate type defined in the System namespace
            - Func delegate has zero or more (up to 16) input parameters and one out parameter
            - Func delegate must return a value. The last parameter is considered as an out parameter
            - Func delegate can be used with an anonymous method or lambda expression
            */
            #endregion

            #region Standard Delegate

            //Console.WriteLine("\n------------------ Delegate ------------------");

            //SomeOperation del1 = new SomeOperation(Sum);
            ////SomeOperation del1 = Sum;
            //SomeOperation del2 = delegate (int x, int y)
            //{
            //    return x + y;
            //};
            //SomeOperation del3 = (x, y) =>
            //{
            //    return x + y;
            //};

            //Console.WriteLine($"del1: SumMethod = {del1(10, 15)}");
            //Console.WriteLine($"del2: AnonymousMethod = {del2(10, 15)}");
            //Console.WriteLine($"del3: Lambda = {del3(10, 15)}");

            #endregion

            #region Func - Delegate

            Console.WriteLine("\n------------------ Func-Delegate ------------------");

            //Func<int, int, int> funcDel1 = new Func<int, int, int>(Sum);
            Func<int, int, int> funcDel1 = Sum;
            Func<int, int, int> funcDel2 = delegate (int x, int y)
            {
                return x + y;
            };
            Func<int, int, int> funcDel3 = (x, y) =>
            {
                return x + y;
            };

            Console.WriteLine($"funcDel1: SumMethod = {funcDel1(10, 15)}");
            Console.WriteLine($"funcDel2: AnonymousMethod = {funcDel2(10, 15)}");
            Console.WriteLine($"funcDel3: Lambda = {funcDel3(10, 15)}");
            
            #endregion

            Console.ReadLine();
        }
    }
}
