using System;

namespace AnonymousMethods
{
    /// <summary>
    /// Anonynmous method is essnetially a way to pass a code block as a delegate
    /// parameter. We have defined a delegate below named Print, with a void return
    /// type and takes one int parameter. Once again, what is a delegate? :) Pointer
    /// to a method or group of methods that have the same signature..
    /// 
    /// </summary>
    class Program
    {
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            // Creating an instance of our delegate type and pointing it to the MethodPrint
            // function that has the same signature as our delegate(returns void and takes one paramter of type int).

            Console.WriteLine("\n-------------------- Delegate1 call Method1 --------------------");
            Print delegate1 = new Print(MethodPrint);
            delegate1(100);


            // Same example as above, but here we are using an anonymous method. 
            // Anonymous method is a method without a name. They provide as the possibility
            // to use the delegate keyword not only for declaration of the delegate signature but
            // also to write a code sample that the compiler at runtime transforms in a method :)
            // By using anonymous methods, you reduce the coding overhead in instantiating delegates
            // because we dont have to create a separate method.

            Console.WriteLine("\n-------------------- Delegate2 call Anonymous Method --------------------");
            Print delegate2 = delegate (int val)
            {
                Console.WriteLine($"Inside Anonymous method. Value: {val}");
            };
            delegate2(100);


            // Another example of anonymous methods in which we see that the method has access to the so called 
            // outer variable defined in an outer function .. 

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

        /// <summary>
        /// Method that has the same signature as our delegate does..
        /// Returns void and takes one paramter of type integer.
        /// </summary>
        /// <param name="val"></param>
        static void MethodPrint(int val)
        {
            Console.WriteLine($"Without Anonymous method. Value: {val}");
        }
    }
}