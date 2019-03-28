using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    // Our class
    public class Animal
    {
        // Properties
        // We can use: Primitve types, Enum, Class, Collection
        // Short hand for property : prop + tab + tab
        
        // Primitive types
        public string Name { get; set; }
        public int Age { get; set; }

        // Complex types
        public Type Type { get; set; } // Enum

        // We use List when we need multiple values in a property
        // Inside the < > in the list we write the type of
        // the stuff that we need to add pultiple in the property
        // List<Food> - we tell C# that at some point here
        // we will have a collection of objects from class Food
        // WE DO NOT CREATE A NEW LIST WITH WRITING List<Food>
        // null is by default
        public List<Food> FavoriteFoods { get; set; } // Collection of objects from the class Food
        // If property or method does not have access modifier
        // private is the default one
        //string Type { get; set; }

        // Constructors 
        // Constructor is a method
        // Shorthand for constructor : ctor + tab + tab
        // It is called when we create a new object => new Animal() <- this is the call
        // We can have multiple constructors

        // If you don't add a constructor .net framework writes this code:
        //public Animal() { }

        // Empty Constructor
        public Animal() // new Animal();
        {
            Console.WriteLine("Empty is called!");
            // We validate if the name is correct


            // We put default value for Age
            Age = 0;

            // If we don't initialize this it will be null
            // We can't call .Add on null
            // We can't call .Count on null etc.
            // If we call .Add or anything else on null
            // We will get null refference exception

            // This line creates an empty list so we don't get this exception
            FavoriteFoods = new List<Food>();
            int x = 5;
        }

        // Setter Constructor 
        public Animal(string name, 
            int age, Type type, 
            List<Food> favFoods) // new Animal("spark", 2, Type.Sveshtojad, foods);
        {
            Console.WriteLine("Setter 1 is called!");
            if (name.Length < 2)
            {
                throw new Exception("Not a valid name!");
            }
            Name = name;
            Age = age;
            Type = type;
            FavoriteFoods = favFoods;
        }
        
        public Animal(string name, int age, Type type)
        {
            Console.WriteLine("Setter 2 is called!");
            Name = name;
            Age = age;
            Type = type;
            FavoriteFoods = new List<Food>();
        }

        // Methods
        // Virtual keyword means that we give all child
        // classes the abbility to change this for them selves
        // The main method is not changed
        public virtual void Eat(string food)
        {
            Console.WriteLine($"The animal {Name} is eating {food}");
        }
    }
}
