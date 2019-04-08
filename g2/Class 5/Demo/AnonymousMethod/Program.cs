using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class Program
    {
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            #region Info
            /*
            - Anonymous method is a method without a name
            - Anonymous method can be defined using the delegate keyword
            - Anonymous method must be assigned to a delegate
            - Anonymous method can access outer variables or functions
            - Anonymous method can be passed as a parameter
            - Anonymous method can be used as event handlers
            - Cannot contain jump statement like goto, break or continue
            */
            #endregion

            Console.WriteLine("\n-------------------- Delegate1 call Method1 --------------------");
            Print delegate1 = new Print(MethodPrint);
            delegate1(100);

            Console.WriteLine("\n-------------------- Delegate2 call Anonymous Method --------------------");
            Print delegate2 = delegate (int val)
            {
                Console.WriteLine($"Inside Anonymous method. Value: {val}");
            };
            delegate2(100);

            Console.WriteLine("\n-------------------- Delegate3 call Anonymous Method which access variables defined in an outer function --------------------");
            int i = 10;
            Print delegate3 = delegate (int val)
            {
                val += i;
                Console.WriteLine($"Inside Anonymous method. Value: {val}");
            };
            delegate3(100);

            Console.ReadLine();
        }

        static void MethodPrint(int val)
        {
            Console.WriteLine($"Without Anonymous method. Value: {val}");
        }
    }
}
