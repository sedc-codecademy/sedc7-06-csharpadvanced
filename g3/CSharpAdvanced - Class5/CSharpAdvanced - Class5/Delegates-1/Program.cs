using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_1 {
    class Program {
        // Define a delegate
        public delegate void DelegatePointsTo(string msg);
        public delegate int IntDelegate(int broj);

        static void Main(string[] args) {
            DelegatePointsTo delegate1 = new DelegatePointsTo(Hello);
            delegate1("Hello, calling Hello()");
            DelegatePointsTo delegate2 = new DelegatePointsTo(Pozdrav);
            delegate2("Now calling Pozdrav()");

            DelegatePointsTo delegate12 = delegate1 + delegate2;
            delegate12("1-2");            

            IntDelegate intDel = new IntDelegate(RerturnInt);
            int var = intDel(123);
            Console.WriteLine(var);
        }
        
        //Delegate functions:
        //Hello()
        public static void Hello(string strMsg) {
            Console.WriteLine(strMsg); }
        //Pozdrav()
        public static void Pozdrav(string pozMsg) {
            Console.WriteLine(pozMsg); }

        public static int RerturnInt(int i) {
            return i*2; }

    }
}
