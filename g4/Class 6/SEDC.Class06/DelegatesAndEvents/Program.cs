using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        public delegate void SayDelegate(string something);
        public delegate int NumbersDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            SayDelegate del = new SayDelegate(SayHello);
            SayDelegate bye = new SayDelegate(SayBye);
            SayDelegate wow = new SayDelegate(x => Console.WriteLine($"Wow {x}!"));

            //del("Bob");
            //bye("Jill");
            //wow("Greg");
            SayWhatever("Bob", SayHello);
            SayWhatever("Jill", SayBye);
            SayWhatever("Greg", x => Console.WriteLine($"Wow {x}!"));
            SayWhatever("Anne", x =>
            {
                Console.WriteLine($"Stuff with {x}");
                Console.WriteLine($"Other stuff with {x}");
            });
            Console.WriteLine("NUMBER MASTER! IT IS REALLY MASTER AT NUMBERS!");
            NumberMaster(2, 5, (x, y) => x + y);
            NumberMaster(2, 5, (x, y) => x - y);
            NumberMaster(2, 5, (x, y) => 0);
            NumberMaster(2, 5, (x, y) =>
            {
                if (x > y) return x;
                return y;
            });
            Console.ReadLine();
        }
        public static void SayWhatever(string whatever, SayDelegate sayDel)
        {
            Console.Write("Chatbot says:");
            sayDel(whatever);
        }
        public static void NumberMaster(int num1, int num2, NumbersDelegate numberDel)
        {
            Console.WriteLine($"The result is: {numberDel(num1, num2)}");
        }
        public static void SayHello(string person)
        {
            Console.WriteLine($"Hello {person}!");
        }
        public static void SayBye(string person)
        {
            Console.WriteLine($"Bye {person}!");
        }

    }
}
