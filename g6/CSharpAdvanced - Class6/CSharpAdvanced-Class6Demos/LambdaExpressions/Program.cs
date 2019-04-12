using System;
using System.Linq;

namespace LambdaExpressions
{
    /// <summary>
    /// The general rule for lambdas are as follows : 
    /// - The lambda must contain the same number of parameters as the delegate type
    /// - Each input parameter in lambda must be implicitly convertible to its corresponding delegate paramter
    /// - The return value of the lambda(if there is any) must be implicitly convertible to the delegat's return type
    /// </summary>
    class Program
    {
        /// <summary>
        /// We are creating three different delegates. They all have 
        /// different signature.
        /// </summary>
        /// <returns></returns>
        delegate int lambda(int input);
        delegate long multi(int x, int y, int z);
        delegate int noparamsLambda();

        static void Main(string[] args)
        {
            // We are creating an instance of our delegate called lambda. 
            // Here you can see the lambda operator => in action. 
            // On the left side we have the arguments, in our case x 
            // and on the right side we have the expression x + 1
            // You can notice that instead of creating a separate method for
            // incrementing of x by 1, we are using lambda expression here 
            // and achieve the same with one line of code.

            lambda addOne = x => x + 1;
            Console.WriteLine(addOne(1)); // Output: 2
            Console.WriteLine("--------------");


            // We are creating an instance of our delegate called multi.
            // Once again, on the left side we have the arguments but this
            // time we have three(x,y,z) arguments. On the right side where we 
            // put the expression, we are just multiplying them.

            multi multiply = (x, y, z) => x * y * z;
            Console.WriteLine(multiply(2, 3, 4)); //Output: 24
            Console.WriteLine("--------------");


            // We are creating an instance of our delegate caleld noparamsLambda.
            // You can see above that our delegate returns int but doesn.t have any
            // input parameters. That's the meaning of '() ' below. On the left side 
            // you can see we have just empty paratheses.
            // Also note that on the right side we put a logic for a random number
            // generaor, the same way we are doing it in every normal method.

            noparamsLambda randomNumber = () =>
            {
                int random = new Random().Next();
                Console.WriteLine("Random number generated - {0}", random);
                return random;
            };
            Console.WriteLine(randomNumber());
            Console.WriteLine("--------------");

            int[] firstTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var num in firstTen)
                Console.Write("{0} ", num);
            Console.Write("\n");

            Console.WriteLine("Even numbers:");
            var even = firstTen.Where(n => n % 2 == 0);
            foreach (var num in even)
                Console.Write("{0} ", num);
            Console.Write("\n");
        }
    }
}
