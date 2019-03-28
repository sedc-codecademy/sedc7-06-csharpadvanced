using System;

namespace ZooApp
{
    /// <summary>
    /// Class that will serve as a base class. I've added a new method called Walk().
    /// The problem is that any class that derives from Animal will be affected.
    /// Sometimes when we do this kind of change, the dependent classes needs to be changed
    /// or at least recompiled. We already have a class called Fish that inherits from Animal,
    /// and fish cannot walk.We will need to change our hierarchy and take that Walk method
    /// outside of Animal class and probably create another class called Mamel for example
    /// with capability to walk and then we can derive Dog,Cat from Mamel. Hierarchy is changed again.
    /// Thats the reason why inheritance can be misused and it results in large hierarchies
    /// and they are fragile becayse of the tight coupling(dependency) between classes.
    /// </summary>
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eat..");
        }

        public void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }

 
}
