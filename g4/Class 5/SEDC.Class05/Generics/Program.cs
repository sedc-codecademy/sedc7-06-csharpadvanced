using Generics.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Human
    {
        public string Name { get; set; }
        public void Greet()
        {
            Console.WriteLine($"Hey there {Name}");
        }
    }
    public class Programmer : Human
    {
        public string ProgrammingLanguage { get; set; }
    } 
    public class Tester : Human
    {
        public string BugsFound { get; set; }
    }

    class Program
    {
        public static void CallHumans<T>(List<T> humans) where T : Human
        {
            foreach (T item in humans)
            {
                Console.WriteLine(item.Name);
            }
        }
        static void Main(string[] args)
        {
            // Not generic helper testing
            NotGenericListHelper NotGeneric = new NotGenericListHelper();
            List<string> strings = new List<string>() { "str1", "str2", "str3" };
            List<int> ints = new List<int>() { 5, 22, -18 };
            List<bool> bools = new List<bool> { true, false, true };
            NotGeneric.GoThroughStrings(strings);
            NotGeneric.GetInfoForStrings(strings);
            NotGeneric.GoThroughInts(ints);
            NotGeneric.GetInfoForInts(ints);

            // Generic method outside of generic class
            Console.WriteLine("HERE ARE THE RESULTS OF THE GENERIC METHOD");
            Console.WriteLine(ReturnTypeString("Hey"));
            Console.WriteLine(ReturnTypeString<int>(23)); // This is also valid
            Console.WriteLine(ReturnTypeString(new List<bool>() { true, false }));


            // Generic methods in generic class
            // non-static calling
            //GenericListHelper<string> genericHelper1 = new GenericListHelper<string>();
            //GenericListHelper<int> genericHelper2 = new GenericListHelper<int>();
            //GenericListHelper<bool> genericHelper3 = new GenericListHelper<bool>();
            //genericHelper1.GoThrough(strings);
            //genericHelper1.GetInfo(strings);
            //genericHelper2.GoThrough(ints);
            //genericHelper2.GetInfo(ints);
            //genericHelper3.GoThrough(bools);
            //genericHelper3.GetInfo(bools);
            GenericListHelper<string>.GoThrough(strings);

            Console.ReadLine();
        }
        public static string ReturnTypeString<T>(T something)
        {
            return $"This thing is of type {something.GetType().FullName}!";
        }
    }
}
