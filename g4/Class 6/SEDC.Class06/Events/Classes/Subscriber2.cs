using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Subscriber2
    {
        public void GetMessage(string message)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Subscriber 2 here!");
            Console.WriteLine("I AM NOT IMPRESED WITH THE MESAGE!");
            Console.WriteLine($"THE MESSAGE IS: {message}");
        }
    }
}
