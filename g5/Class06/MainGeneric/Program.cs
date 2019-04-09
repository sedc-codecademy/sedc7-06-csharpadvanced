using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Person("Wekoslav", "Stefanovski");
            weko.Age = 0x29;
            weko.IsMarried = true;
            Console.WriteLine(weko);

            var emilija = new Person("Emilija", "Filiposka-Velichkovska");
            Console.WriteLine(emilija);

            var trump = new Person("Donald", "Trump");
            trump.BankBalance = 3000000000m;
            Console.WriteLine(trump);
        }
    }
}
