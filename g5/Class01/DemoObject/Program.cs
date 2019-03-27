using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();

            p.FirstName = "Wekoslav";
            p.LastName = "Stefanovski";
            p.Age = 0x29;

            Console.WriteLine(p);
        }
    }
}
