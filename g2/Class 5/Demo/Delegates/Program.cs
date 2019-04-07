using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // define a delegate type
        public delegate void DelegatePointsTo(string msg);

        static void Main(string[] args)
        {
            #region Info
            /*
            - Function can have one or more parameters of different data types, but what if you want to pass a function itself as a parameter?
            - Delegate is like a pointer to a function
            - Delegate is a reference type data type and it holds the reference of a method
            - A method that is going to assign to delegate must have same signature as delegate
            - Delegates can be invoke like a normal function or Invoke() method
            - The delegate can points to multiple methods and it is called a multicast delegate
            - The "+=" operator adds a function to the delegate object and the "-=" operator removes an existing function from a delegate object
            */

            #endregion

            //Console.WriteLine("\n-------------------- Delegate1 call Method1 --------------------");
            //DelegatePointsTo delegate1 = new DelegatePointsTo(Method1);

            //delegate1("Hello, from delegate1");

            //Console.WriteLine("\n-------------------- Delegate2 call Method2 --------------------");
            //DelegatePointsTo delegate2 = new DelegatePointsTo(Method2);
            //delegate2.Invoke("Hello, from delegate2");

            //Console.WriteLine("\n-------------------- Delegate3 call Method2 without new --------------------");
            //DelegatePointsTo delegate3 = Method2;
            //delegate3("Hello, from delegate3");

            Console.WriteLine("\n-------------------- Multi-cast delegate --------------------");
            Console.WriteLine("-------------------- Delegate4 call Method1,Method2 --------------------");
            //Multi-cast delegate
            DelegatePointsTo delegate4 = null;
            delegate4 += new DelegatePointsTo(Method1);
            delegate4 += new DelegatePointsTo(Method2);
            delegate4("Hello, from delegate4");

            Console.ReadLine();
        }

        //Delegate functions:
        public static void Method1(string strMsg)
        {
            Console.WriteLine($"Method1: {strMsg}");
        }

        public static void Method2(string msg)
        {
            Console.WriteLine($"Method2: {msg}");
        }
    }
}
