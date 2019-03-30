using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract
{
    abstract class Animal
    {        
        public abstract bool Feathers { get; set; }
        //You can define and implememnt a virtual method in abstrct classes
        public virtual string Describe()
        {
            return "Basic info about Animals.";
        }
        //Can only define an abstract method, but without implementation
        public abstract string Features();
        public abstract bool HasFeathers();
    }
    class Dog : Animal
    {
        public override bool Feathers { get; set; } = false;
        public override string Describe()
        {
            return base.Describe() + ": This is about Dogs.";
        }
        public override string Features()
        {
            return "Can bark.";
        }
        public override bool HasFeathers()
        {
            return false;
        }
        //You cannot declare an abstract method outside an abstract class 
    }
    class Bird : Animal
    {
        public override bool Feathers { get; set; } = true;
        public override string Describe()
        {
            return "This is the Birds ";
        }
        public override string Features()
        {
            return "Can fly.";
        }
        public override bool HasFeathers()
        {
            return true;
        }
        //You cannot declare an abstract method outside an abstract class 
    }
}
