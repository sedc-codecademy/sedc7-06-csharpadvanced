using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Empty constructor without setting properties immedietly
            Animal dzeki = new Animal() { Name = "Bob"};
            dzeki.Name = "Dzeki";
            dzeki.Type = Entities.Type.Seshtojad;

            // Empty constructor with setting properties immedietly
            Animal klementina = new Animal() {
                Name = "Klementina",
                Type = Entities.Type.Seshtojad,
                Age = 9,
                FavoriteFoods = new List<Food>() {
                    new Food(){Name = "Morkov"},
                    new Food(){Name = "Muva", Quantity = 5}
                    }
                };
            List<Food> foodz = new List<Food>()
            {
                new Food(){Name = "Pet Food"},
                new Food(){Name = "Fish", Quantity = 2},
                new Food(){Name = "Leftovers"}
            };

            // Constructor setting 1 
            Animal miau = new Animal("Miau", 2, Entities.Type.Seshtojad, foodz);

            // Constructor setting 2
            Animal bratMuNaMiau = new Animal("Bratot",
                1, Entities.Type.Trevojad);
            Console.WriteLine("--------- INHERITANCE --------");
            Dog dzuki = new Dog()
            {
                Name = "Dzuki",
                Race = "Dzukche",
                IsPet = false
            };
            Dog rex = new Dog("Rex", "German Shepard", "brown");
            Console.ReadLine();

        }
    }
}
