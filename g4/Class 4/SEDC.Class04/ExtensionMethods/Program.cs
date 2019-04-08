//using ExtensionMethods.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Student : Human
    {
        public List<int> Grades { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // extension method int example
            //Console.WriteLine("Enter number:");
            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Result1:{input.PlusSomething(-3)}");
            //Console.WriteLine($"Result2:{input.PlusSomething(0)}");
            //Console.WriteLine($"Result3:{input.PlusSomething(3)}");

            // extension method string example
            //Console.WriteLine("Enter a string:");
            //string inputString = Console.ReadLine();
            //inputString.MyString();
            //string otherString = "Hello World!";
            //otherString.MyString();
            //Console.ReadLine();

            // extension method class example
            //Human bob = new Human() { Name = "Bob Bobsky", Age = 29 };
            //Student Jill = new Student() { Name = "Jill" };
            //Jill.CallHuman();
            //bob.CallHuman();
            //Jill.CallStudent();

            // extension method from external class example
            List<string> strings = new List<string>() { "hey", "hi", "ho" };
            strings.GoThroughStrings();
            Db.Names.Add("Anne");
            Db.Names.GoThroughStrings();
            Console.ReadLine();
        }
    }
    public static class SimpleExtensionMethods
    {
        public static int PlusSomething(this int num, int addedNum)
        {
            return num + addedNum;
        }
        public static void MyString(this string myString)
        {
            Console.WriteLine($"This is my string: {myString}!");
            Console.WriteLine($"It has {myString.Length} characters!");
        }
        public static void CallHuman(this Human human)
        {
            Console.WriteLine($"CALLING Mr/Ms {human.Name}.");
        }
        public static void CallStudent(this Student human)
        {
            Console.WriteLine($"CALLING STUDENT {human.Name}.");
        }

    }
}
