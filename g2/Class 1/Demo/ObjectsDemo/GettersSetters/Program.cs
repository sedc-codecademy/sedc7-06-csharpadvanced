using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    public class Class1
    {
        public string MyProperty { get; set; } //shortest get and set methods definition
        public string MyProperty2 { get; private set; } //private set
    }
    public class Class2
    {
        private string _myProperty;
        public string MyProperty
        {
            get { return _myProperty; }  //shorter form of the get method
            set { this._myProperty = value; } //shorter form of the set method
        }
    }
    public class Class3
    {
        private string _myProperty;

        public string GetMyProp() //this is the get method, in this case it returns string
        {
            return this._myProperty;
        }
        public void SetMyProp(string value) //this is the set method, it has void type
        {
            this._myProperty = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Getters and Setters
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Shortest get and set methods");
            //Class1 c1 = new Class1();
            //c1.MyProperty = "MyProperty 1";  //set
            ////c1.MyProperty2 = "MyProperty 1 private"; //the set accessor is inaccessable
            //Console.WriteLine(c1.MyProperty); //get

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Shorter get and set methods");
            //Class2 c2 = new Class2();
            //c2.MyProperty = "MyProperty 2"; //set
            //Console.WriteLine(c2.MyProperty); //get

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("the traditional/old way of getters and setters");
            Class3 c3 = new Class3();
            c3.SetMyProp("MyProperty 3");
            Console.WriteLine(c3.GetMyProp());
            #endregion

            Console.ReadLine();
        }
    }
}
