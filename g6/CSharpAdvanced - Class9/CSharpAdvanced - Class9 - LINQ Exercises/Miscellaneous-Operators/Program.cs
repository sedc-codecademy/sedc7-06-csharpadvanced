namespace Miscellaneous_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Using LINQ Concat method create one sequence that contains each array's values, one after the other.
            int[] numsA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numsB = { 1, 3, 5, 7, 8 };

            // Concat to create one sequence that contains the names of all customers and products, including any duplicates.

            //Using LINQ EqualAll method check if two sequences match on all elements in the same order.
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };
        }
    }
}