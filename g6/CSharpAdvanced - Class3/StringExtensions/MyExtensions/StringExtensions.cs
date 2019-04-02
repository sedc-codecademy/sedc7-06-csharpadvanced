using System;
using System.Collections.Generic;
using System.Linq;

namespace StringExtensions
{
    /// <summary>
    ///  Class contaiining the extension method for Shortening a given string
    ///  When we are creating extension methods, class in which we are creating them,
    ///  always needs to be static.
    /// </summary>
    static class StringExtensions
    {
        /// <summary>
        /// Extension methods, enable you to "add" methods to existing type without creating
        /// a new derived type or otherwise modifying the original type. Extension methods are 
        /// a special kind of static methods, but they are called as if they were instance methods on 
        /// the extended type.
        /// NOTE : The first parameter specifies which type we are extending(string in our example)
        /// and the parameter is preceded by the this keyword always.
        /// In this example, method takes two parameters, string and number of words that we need
        /// to show from that string. 
        /// First we are doing some validations and preventing the user from sending a negative number
        /// or an empty string. This is a good pracitse in programming called "defensive programming".
        /// </summary>
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentException("numberOfWords should be greater or equal to 0.");

            if (str.Length == 0)
                return "";

            string[] words = str.Split(' ');

            if (words.Length < numberOfWords)
                return str;

            List<string> substring = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", substring);

            return result + "...";
        }

        /// <summary>
        /// Extension method for quoting a string. This method as a parameter
        /// takes one text of type string and we are just returning the same
        /// text but in quotes. Note again the this keyword in the first parameter..
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string QuoteString(this string text)
        {
            return '"' + text + '"';
        }
    }
}
