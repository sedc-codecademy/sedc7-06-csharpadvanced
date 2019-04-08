using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Helpers
{
    // non static methods
    //public class GenericListHelper<T>
    //{
    //    public void GoThrough(List<T> items)
    //    {
    //        foreach (T item in items)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //    public void GetInfo(List<T> items)
    //    {
    //        T first = items[0];
    //        Console.WriteLine($"This list has {items.Count} members and is of type {items.GetType().FullName}!");

    //    }
    //}
    // static methods
    public class GenericListHelper<T>
    {
        public static void GoThrough(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void GetInfo(List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} members and is of type {items.GetType().FullName}!");

        }
    }
    public class SpecialListHelper : GenericListHelper<string>
    {
        // ... SPECIAL METHODS ONLY FOR STRINGS
    }
}
