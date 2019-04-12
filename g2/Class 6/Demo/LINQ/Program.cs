using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }

    delegate bool FindStudent(Student std);
    class StudentExtension
    {
        public static Student[] where(Student[] stdArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[stdArray.Length];
            foreach (Student std in stdArray)
                if (del(std))
                {
                    result[i] = std;
                    i++;
                }
            Array.Resize(ref result, i);
            return result;
        }
    }

    class Program
    {
        static void PrintStudents(Student[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"StudentID: {array[i].StudentID}, StudentName: {array[i].StudentName}, Age: {array[i].Age}");
            }
        }

        static void Main(string[] args)
        {
            #region Info
            /*
            * What is LINQ?
            - LINQ - Language Integrated Query
            - Uniform query syntax in C# and VB.NET to retrieve data from different sources and formats
            - Object collection, ADO .Net Dataset, XML Document, Entity Framework, SQL Database, Other data sources
            - LINQ queries return results as objects
            - After writing LINQ query, it must be executed to get the result (foreach executes LINQ query)
            * Why LINQ?
            - Familiar language: for each type of data source or data format
            - Less coding: It reduces the amount of code to be written as compared with a more traditional approach
            - Readable code: LINQ makes the code more compact and readable so other developers can easily understand and maintain it
            - Compile time safety of queries: It provides type checking of objects at compile time
            - IntelliSense Support: LINQ provides IntelliSense for generic collections
            * LINQ Api
            - LINQ queries for the classes that implement IEnumerable<T> or IQueryable<T>
            - LINQ api includes two main static class Enumerable & Queryable
            - Enumerable class includes extension methods for the classes that implement IEnumerable<T> interface
                for example all the built-in collection classes implement IEnumerable<T> interface
                and so we can write LINQ queries to retrieve data from the built-in collections
            - Queryable class includes extension methods for classes that implement IQueryable<t> interface
                for example, Entity Framework api implements IQueryable<T> interface to support LINQ queries with underlaying databases such as MS SQL Server
                for example, LINQ to Amazon provides the ability to use LINQ with Amazon web services to search for books and other items
            * LINQ Query Syntax
            - Query Syntax and Method Syntax
            - Query Syntax starts with from clause and can be end with Select or GroupBy clause
                use various other opertors like filtering, joining, grouping, sorting operators to construct the desired result
            - Method Syntax is like calling extension method
                fluent syntax because it allows series of extension methods call
                implicitly typed variable - var can be used to hold the result of the LINQ query
            * Filtering Operators - Where
            - Where is used for filtering the collection based on given criteria
            - Where has following two overloads. Both overload methods accepts a Func delegate type parameter
            - public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
            - public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);
            - Use a second overload method to know the index of current element in the collection
            - Multiple Where extension methods are valid in a single LINQ query
            */
            #endregion

            Student[] studentArray =
            {
                new Student() { StudentID = 0, StudentName = "John", Age = 18 },
                new Student() { StudentID = 1, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 2, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 3, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 4, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 5, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 6, StudentName = "Rob",Age = 19  },
            };

            #region C# 1.0 for loop the collection
            //Console.WriteLine("\n------------------ C# 1.0 for loop the collection ------------------");
            //Student[] students = new Student[studentArray.Length];
            //int i = 0;
            //foreach (Student std in studentArray)
            //{
            //    if (std.Age > 12 && std.Age < 20)
            //    {
            //        students[i] = std;
            //        i++;
            //    }
            //}
            //Array.Resize(ref students, i);
            //PrintStudents(students);
            #endregion

            #region C# 2.0 Use Delegates
            //Console.WriteLine("\n------------------ C# 2.0 Use Delegates ------------------");
            //Student[] students = StudentExtension.where(studentArray, delegate (Student std)
            //{
            //    return std.Age > 12 && std.Age < 20;
            //});
            //PrintStudents(students);
            #endregion

            #region C# 3.0 Extension method, lambda, expression tree, anonymous
            //Console.WriteLine("\n------------------ C# 3.0 Extension method, lambda, expression tree, anonymous ------------------");
            //Student[] students = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            //PrintStudents(students);
            #endregion

            #region Query Sintacs
            //Console.WriteLine("\n------------------ Query Syntacs ------------------");
            //var teenAgerStudent = from s in studentArray
            //                      where s.Age > 12 && s.Age < 20
            //                      select s;
            //foreach (Student std in teenAgerStudent)
            //{
            //    Console.WriteLine($"StudentID: {std.StudentID}, StudentName: {std.StudentName}, Age: {std.Age}");
            //}
            #endregion

            #region Method Syntacs
            //Console.WriteLine("\n------------------ Method Syntacs ------------------");
            //var teenAgerStudents2 = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
            //foreach (Student std in teenAgerStudents2)
            //{
            //    Console.WriteLine($"StudentID: {std.StudentID}, StudentName: {std.StudentName}, Age: {std.Age}");
            //}
            #endregion

            #region Filtering Operator - Where
            //Console.WriteLine("\n------------------ Method and Query Syntacs ------------------");
            /*
            - In the above examples (Query and Method Syntacs),
                the lambda expression body s.Age > 12 && s.Age < 20 is passed as a predicate function Func<TSource, bool>
                that evaluates every student in the collection
            */

            //Console.WriteLine("\n------------------ Query Syntacs with Func Delegate ------------------");
            //Func<Student, bool> isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };
            //var filteredResult = from s in studentArray
            //                     where isTeenAger(s)
            //                     select s;
            //foreach (var std in filteredResult)
            //{
            //    Console.WriteLine($"StudentID: {std.StudentID}, StudentName: {std.StudentName}, Age: {std.Age}");
            //}

            //Console.WriteLine("\n------------------ Method Syntacs - Even elements with second overload ------------------");
            //var filteredResult2 = studentArray
            //    .Where((s, i) =>
            //    {
            //        if (i % 2 == 0) // if it is even element
            //        {
            //            return true;
            //        }
            //        return false;
            //    });
            //foreach (var std in filteredResult2)
            //{
            //    Console.WriteLine($"StudentID: {std.StudentID}, StudentName: {std.StudentName}, Age: {std.Age}");
            //}

            //Console.WriteLine("\n------------------ Query Syntacs - Multiple where ------------------");
            //var filteredResult3 = from s in studentArray
            //                      where s.Age > 12
            //                      where s.Age < 20
            //                      select s;
            //foreach (var std in filteredResult3)
            //{
            //    Console.WriteLine($"StudentID: {std.StudentID}, StudentName: {std.StudentName}, Age: {std.Age}");
            //}

            //Console.WriteLine("\n------------------ Method Syntacs - Multiple where ------------------");
            //var filteredResult4 = studentArray.Where(s => s.Age > 12).Where(s => s.Age < 20);
            //foreach (var std in filteredResult4)
            //{
            //    Console.WriteLine($"StudentID: {std.StudentID}, StudentName: {std.StudentName}, Age: {std.Age}");
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
