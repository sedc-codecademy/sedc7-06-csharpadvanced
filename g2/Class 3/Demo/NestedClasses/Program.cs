using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    public class OuterClass
    {
        private static string outerClassName = "OuterClass";
        public string OuterName { get; set; }
        public OuterClass(string name)
        {
            this.OuterName = name;
        }
        public void OuterMethod()
        {
            Console.WriteLine($"{this.OuterName}: Outer class method");
        }
        
        public class InnerClass
        {
            public string InnerName { get; set; }
            public InnerClass(string name)
            {
                this.InnerName = name;
            }
            public void InnerMethod()
            {
                Console.WriteLine($"{this.InnerName}: Inner class method");
            }

            public void OuterClassMembers()
            {
                Console.WriteLine($"{this.InnerName}: Outer class field - {OuterClass.outerClassName}");
            }
        }
    }

    public class ExternalClass : OuterClass
    {
        public ExternalClass(string name):base(name)
        {

        }
    }

    public class ExternalClass2 : OuterClass.InnerClass
    {
        public ExternalClass2(string name) : base(name)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Outer Class
            Console.WriteLine("----------------- Outer Class -----------------");
            OuterClass myOut = new OuterClass("MyOut");
            myOut.OuterMethod();

            //myOut.InnerMethod();

            OuterClass.InnerClass myInner = new OuterClass.InnerClass("MyInner");
            myInner.InnerMethod();

            myInner.OuterClassMembers();

            ExternalClass myExternal = new ExternalClass("MyExternal");
            myExternal.OuterMethod();

            //ExternalClass2 myExternal2 = new ExternalClass2("MyExternal2");
            //myExternal2.InnerMethod();


            #endregion

            Console.ReadLine();
        }
    }
}
