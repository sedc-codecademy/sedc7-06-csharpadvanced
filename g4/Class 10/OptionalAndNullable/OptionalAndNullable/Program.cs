using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptionalAndNullable
{
    public class Student1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int ExamPoints { get; set; }
        public bool IsPartTime { get; set; }
    }
    public class Student2
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int? ExamPoints { get; set; }
        public bool? IsPartTime { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // OPTIONAL PARAMETERS
            //Console.WriteLine("------ SaySomething ------");
            //SaySomething();
            //SaySomething("Hello");
            //Console.WriteLine("------ SayTwoThings ------");
            //SayTwoThings("Hello");
            //SayTwoThings("Hello", "there");
            //Console.WriteLine("------ SayThreeThings ------");
            //SayThreeThings("Hello", "there");
            //SayThreeThings("Hello", "there", "SEDC");
            //Console.WriteLine("------ SayMultipleThings ------");
            //SayMultipleThings();
            //SayMultipleThings("Hello");
            //SayMultipleThings("Hello", "there");
            //SayMultipleThings("Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC", "Hello", "there", "SEDC");

            // NULLABLE VALUES
            int num1 = 5;
            // int num2 = null; // NE RABOTE
            int? nullableNum1 = 5;
            int? nullableNum2 = null;
            bool isOkay1 = false;
            // bool isOkay2 = null; // NE RABOTE
            bool? isOkayNullable1 = false;
            bool? isOkayNullable2 = null;
            Console.WriteLine(isOkayNullable1);
            Console.WriteLine(isOkayNullable2);

            Console.WriteLine("STUDENTS");
            Console.WriteLine("STUDENT1");
            Student1 bob = new Student1() {Name = "Bob" };
            Console.WriteLine(bob.ExamPoints);
            Console.WriteLine(bob.IsPartTime);
            Console.WriteLine("STUDENT2");
            Student2 jill = new Student2() { Name = "Jill" };
            Console.WriteLine(jill.ExamPoints);
            Console.WriteLine(jill.IsPartTime);

            string bob1 = null;
            Student1 wayne = null;
            string bob3 = String.Empty;
            // string? bob2 = null; // NE RABOTE
            Console.WriteLine(String.IsNullOrEmpty(bob1));
            Console.ReadLine();
        }
        // Optional parameters
        public static void SaySomething(string words = "nothing")
        {
            Console.WriteLine($"Someone is saying {words}");
        }
        public static void SayTwoThings(string word1, string word2, int? ssss)
        {
            Console.WriteLine($"Someone is saying {word1} {word2}");
        }
        public static void SayThreeThings(string word1, string word2, [Optional] string word3)
        {
            Console.WriteLine($"Someone is saying {word1} {word2} {word3}");
        }
        public static void SayMultipleThings(params string[] stuff)
        {
            Console.Write("Someone is saying ");

            if (stuff.Length > 0) Console.WriteLine($"PRV: {stuff[0]}");
            if (stuff.Length == 0) Console.Write("nothing");
            foreach (string word in stuff)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
        }
    }
}
