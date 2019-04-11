using System.Collections.Generic;

namespace LINQExercises
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
        public Color Color { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }

        public Dog(string name, Color color, int age, Race race)
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
        Plott,
        Husky,
        Cocker,
        Chihuahua,
        Retriever,
        Inu,
        Mastiff
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
        Barber,
        Dietician,
        Lecturer,
        Auctioneer,
        Designer,
        Tattooist
    }

    public enum Color
    {
        Brown,
        Black,
        White,
        Golden,
        Silver,
        Mix,
        Olive,
        Maroon
    }

    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Designer),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Designer),
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
                new Person("Freddy", "Gordon", 26, Job.Interpreter),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 22, Job.Dentist),
                new Person("William", "Favorite", 29, Job.Waiter),
                new Person("James", "Ferguson", 34, Job.Tattooist),
                new Person("Julian", "Stanley", 47, Job.Auctioneer),
                new Person("Tom", "Barnes", 19, Job.Barber),
                new Person("James", "Rodriguez", 55, Job.Dentist),
                new Person("Jean", "Gaylord", 23, Job.Archivist),
                new Person("Erika", "Lawrence", 67, Job.Sculptor),
                new Person("Vanessa", "Braman", 33, Job.Lecturer),
                new Person("Donna", "Snider", 36, Job.Sculptor),
                new Person("Larry", "Ellington", 41, Job.Dietician)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Charlie", Color.Black, 3, Race.Collie),
                new Dog("Buddy", Color.Brown, 1, Race.Doberman),
                new Dog("Max", Color.Olive, 1, Race.Plott),
                new Dog("Archie", Color.Black, 2, Race.Doberman),
                new Dog("Oscar", Color.Mix, 1, Race.Mudi),
                new Dog("Toby", Color.Silver, 3, Race.Bulldog),
                new Dog("Ollie", Color.Golden, 4, Race.Husky),
                new Dog("Bailey", Color.White, 4, Race.Pointer),
                new Dog("Frankie", Color.Olive, 2, Race.Retriever),
                new Dog("Jack", Color.Black, 5, Race.Dalmatian),
                new Dog("Chanel", Color.White, 1, Race.Pug),
                new Dog("Henry", Color.Black, 7, Race.Plott),
                new Dog("Bo", Color.Maroon, 3, Race.Boxer),
                new Dog("Scout", Color.Mix, 2, Race.Boxer),
                new Dog("Ellie", Color.Brown, 6, Race.Doberman),
                new Dog("Hank", Color.Silver, 2, Race.Collie),
                new Dog("Shadow", Color.Brown, 3, Race.Mudi),
                new Dog("Diesel", Color.Golden, 1, Race.Bulldog),
                new Dog("Abby", Color.Mix, 1, Race.Dalmatian),
                new Dog("Trixie", Color.Maroon, 6, Race.Mudi),
                new Dog("Alfi", Color.Black, 3, Race.Chihuahua),
                new Dog("Benji", Color.Brown, 2, Race.Cocker),
                new Dog("Ava", Color.Golden, 4, Race.Bulldog),
                new Dog("Chet", Color.Olive, 1, Race.Boxer),
                new Dog("Rigby", Color.Mix, 5, Race.Collie),
                new Dog("Sam", Color.Silver, 1, Race.Inu),
                new Dog("Tilly", Color.White, 3, Race.Retriever),
                new Dog("Yumi", Color.White, 4, Race.Retriever),
                new Dog("Zoe", Color.Brown, 9, Race.Husky),
                new Dog("Gonzo", Color.Mix, 1, Race.Doberman),
            };

            #region Exercises

            //==============================
            // TODO LINQ expressions :)
            // Your turn guys...
            //==============================

            //PART 1
            // 1. Structure the solution (create class library and move classes and enums accordingly)

            //PART 2
            // 1. Take person Cristofer and add Jack, Ellie, Hank and Tilly as his dogs.
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            // 3. Add Trixie, Archie and Max as dogs from Erin.
            // 4. Give Abby and Shadow to Amelia.
            // 5. Take person Larry and Zoe, Ollie as his dogs.
            // 6. Add all retrievers to Erika.
            // 7. Erin has Chet and Ava and now give Diesel to August thah previously has just Rigby

            //PART 3 - LINQ
            // 1. Find and print all persons firstnames starting with 'R', ordered by age - DESCENDING ORDER.
            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by age - ASCENDING ORDER.
            // 3. Find and print all persons with more than 2 dogs, ordered by name - DESCENDING ORDER.
            // 4. Find and print all persons names, last names and job positions that have just one race type dogs.
            // 5. Find and print all Freddy`s dogs names older than 1 year, grouped by dogs race.
            // 6. Find and print last 10 persons grouped by their age.
            // 7. Find and print all dogs names from Cristofer, Freddy, Erin and Amelia, grouped by color and ordered by name - ASCENDING ORDER.
            // 8. Find and persons that have same dogs races and order them by name length ASCENDING, then by age DESCENDING.
            // 9. Find the last dog of Amelia and print all dogs form other persons older than Amelia, ordered by dogs age DESCENDING.
            // 10. Find all developers older than 20 with more than 1 dog that contains letter 'e' in the name and print their names and job positions.

            #endregion
        }
    }
}