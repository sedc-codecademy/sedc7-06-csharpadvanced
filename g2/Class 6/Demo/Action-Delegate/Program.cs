using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate
{
    class Program
    {
        public delegate void PrintSomeOperation(int i, int j);

        static void PrintSum(int x, int y)
        {
            Console.WriteLine($"PrintSumMethod({x},{y}) = {x + y}");
        }
        
        static void Main(string[] args)
        {
            #region Info
            /*
            - C# includes built-in generic delegate types Func, Action and Predicate, so that you don't need to define custom delegates
            - Action is built-in delegate type defined in the System namespace
            - Action delegate has one or more (up to 16) input parameters
            - Action delegate doesn't return a value. It returns void
            - Action delegate can be used with an anonymous method or lambda expression
            */
            #endregion

            Console.WriteLine("\n------------------ Delegate ------------------");
            PrintSomeOperation del1 = new PrintSomeOperation(PrintSum);
            del1(10, 15);

            #region Standard Delegate other versions
            /*
            PrintSomeOperation del1b = PrintSum;
            PrintSomeOperation del2 = delegate (int x, int y)
            {
                Console.WriteLine($"del2: AnonymousMethod - Sum({x},{y}) = {x + y}");
            };
            PrintSomeOperation del3 = (x, y) =>
            {
                Console.WriteLine($"del3: Lambda - Sum({x},{y}) = {x + y}");
            };
            del1b(10, 15);
            del2(10, 15);
            del3(10, 15);
            */
            #endregion
            
            Console.WriteLine("\n------------------ Action-Delegate ------------------");
            Action<int, int> actionDel1 = PrintSum;
            actionDel1(10, 15);

            #region Action - Delegate other versions           
            //Action<int, int> actionDel1b = new Action<int, int>(PrintSum);
            //Action<int, int> actionDel2 = delegate (int x, int y)
            //{
            //    Console.WriteLine($"actionDel2: AnonymousMethod - Sum({x},{y}) = {x + y}");
            //};
            //Action<int, int> actionDel3 = (x, y) =>
            //{
            //    Console.WriteLine($"actionDel3: Lambda - Sum({x},{y}) = {x + y}");
            //};
            //actionDel1b(10, 15);
            //actionDel2(10, 15);
            //actionDel3(10, 15);
            #endregion

            Console.ReadLine();
        }
    }
}
