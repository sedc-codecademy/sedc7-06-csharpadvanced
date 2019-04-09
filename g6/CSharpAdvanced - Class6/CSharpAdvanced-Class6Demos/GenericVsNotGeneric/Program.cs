using GenericVsNotGeneric.Helpers;
using System.Collections.Generic;

namespace GenericVsNotGeneric
{
    class Program
    {
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

            //Generic methods in generic class
            GenericListHelper<string> genericHelper1 = new GenericListHelper<string>();
            GenericListHelper<int> genericHelper2 = new GenericListHelper<int>();
            GenericListHelper<bool> genericHelper3 = new GenericListHelper<bool>();

            GenericListHelper<string>.GoThrough(strings);
            GenericListHelper<string>.GetInfo(strings);

            GenericListHelper<int>.GoThrough(ints);
            GenericListHelper<int>.GetInfo(ints);

            GenericListHelper<bool>.GoThrough(bools);
            GenericListHelper<bool>.GetInfo(bools);
        }
    }
}