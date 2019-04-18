using System;
using System.Collections.Generic;
using System.Linq;
using LinqExercise.Models;
using LinqExercise.Services;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = PersonService.GetAllPeople();

            var dogs = DogService.GetAllDogs();

            #region Exercises

            //==============================
            // TODO LINQ expressions :)
            // Your turn guys...
            //==============================

            //PART 1
            // 1. Take person Cristofer and add Jack, Ellie, Hank and Tilly as his dogs.
            var cristofer = people.FirstOrDefault(x => x.FirstName == "Cristofer");

            if (cristofer != null)
            {
                List<string> crisDogs = new List<string> { "Jack", "Ellie", "Hank", "Tilly" };
                cristofer.Dogs = dogs.Where(x => crisDogs.Contains(x.Name)).ToList();
            }
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            var freddy = people.FirstOrDefault(x => x.FirstName == "Freddy");

            if (freddy != null)
            {
                List<string> fredDogs = new List<string> { "Oscar", "Toby", "Chanel", "Bo", "Scout" };
                freddy.Dogs = dogs.Where(x => fredDogs.Contains(x.Name)).ToList();
            }
            // 3. Add Trixie, Archie and Max as dogs from Erin.
            var erin = people.FirstOrDefault(x => x.FirstName == "Erin");

            if (erin != null)
            {
                List<string> erinDogs = new List<string> { "Trixie", "Archie", "Max" };
                erin.Dogs = dogs.Where(x => erinDogs.Contains(x.Name)).ToList();
            }
            // 4. Give Abby and Shadow to Amelia.
            var amelia = people.FirstOrDefault(x => x.FirstName == "Amelia");

            if (amelia != null)
            {
                List<string> ameliaDogs = new List<string> { "Abby", "Shadow" };
                amelia.Dogs = dogs.Where(x => ameliaDogs.Contains(x.Name)).ToList();
            }
            // 5. Take person Larry and Zoe, Ollie as his dogs.
            var larry = people.FirstOrDefault(x => x.FirstName == "Larry");

            if (larry != null)
            {
                List<string> larryDogs = new List<string> { "Zoe", "Ollie" };
                larry.Dogs = dogs.Where(x => larryDogs.Contains(x.Name)).ToList();
            }
            // 6. Add all retrievers to Erika.
            var erika = people.FirstOrDefault(x => x.FirstName == "Erika");

            if (erika != null)
            {
                erika.Dogs = dogs.Where(x => x.Race == Race.Retriever).ToList();
            }

            // 7. Erin plus has Chet and Ava.
            if (erin != null)
            {
                List<string> erinDogs = new List<string> { "Chet", "Ava" };
                erin.Dogs.AddRange(dogs.Where(x => erinDogs.Contains(x.Name)).ToList());
            }
            // 8. Diesel and Rigby are August's dogs 
            var august = people.FirstOrDefault(x => x.FirstName == "August");

            if (august != null)
            {
                List<string> augustDogs = new List<string> { "Diesel", "Rigby" };
                august.Dogs = dogs.Where(x => augustDogs.Contains(x.Name)).ToList();
            }

            //PART 2 - LINQ
            // 1. Find and print all persons firstnames starting with 'R', ordered by age - DESCENDING ORDER.
            List<Person> result1 =
                people.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age).ToList();
            Console.WriteLine("-------Result from query 1 ----------");
            PrintPeople(result1);
            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by age - ASCENDING ORDER.
            List<Dog> result2 = dogs.Where(x => x.Color == Color.Brown && x.Age >= 3).OrderBy(x => x.Age).ToList();
            Console.WriteLine("-------Result from query 2 ----------");
            PrintDogs(result2);
            // 3. Find and print all persons with more than 2 dogs, ordered by name - DESCENDING ORDER.
            List<Person> result3 = people.Where(x => x.Dogs != null && x.Dogs.Count > 2).OrderByDescending(x => x.FirstName).ToList();
            Console.WriteLine("-------Result from query 3 ----------");
            PrintPeople(result3);
            // 4. Find and print all persons names, last names and job positions that have just one race type dogs.
            List<Person> result4 = people
                .Where(x => x.Dogs != null && x.Dogs.Select(y => y.Race).Distinct().Count() == 1)
                .ToList();
            Console.WriteLine("-------Result from query 4 ----------");
            PrintPeople(result4);

            // 5. Find and print all Freddy`s dogs names older than 1 year, grouped by dogs race.
            List<IGrouping<Race, Dog>> result5 = people.First(x => x.FirstName == "Freddy").Dogs.Where(x => x.Age > 1).GroupBy(x => x.Race)
                .ToList();

            Console.WriteLine("-------Result from query 5 ----------");
            foreach (var group in result5)
            {
                Console.WriteLine($"Race: {group.Key}");

                foreach (var dog in group)
                {
                    Console.WriteLine($"{dog.Name} {dog.Race} {dog.Age}");
                }
            }

            // 6. Find and print last 10 persons grouped by their age.
            people.Reverse();
            var lastTen = people.Take(10);
            var groupByAge = lastTen.GroupBy(x => x.Age).ToList();

            Console.WriteLine("-------Result from query 6 ----------");
            foreach (var group in groupByAge)
            {
                Console.WriteLine($"Age group: {group.Key}");

                foreach (var person in group)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
                }
            }

            people.Reverse();

            //6.1 Take last 10 without using reverse
            var count = people.Count;
            var result6 = people.Skip(count - 10).GroupBy(x => x.Age).ToList();

            Console.WriteLine("-------Result from query 6 ----------");
            foreach (var group in result6)
            {
                Console.WriteLine($"Age group: {group.Key}");

                foreach (var person in group)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
                }
            }

            // 7. Find and print all dogs names from Cristofer, Freddy, Erin and Amelia, grouped by color and ordered by name - ASCENDING ORDER.
            var filteredPeople = new List<string> {"Cristofer", "Freddy", "Erin", "Amelia"};
            var dogGroups = people.Where(x => filteredPeople.Contains(x.FirstName)).SelectMany(x => x.Dogs)
                .OrderBy(x => x.Name).GroupBy(x => x.Color).OrderBy(x => x.Key).ToList();

            Console.WriteLine("-------Result from query 7 ----------");
            foreach (var group in dogGroups)
            {
                Console.WriteLine($"Color: {group.Key}");

                foreach (var dog in group)
                {
                    Console.WriteLine($"{dog.Name} {dog.Color}");
                }
            }

            //7.1 Do the grouping first then the ordering
            var dogGroups1 = people.Where(x => filteredPeople.Contains(x.FirstName)).SelectMany(x => x.Dogs)
                .GroupBy(x => x.Color).OrderBy(x => x.Key).ToList();

            Console.WriteLine("-------Result from query 7 ----------");
            foreach (var group in dogGroups1)
            {
                Console.WriteLine($"Color: {group.Key}");

                foreach (var dog in group.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{dog.Name} {dog.Color}");
                }
            }


            // 8. Find and print all people that have same dogs races and order them by name length ASCENDING, then by age DESCENDING.
            List<KeyValuePair<Person, Race>> tempList = new List<KeyValuePair<Person, Race>>();
            foreach (var person in people)
            {
                List<KeyValuePair<Person, Race>> tempPerPersonList = new List<KeyValuePair<Person, Race>>();

                if (person.Dogs != null)
                {
                    foreach (var dog in person.Dogs)
                    {
                        if (tempPerPersonList.Any(x => x.Value == dog.Race))
                            continue;

                        tempPerPersonList.Add(new KeyValuePair<Person, Race>(person, dog.Race));
                    }

                    tempList.AddRange(tempPerPersonList);
                }
            }

            var groupByRace = tempList.GroupBy(x => x.Value);

            Console.WriteLine("-------Result from query 8 ----------");
            foreach (var group in groupByRace)
            {
                Console.WriteLine($"Race: {group.Key}");

                foreach (var person in group.Select(x => x.Key).OrderBy(x => x.FirstName.Length).ThenByDescending(x => x.Age))
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
                }
            }
            // 9. Find the last dog of Amelia and print all dogs from other persons older than Amelia's dog, ordered by dogs age DESCENDING.
            Person ameliaP = people.FirstOrDefault(x => x.FirstName == "Amelia");

            if (ameliaP != null && ameliaP.Dogs != null)
            {
                Dog lastAmeliaDog = ameliaP.Dogs.LastOrDefault();

                if (lastAmeliaDog != null)
                {
                    var allOtherDogs = people.Where(x => x.FirstName != ameliaP.FirstName && x.Dogs != null).SelectMany(x => x.Dogs)
                        .Where(x => x.Age > lastAmeliaDog.Age).OrderByDescending(x => x.Age)
                        .ToList();

                    Console.WriteLine("-------Result from query 9 ----------");
                    PrintDogs(allOtherDogs);
                }
            }
            
            // 10. Find all developers older than 20 with more than 1 dog that contains letter 'e' in the name and print their names and job positions.

            List<Person> result10 = people.Where(x =>
                x.Occupation == Job.Developer && x.Age > 20 && x.Dogs != null &&
                x.Dogs.Count(y => y.Name.Contains("e")) > 1).ToList();

            Console.WriteLine("-------Result from query 10 ----------");
            PrintPeople(result10);

            #endregion

            Console.ReadKey();
        }

        public static void PrintPeople(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age} {person.Occupation}");
            }
        }

        public static void PrintDogs(List<Dog> dogs)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog.Name} {dog.Age}");
            }
        }
    }
}