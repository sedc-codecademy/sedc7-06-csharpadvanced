using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void DelegateMethod();

namespace Delegates_2 {

    public delegate void DelegateMethod();

    class Program {
        //Declaring the delegate here in class Program:
        delegate int DelegateIntMethod();

        static void Main(string[] args) {
            //Instantiation of the DelegateMethod() delegate
            DelegateMethod del1, del2, del3, del4, del5;
            del1 = new DelegateMethod(Method1);
            del2 = new DelegateMethod(Method2);
            del3 = new DelegateMethod(Method3);

            //Call the delegates:
            Console.WriteLine("del1, del2, del3: ");
            del1();
            del2();
            del3();

            
            Console.WriteLine("del4: ");
            del4 = del1 + del2 + del3 - del2 ;
            del4();

            
            Console.WriteLine("del5: ");
            del5 = new DelegateMethod(Method1); 
            //Add pointer to del2, i.e. to Method2
            del5 += del2;
            del5();
            Console.WriteLine("------------");
            del5 -= del1;
            del5();
            
            Console.WriteLine();

            Console.WriteLine("Delegates can return values, e.g. Int:");
            DelegateIntMethod IntDelegate;
            IntDelegate = new DelegateIntMethod(IntMethod1);
            IntDelegate += IntMethod2;
            int delegateValue = IntDelegate();
            Console.WriteLine("Current value the delegate returns {0}",delegateValue);
            IntDelegate -= IntMethod2;
            delegateValue = IntDelegate();
            Console.WriteLine("Current value the delegate returns {0}", delegateValue);
             
        }

        //Delegate functions - void
        public static void Method1() {
            Console.WriteLine("Metod1 invoked.");
        }
        public static void Method2() {
            Console.WriteLine("Metod2 invoked.");
        }
        public static void Method3() {
            Console.WriteLine("Metod3 invoked.");
        }
        public static void Method4() {
            Console.WriteLine("Metod4 invoked.");
        }

        //Delegate functions - int
        public static int IntMethod1() { return 1; }
        public static int IntMethod2() { return 2; }
    }
}
