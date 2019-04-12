using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        public delegate int SomeOperation(int i, int j);
        public delegate int lambda(int input);
        delegate long multi(int x, int y, int z);
        delegate int noparamsLambda();
        
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            #region Info
            /*
            - Lambda expressions get their name from lambda calculus, it’s a mathematical notation for describing functions
            - Lambda expressions describe methods without naming them
            - (input parameters) => {expression or statement block}
            - Lambda operator => is introduced in C# 3.0 and is read as “goes to”
            - Lambda expression is an expression that returns a method. It’s not a method by itself
            - Lambda expression is a shorter way of representing anonymous method using some special syntax
            */
            #endregion

            #region Standard Delegate and Lambda
            //Console.WriteLine("\n------------------ Standard Delegate and Lambda ------------------");
            //SomeOperation del1 = new SomeOperation(Sum);
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

            #region Anatomy of the Lambda Expression
            /*
            - SomeOperation del2 = delegate (int x, int y) { return x + y; };
            - if we remove word delegate and add lambda operator =>
            - SomeOperation del2 = (int x, int y) => { return x + y; };
            - we can delete parameter types if we like
            - SomeOperation del2 = (x, y) => { return x + y; };
            - we can delete return keyword
            - SomeOperation del2 = (x, y) => { x + y; };
            - we can delete parentheses {}
            - SomeOperation del2 = (x, y) => x + y;
            */
            #endregion

            #region Examples
            //Console.WriteLine("\n------------------ addOne ------------------");
            //lambda addOne = x => x + 1;
            //Console.WriteLine($"addOne(11): {addOne(11)}");

            //Console.WriteLine("\n------------------ multiply ------------------");
            //multi multiply = (x, y, z) => x * y * z;
            //Console.WriteLine($"multiply(2, 3, 4): {multiply(2, 3, 4)}");

            //Console.WriteLine("\n------------------ randomNumber ------------------");
            //noparamsLambda randomNumber = () =>
            //{
            //    int random = new Random().Next();
            //    return random;
            //};
            //Console.WriteLine($"randomNumber: {randomNumber()}");

            //Console.WriteLine("\n------------------ Even numbers ------------------");
            //int[] firstTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int num in firstTen)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.Write("\n");

            //Console.WriteLine("Even numbers:");
            //var even = firstTen.Where(n => n % 2 == 0);
            //foreach (var num in even)
            //{
            //    Console.Write("{0} ", num);
            //}
            //Console.Write("\n");

            #endregion

            Console.ReadLine();
        }
    }
}
