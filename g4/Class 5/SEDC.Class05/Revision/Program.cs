using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public static class Baza
    {
        private static List<string> stringovi1 = new List<string>()
        {"eden", "dva", "tri" };
        private static List<string> stringovi2 = new List<string>()
        {"eden", "dva", "tri" };
        public static List<Dog> dogs = new List<Dog>()
        {
            new Dog(){Name = "Bob", Age=2, Race="Dzuki"},
            new Dog(){Name = "Berta", Age=3, Race="Pekinezer"},
            new Dog(){Name = "Bak", Age=4, Race="Kuciste"}
        };
        public static void AddStringToStrings(string myString)
        {
            stringovi1.Add(myString);
            stringovi2.Add(myString);
        }
    }
    public class Dog
    {
        // Auto properties
        public string Name { get; set; }
        public string Race { get; set; }

        // Custom property
        private int _Age;
        public int Age
        {
            get // rex.Age;
            {
                return _Age;
            }
            set // rex.Age = 4;
            {
                if(value < 0)
                {
                    Console.WriteLine("Ne moze minus godini!");
                    Console.WriteLine("Age e ne promeneto! Probaj pak!");
                    return;
                }
                _Age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog() { Name = "Rex", Age = 6, Race = "German Shepard" };
            Console.WriteLine(rex.Age);
            Baza.AddStringToStrings("cetiri");
            Baza.dogs.Add(rex);
            Baza.dogs.Add(new Dog() { Name = "xx", Age = 1, Race = "xxx" });
            Console.ReadLine();
        }
    }
}
