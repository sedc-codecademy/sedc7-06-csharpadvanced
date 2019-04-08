using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Subscriber1
    {
        public void GetMessage(string message)
        {
            Console.WriteLine("Subscriber 1 here!");
            Console.WriteLine("YAY I GOT MY MESSAGE!");
            Console.WriteLine($"THE MESSAGE IS: {message}");
        }
        public string GetMessageFAIL(int num)
        {
            return "This will FAIL!";
        }
    }
}
