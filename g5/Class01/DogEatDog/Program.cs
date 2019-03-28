using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogEatDog
{
    class Program
    {
        static void Main(string[] args)
        {
            var lola = new Dog("Lola", Race.Bichon, 1);
            var choco = new Dog("Chocolate", Race.Labrador, 3);
            var marmaduke = new Dog("Marmaduke", Race.GreatDane, 10);

            Console.WriteLine(lola);
            Console.WriteLine(lola.Bark());
            Console.WriteLine(choco);
            Console.WriteLine(choco.Bark());
            Console.WriteLine(marmaduke);
            Console.WriteLine(marmaduke.Bark());
        }
    }
}
