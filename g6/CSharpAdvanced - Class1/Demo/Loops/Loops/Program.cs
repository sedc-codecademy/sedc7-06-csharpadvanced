using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("While");

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"i: {i}");
                i++;
            }
            #endregion

            #region Do While
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Do While");

            int i2 = 11;
            do
            {
                Console.WriteLine($"i: {i2}");
                i2++;
            } while (i2 < 10);
            #endregion

            #region For
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("For");

            for (int i3 = 0; i3 < 10; i3++)
            {
                Console.WriteLine($"i: {i3}");
            }
            #endregion

            #region Loop with GoTo
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("GoTo");

            int i4 = 0;
            loopLabel:
            if (i4 < 10)
            {
                Console.WriteLine($"i: {i4}");
                i4++;
                goto loopLabel;
            }
            #endregion

            #region break, continue
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Break and Continue");

            for (int i5 = 0; i5 < 10; i5++)
            {
                if(i5 == 3)
                {
                    Console.WriteLine($"Continue for i: {i5}");
                    continue;
                }
                if (i5 == 6)
                {
                    Console.WriteLine($"Break for i: {i5}");
                    break;
                }
                Console.WriteLine($"i: {i5}");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
