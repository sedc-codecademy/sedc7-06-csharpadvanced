using System;

namespace CSharpAdvanced_Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Getters and Setters
            //Shortest get and set methods
            Class1 c1 = new Class1();
            c1.MyProperty = "first";  //set
            //c1.MyProperty2 = "fist private"; //the set accessor is inaccessable
            Console.WriteLine(c1.MyProperty); //get

            //Shorter get and set methods
            Class2 c2 = new Class2();
            c2.MyProperty = "second"; //set
            Console.WriteLine(c2.MyProperty); //get

            //the traditional/old way of getters and setters
            Class3 c3 = new Class3();
            c3.SetMyProp("third");
            Console.WriteLine(c3.GetMyProp());
            #endregion
        }
    }
}