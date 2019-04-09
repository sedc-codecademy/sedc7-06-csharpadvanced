using System;

namespace Generics
{
    //When deriving from a generic base class, you must provide a type argument instead of the base-class's 
    //generic type parameter

    //If you want the derived class to be generic then no need to specify type for the generic base class

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------------- int Generic --------------------");

            
            // Here when we are creating an instance of that generic class, we are specifying the type that
            // we want to use, in this example we are saying we want T to be of type INT

            MyGenericClass<int> intGeneric = new MyGenericClass<int>(10);
            int val = intGeneric.GenericMethod(200);

            Console.WriteLine("\n-------------------- string Generic --------------------");

            // You can see here we are using the same class, correct ? But this time we are saying
            // we want T to be of type string, so all of the T's in that class will be replaced with string
            MyGenericClass<string> strGeneric = new MyGenericClass<string>("Hello Generic World");
            string result = strGeneric.GenericMethod("Generic Parameter");

            strGeneric.GenericProperty = "This is a generic property example.";
            Console.WriteLine($"Generic Property: {strGeneric.GenericProperty}");

            Console.ReadLine();
        }
    }
}
