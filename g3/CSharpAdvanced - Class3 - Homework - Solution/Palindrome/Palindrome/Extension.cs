using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome {
    public static class Extension {
        
        //public static bool IsPalindrom (this string text) {
        //    string forwards = text.ToLower();
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var c in forwards) {
        //        if (Char.IsLetterOrDigit(c))
        //            sb.Append(c);
        //    }
        //    forwards = sb.ToString().ToLower();
        //    char[] chars = forwards.ToCharArray();
        //    Array.Reverse(chars);
        //    string backwards = new string(chars);
        //    return forwards == backwards;
        //}

        //public static bool IsPalindrom(this int text) {
        //    string forwards = text.ToString().ToLower();
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var c in forwards) {
        //        if (Char.IsLetterOrDigit(c))
        //            sb.Append(c);
        //    }
        //    forwards = sb.ToString();
        //    char[] chars = forwards.ToCharArray();
        //    Array.Reverse(chars);
        //    string backwards = new string(chars);
        //    return forwards == backwards;
        //}

        //public static bool IsPalindrom(this double text) {
        //    string forwards = text.ToString().ToLower();
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var c in forwards) {
        //        if (Char.IsLetterOrDigit(c))
        //            sb.Append(c);
        //    }
        //    forwards = sb.ToString();
        //    char[] chars = forwards.ToCharArray();
        //    Array.Reverse(chars);
        //    string backwards = new string(chars);
        //    return forwards == backwards;
        //}

        //public static bool IsPalindrom(this decimal text) {
        //    string forwards = text.ToString().ToLower();
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var c in forwards) {
        //        if (Char.IsLetterOrDigit(c))
        //            sb.Append(c);
        //    }
        //    forwards = sb.ToString();
        //    char[] chars = forwards.ToCharArray();
        //    Array.Reverse(chars);
        //    string backwards = new string(chars);
        //    return forwards == backwards;
        //}

        //public static bool IsPalindrom(this long text) {
        //    string forwards = text.ToString().ToLower();
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var c in forwards) {
        //        if (Char.IsLetterOrDigit(c))
        //            sb.Append(c);
        //    }
        //    forwards = sb.ToString();
        //    char[] chars = forwards.ToCharArray();
        //    Array.Reverse(chars);
        //    string backwards = new string(chars);
        //    return forwards == backwards;
        //}         

        //soultion with generic
        public static bool IsPalindrom<T>(this T text) {
            string forwards = text.ToString().ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (var c in forwards) {
                if (Char.IsLetterOrDigit(c))
                    sb.Append(c);
            }
            forwards = sb.ToString();
            char[] chars = forwards.ToCharArray();
            Array.Reverse(chars);
            string backwards = new string(chars);
            return forwards == backwards;
        }
    }
}
