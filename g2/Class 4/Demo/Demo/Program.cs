using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Cat
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }

        private int _objectsInstantiated = 0;
        public int ObjectsInstantiated
        {
            get { return _objectsInstantiated; }
            set { this._objectsInstantiated = value; }
        }

        private static int _objectsInstantiatedStatic = 0;
        public static int ObjectsInstantiatedStatic
        {
            get { return _objectsInstantiatedStatic; }
            //set { _objectsInstantiatedStatic = value; }
        }
        
        private static int _sharedVariable = 5;
        public static int SharedVariable
        {
            get { return _sharedVariable; }
            set { _sharedVariable = value; }
        }
        
        public void Info()
        {
            Console.WriteLine($"Named cat: {Name}");
            Console.WriteLine($"ObjectsInstantiatedStatic: {ObjectsInstantiatedStatic}");
            Console.WriteLine($"ObjectsInstantiated: {ObjectsInstantiated}");
            Console.WriteLine($"SharedVariable: {SharedVariable}");
        }
        public Cat(string name)
        {
            Console.WriteLine($"---------------- {name} ----------------");
            this.Name = name;

            Console.WriteLine("---------------- INFO before incrementation ----------------");
            Info();

            _objectsInstantiatedStatic++;
            ObjectsInstantiated++;

            Console.WriteLine("---------------- INFO after incrementation ----------------");
            Info();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            1. Static Member
            - A non-static class can contain static methods, fields, properties
            - The static member is callable on a class and is always accessed by the class name
            - Only one copy of a static member exists, regardless of how many instances of the class are created
            - Static methods and properties cannot access non-static fields and they cannot access an instance variable of any object
            2. Two common uses of static fields are
            - To keep a count of the number of objects that have been instantiated
            - To store a value that must be shared among all instances.
            */
            #endregion
            
            Cat catTom = new Cat("Tom");
            Cat catGarfield = new Cat("Garfield");

            Console.WriteLine("---------------- Static Properties ----------------");
            Console.WriteLine($"ObjectsInstantiatedStatic: {Cat.ObjectsInstantiatedStatic}");
            Console.WriteLine($"SharedVariable: {Cat.SharedVariable}");

            Console.WriteLine();
            Console.WriteLine("---------------- Changeing sharedVariable to 10 ----------------");
            Cat.SharedVariable = 10;

            catTom.Info();
            catGarfield.Info();

            Console.ReadLine();
        }
    }
}
