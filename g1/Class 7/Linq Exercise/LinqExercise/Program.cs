using System.Collections.Generic;
using LinqExercise.Services;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = PersonService.GetAllPeople();

            var dogs = PersonService.GetAllPeople();

            #region Exercises

            //==============================
            // TODO LINQ expressions :)
            // Your turn guys...
            //==============================

            //PART 1
            // 1. Take person Cristofer and add Jack, Ellie, Hank and Tilly as his dogs.
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            // 3. Add Trixie, Archie and Max as dogs from Erin.
            // 4. Give Abby and Shadow to Amelia.
            // 5. Take person Larry and Zoe, Ollie as his dogs.
            // 6. Add all retrievers to Erika.
            // 7. Erin has Chet and Ava and now give Diesel to August thah previously has just Rigby

            //PART 2 - LINQ
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