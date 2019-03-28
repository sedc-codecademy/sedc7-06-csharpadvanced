using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonTypesValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Int Comaprison
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Int");
            //int i1 = 1;
            //int i2 = 1;
            //Console.WriteLine(i1 == i2);
            #endregion

            #region DateTime Comparison
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("DateTime");
            //DateTime d1 = DateTime.Now.Date;
            //DateTime d2 = DateTime.Now.Date;
            //Console.WriteLine(d1 == d2);
            #endregion

            #region String Comparison
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("String");
            //string s1 = "a";
            //string s2 = "a";
            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(object.ReferenceEquals(s1, s2));

            //string s3;
            //s3 = s1;
            //Console.WriteLine(s3 == s1);
            //Console.WriteLine(object.ReferenceEquals(s3, s1));

            //s3 = "aa";
            //Console.WriteLine(s1);
            //Console.WriteLine(s3 == s1);
            //Console.WriteLine(object.ReferenceEquals(s3, s1));
            #endregion

            #region StringBuilder Comparison
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("StringBuilder");
            //StringBuilder sb1 = new StringBuilder("a");
            //StringBuilder sb2 = new StringBuilder("a");
            //Console.WriteLine(sb1 == sb2);
            //Console.WriteLine(object.ReferenceEquals(sb1, sb2));
            //StringBuilder sb3 = sb1;
            //Console.WriteLine(sb3 == sb1);
            //Console.WriteLine(object.ReferenceEquals(sb3, sb1));
            //sb3.Append("a");
            //Console.WriteLine($"sb3={sb3.ToString()} sb1={sb1.ToString()}");
            //Console.WriteLine(sb3 == sb1);
            //Console.WriteLine(object.ReferenceEquals(sb3, sb1));
            #endregion
        }
    }
}
