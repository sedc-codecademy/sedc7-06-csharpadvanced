using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces
{
    interface IAnimal
    {
        string Name { get; set; }

        void Eat();

        void Cry();
    }
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
            //Console.WriteLine("Abstract Animal");
        }

        public Animal(string name)
        {
            Console.WriteLine($"Abstract Named Animal: {name}");
            this.Name = name;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"Abstract Animal {this.Name} Eat: normal food");
        }

        public abstract void Cry(); 
    }

    class Dog1 : Animal
    {
        public Dog1()
        {
            Console.WriteLine("Dog1");
        }

        public Dog1(string name)
        {
            Console.WriteLine($"Named Dog1: {name}");
            this.Name = name;
        }

        public override void Cry()
        {
            Console.WriteLine($"Dog {this.Name} Cry: Woof");
        }
    }
    class Cat1 : Animal
    {
        public Cat1()
        {
            Console.WriteLine("Cat1");
        }

        public Cat1(string name)
        {
            Console.WriteLine($"Named Cat1: {name}");
            this.Name = name;
        }

        public override void Cry()
        {
            Console.WriteLine($"Cat {this.Name} Cry: Meow");
        }

        public override void Eat()
        {
            Console.WriteLine($"Cat {this.Name} Eat: Cat food");
        }
    }

    class Dog2 : IAnimal
    {
        public string Name { get; set; }

        public Dog2()
        {
            Console.WriteLine("Dog2");
        }

        public Dog2(string name)
        {
            Console.WriteLine($"Named Dog2: {name}");
            this.Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"Dog {this.Name} Eat: Doog food");
        }

        public void Cry()
        {
            Console.WriteLine($"Dog {this.Name} Cry: Woof");
        }
    }
    class Cat2 : IAnimal
    {
        public string Name { get; set; }

        public Cat2()
        {
            Console.WriteLine("Cat2");
        }

        public Cat2(string name)
        {
            Console.WriteLine($"Named Cat2: {name}");
            this.Name = name;
        }

        public void Cry()
        {
            Console.WriteLine($"Cat {this.Name} Cry: Meow");
        }

        public void Eat()
        {
            Console.WriteLine($"Cat {this.Name} Eat: Cat food");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Recap

            /*
            
            Abstract klasi
            - Klasa od koja sto nemoze da se instancira objekt
            - Moze da ima fildovi, propertija i metodi
            - Metodite moze da bidat implementirani, da bidat virtuelni ili da bidat abstraktni
            - Izvedenata klasa (ako ne e abstract) mora da gi implementira abstraktnite metodi, moze i ne mora da gi overide-uva virtuelnite metodi

            Interfejsi
            - Dogovor, Pravilo vo koj se definiraat metodite SHTO treba da postojat a ne KAKO treba da se implementiraat
            - Nemoze da se instancira objekt
            - Nemoze da ima fildovi

            Paradigmi na OOP
            1. Abstrakcija, Encapsulacija
                - Koga dizjnirame klasi razmisluvame da ja podelime na 2 dela privaten i javen
                - Javniot del e toj sto ke go gleda nadvoresniot svet i toj ne bi trebalo da se menuva
                - Privatniot del e skrien (abstrahiran, enkapsuliran) i toj bi mozel da se menuva vo idnina, za nadvoresniot svet klasata ke ostane ista
            2. Nasleduvanje
                - Kreiranje klasa od postoecka klasa (nasledena i osnovna klasa)
                - Reiskoristlivos na kod
                - Hierarhiska pripadnost
            3. Polimorfizam
                - Povekje formi
                - Staticen - overload na metodi i operatori, za vreme na kompajliranje
                - Dinamicen - razlicna implementacija na metodi, za vreme na izvrsuvanje
                - Implementacija - pri nasleduvanje, abstract klasi, interfejsi
            */

            #endregion

            #region Abstract Class
            //Console.WriteLine("------------- AbstractClasses -------------");

            ////Animal myAnimal = new Animal();

            //Animal dogSparky = new Dog1("Sparky");
            //dogSparky.Eat();
            //dogSparky.Cry();
            //Console.WriteLine();

            //Animal catTom = new Cat1("Tom");
            //catTom.Eat();
            //catTom.Cry();

            #endregion

            #region Interfaces
            //Console.WriteLine("------------- Interfaces -------------");

            //IAnimal dogSparky = new Dog2("Sparky");
            //dogSparky.Eat();
            //dogSparky.Cry();
            //Console.WriteLine();

            //IAnimal catTom = new Cat2("Tom");
            //catTom.Eat();
            //catTom.Cry();

            #endregion

            #region Polimorphism Abstract
            //Console.WriteLine("------------- Polimorphism Abstract -------------");

            //Animal[] myAnimals = new Animal[2];
            //Animal dogSparky = new Dog1("Sparky");
            //myAnimals[0] = dogSparky;

            //Animal catTom = new Cat1("Tom");
            //myAnimals[1] = catTom;

            //foreach (Animal tempAnimal in myAnimals)
            //{
            //    tempAnimal.Eat();
            //    tempAnimal.Cry();
            //}

            #endregion

            #region Polimorphism Interfaces
            Console.WriteLine("------------- Polimorphism Interfaces -------------");

            IAnimal[] myAnimals = new IAnimal[2];
            IAnimal dogSparky = new Dog2("Sparky");
            myAnimals[0] = dogSparky;

            IAnimal catTom = new Cat2("Tom");
            myAnimals[1] = catTom;

            foreach (IAnimal tempIAnimal in myAnimals)
            {
                tempIAnimal.Eat();
                tempIAnimal.Cry();
            }

            #endregion

            Console.ReadLine();
        }
    }
}
