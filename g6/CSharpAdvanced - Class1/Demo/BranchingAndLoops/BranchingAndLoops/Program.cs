using System;

namespace BranchingAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If
            //Use braces, because of this potential confusion
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("If statement With/Without braces example");
            int valueOne = 10;
            int valueTwo = 20;
            int valueThree = 10;
            Console.WriteLine("Testing valueOne against valueTwo...");
            if (valueOne > valueTwo)
                Console.WriteLine($"ValueOne: {valueOne} larger than ValueTwo: {valueTwo}");
            Console.WriteLine("Testing valueThree against valueTwo...");
            if (valueThree > valueTwo)
                //{
                Console.WriteLine($"ValueThree: {valueThree} larger than ValueTwo: {valueTwo}");
            Console.WriteLine("Good thing you tested again!");
            //}
            #endregion

            #region Short-Circuit Evaluation
            //First make sure you are not dividing by zero (division by zero causes the system
            //to throw an exception). With short-circuiting, the second part of the if statement
            //(the division) will never occur if the first part is false(that is, if the divisor is zero)
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Short-Circuit Evaluation");
            int dividend = 15;
            int divisor = 0;
            if ((divisor != 0) && (dividend / divisor > 5))
            {
                Console.WriteLine($"Result = {dividend / divisor}");
            }
            else
            {
                Console.WriteLine("With short-circuiting, the second part of the if statement(the division) will never occur");
            }
            #endregion

            #region If else
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("If Else");
            int temp = 0;
            if (temp <= 0)
            {
                Console.WriteLine("Warning! Ice on road!");
                if (temp == 0)
                {
                    Console.WriteLine("Temp exactly freezing, beware of water.");
                }
                else
                {
                    Console.WriteLine("Watch for black ice! Temp: {0}", temp);
                }
            }
            else
            {
                Console.WriteLine("No ice; drive with confidence.");
            }
            #endregion

            #region else_if
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Else_If");
            int temp2 = 0;
            if (temp2 < 0)
            {
                Console.WriteLine("Warning! Ice on road!");
            }
            else if (temp == 0)
            {
                Console.WriteLine("Temp exactly freezing, beware of water.");
            }
            else
            {
                Console.WriteLine("No ice; drive with confidence.");
            }
            #endregion

            #region Switch
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Fall-Through and Jump-to Cases");
            int x = 0;
            Console.WriteLine($"x = {x}");
            switch (x)
            {
                case 0:
                case 1:
                    Console.WriteLine($"case x = {x}, x <= 1");
                    break;
                case 2:
                    Console.WriteLine($"case x = {x}, x == 2");
                    break;
                case 3:
                    Console.WriteLine($"case x = {x}, x == 3");
                    break;
                case 4:
                    Console.WriteLine($"case x = {x}, x == 4");
                    goto case 5;
                case 5:
                    Console.WriteLine($"case x = {x}, x >= 4");
                    break;
            }

            #endregion

            Console.ReadLine();
        }
    }
}
