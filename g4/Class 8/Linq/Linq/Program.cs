using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{ 
    static class Program
    {
        public static void PrintList(this List<Student> students)
        {
            Console.WriteLine("Printing students...");
            Console.WriteLine("------------------------------");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
        public static void PrintList(this List<Subject> subjects)
        {
            Console.WriteLine("Printing subjects...");
            Console.WriteLine("------------------------------");
            foreach (Subject subject in subjects)
            {
                Console.WriteLine($"{subject.Title}, {subject.Type}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        public static void PrintList<T>(this List<T> items)
        {
            Console.WriteLine("Printing subjects...");
            Console.WriteLine("------------------------------");
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>()
            {
                new Student(12, "Bob", "Bobsky", 29, false),
                new Student(22, "Jill", "Wayne", 36, true),
                new Student(27, "Greg", "Gregsky", 45, false),
                new Student(29, "Anne", "Willson", 31, true),
                new Student(30, "Liana", "Wurtz", 25, false),
                new Student(41, "Bill", "Zu", 38, false)
            };
            List<Subject> Subjects = new List<Subject>()
            {
                new Subject("C# Basic", 10, 24, Academy.Programming ),
                new Subject("C# Advanced", 15, 26, Academy.Programming ),
                new Subject("JavaScript", 25, 22, Academy.Programming ),
                new Subject("Photoshop", 12, 18, Academy.Design ),
                new Subject("Illustrator", 12, 18, Academy.Design ),
                new Subject("Networks Basic", 8, 12, Academy.Networks ),
                new Subject("Networks Advanced", 16, 10, Academy.Networks )
            };
            Students[0].Subjects = new List<Subject>() { Subjects[0], Subjects[2], Subjects[3], Subjects[4] };
            Students[1].Subjects = new List<Subject>() { Subjects[3], Subjects[4], Subjects[5], Subjects[1] };
            Students[2].Subjects = new List<Subject>() { Subjects[5], Subjects[6] };
            Students[3].Subjects = new List<Subject>() { Subjects[3], Subjects[4] };
            Students[4].Subjects = new List<Subject>() { Subjects[1], Subjects[2], Subjects[3], Subjects[5] };
            Students[5].Subjects = new List<Subject>() { Subjects[2] };

            // LINQ
            // SQL Like
            IEnumerable<Student> findBobsSqlQuery = from x in Students
                                                    where x.FirstName == "Bob"
                                                    select x;
            // Lambda
            IEnumerable < Student > findBobsLambdaQuery = Students
                .Where(x => x.FirstName == "Bob");

            // SQL Like complex
            IEnumerable<Student> ptProgrSqlQuery = from x in Students
                where x.IsPartTime
                where (from y in x.Subjects
                        where y.Type == Academy.Programming
                        select y).ToList().Count != 0
                select x;
            // Lambda complex
            IEnumerable<Student> ptProgrLambdaQuery = Students.Where(x => x.IsPartTime)
                .Where(x => x.Subjects
                    .Where(y => y.Type == Academy.Programming)
                .ToList().Count != 0);

            // Where
            // imame primer, vidi pogore

            // Select
            List<string> firstNames = Students.Select(x => x.FirstName).ToList();
            List<string> studentFullNames = Students.Select(x => $"{x.FirstName} {x.LastName} {x.Age}").ToList();
            //firstNames.PrintList();
            //studentFullNames.PrintList();

            // First / Single / Last / ByDefault
            // First => Gets first element, if no elements it will throw error
            // FirstOrDefault => Gets first element, if no elements will return default and will not throw error
            // Single => Gets the only element from list, if more than one elements or no elements will throw error
            // SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error

            List<string> emptyListOfStrings = new List<string>();
            List<int> emptyListOfNums = new List<int>();
            List<Student> emptyListOfStudents = new List<Student>();
            //Console.WriteLine(emptyListOfStrings.First());
            //Console.WriteLine(emptyListOfStrings.FirstOrDefault());
            //Console.WriteLine(emptyListOfNums.FirstOrDefault());
            //Console.WriteLine(emptyListOfStudents.FirstOrDefault().ToString());
            
            // SelectMany
            // It flatens list of lists
            // Flattening => When we make one list out of multiple lists of the same type

            // Select
            List<List<Subject>> partTimeSubjectsSelect = Students
                .Where(x => x.IsPartTime)
                .Select(x => x.Subjects).ToList();

            // SelectMany
            List<Subject> partTimeSubjectsMany = Students
                .Where(x => x.IsPartTime)
                .SelectMany(x => x.Subjects).ToList();
            // Example with index
            // The index is called on the List, not on the Linq query
            Subject partTimeSubject = Students
               .Where(x => x.IsPartTime)
               .SelectMany(x => x.Subjects).ToList()[0];
            //partTimeSubjectsMany.PrintList();

            // Distinct
            List<Subject> distinctSubjects = partTimeSubjectsMany.Distinct().ToList();
            //distinctSubjects.PrintList();
            //Console.WriteLine(distinctSubjects.Count);

            // Any
            bool isBob = Students.Any(x => x.FirstName == "Bob");
            bool isDwayne = Students.Any(x => x.FirstName == "Dwayne");
            //Console.WriteLine(isBob);
            //Console.WriteLine(isDwayne);

            // All
            bool areThereShortNames = Students
                .All(x => x.FirstName.Length >= 3);
            bool areAllFourChar = Students
                .All(x => x.FirstName.Length == 4);

            //Console.WriteLine(areThereShortNames);
            //Console.WriteLine(areAllFourChar);

            // Except
            List<Student> exceptPartTime = Students
                .Except(Students.Where(x => x.IsPartTime)).ToList();
            exceptPartTime.PrintList();

            // OrderBy / OrderByDescending / ThenBy / ThenByDescending
            List<Student> sortedStudents = Students.OrderBy(x => x.FirstName).ToList();
            List<Student> sortedStudentsDesc = Students.OrderByDescending(x => x.FirstName).ToList();
            List<Student> sortedStudentsThen = Students
                .OrderBy(x => x.FirstName).ThenBy(x => x.Age).ThenBy(x => x.Id).ToList();
            
            Console.ReadLine();
        }
    }
}
