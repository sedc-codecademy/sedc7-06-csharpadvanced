namespace Grouping_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Use LINQ Group By method to partition a list of numbers by their remainder when divided by 5 (both Lambda/SQL approach)
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Use LINQ Group By method to partition a list of words by their first letter (both Lambda/SQL approach)
            //Print the results with added ordering by the first letter
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
        }
    }
}