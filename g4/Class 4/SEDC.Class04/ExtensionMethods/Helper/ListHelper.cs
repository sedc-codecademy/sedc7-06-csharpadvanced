using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ExtensionMethods.Helper
namespace System
{
    public static class ListHelper
    {
        public static void GoThroughStrings(this List<string> strings)
        {
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }
        public static void GoThroughInts(this List<int> ints)
        {
            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }
        }
    }
}
