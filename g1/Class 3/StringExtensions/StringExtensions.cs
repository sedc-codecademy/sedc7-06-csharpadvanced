using System.Linq;

namespace StringExtensions
{
    static class StringExtensions
    {
        public static string Shorten(this string text, int length)
        {
            return text.Substring(0, length);
        }

        public static string QuoteString(this string text)
        {
            return '"' + text + '"';
        }
        public static bool IsDigit(this string input)
        {
            bool valid = false;
            valid = !string.IsNullOrWhiteSpace(input) &&
                input.All(c => c >= '0' && c <= '9');
            return valid;
        }

    }
}
