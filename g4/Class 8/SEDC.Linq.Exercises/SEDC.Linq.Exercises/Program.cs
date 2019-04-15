using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Linq.Exercises
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }

        public Dog(string name, string color, int age, Race race)
        {
            Name = name;
            Color = color;
            Age = age;
            Race = race;
        }
    }

    public enum Race
    {
        Boxer,
        Bulldog,
        Collie,
        Dalmatian,
        Doberman,
        Mutt,
        Mudi,
        Pointer,
        Pug,
        Plott
    }

    public enum Job
    {
        Archivist,
        Waiter,
        Choreographer,
        Developer,
        Dentist,
        Sculptor,
        Interpreter,
        Barber
    }

    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Sculptor),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, Race.Collie),
                new Dog("Buddy", "Brown", 1, Race.Doberman),
                new Dog("Max", "Olive", 1, Race.Plott),
                new Dog("Archie", "Black", 2, Race.Mutt),
                new Dog("Oscar", "White", 1, Race.Mudi),
                new Dog("Toby", "Maroon", 3, Race.Bulldog),
                new Dog("Ollie", "Silver", 4, Race.Dalmatian),
                new Dog("Bailey", "White", 4, Race.Pointer),
                new Dog("Frankie", "Gray", 2, Race.Pug),
                new Dog("Jack", "Black", 5, Race.Dalmatian),
                new Dog("Chanel", "Black", 1, Race.Pug),
                new Dog("Henry", "White", 7, Race.Plott),
                new Dog("Bo", "Maroon", 1, Race.Boxer),
                new Dog("Scout", "Olive", 2, Race.Boxer),
                new Dog("Ellie", "Brown", 6, Race.Doberman),
                new Dog("Hank", "Silver", 2, Race.Collie),
                new Dog("Shadow", "Silver", 3, Race.Mudi),
                new Dog("Diesel", "Brown", 1, Race.Bulldog),
                new Dog("Abby", "Black", 1, Race.Dalmatian),
                new Dog("Trixie", "White", 8, Race.Pointer),
            };

            //==============================
            // TODO requirements
            //==============================

            //PART 1
            // 1. Structure the solution (create class library and move classes and enums accordingly)

            //PART 2
            // 1. Take person Cristofer and add Jack, Ellie and Hank as his dogs.
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            // 3. Add Trixie, Archie and Max as dogs from Erin
            // 4. Give Abby and Shadow to Amelia

            //PART 3 - LINQ
            // 1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            // 3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            // 4. Find and print all Freddy`s dogs names older than 1 year
            // 5. Find and print Nathen`s first dog
            // 6. Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

            //PART 4 - Be Creative, PLAY with LINQ :) 
        }
    }
}
