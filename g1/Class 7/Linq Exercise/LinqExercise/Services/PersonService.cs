using System.Collections.Generic;
using LinqExercise.Models;

namespace LinqExercise.Services
{
    public static class PersonService
    {
        public static List<Person> GetAllPeople()
        {
            return new List<Person>()
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
        }
    }
}
