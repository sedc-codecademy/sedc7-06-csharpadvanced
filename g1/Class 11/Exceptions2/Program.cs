using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2 {
    class Program {
        static void Main(string[] args) {

            MyCustomExceptions customExceptions = new MyCustomExceptions();
            customExceptions.Run();
        }
        
        class MyCustomExceptions {

            public void Run() {
                try {
                    ExceptionsCollector(1, 2);
                }
                catch(AggregateException ex) {
                    Console.WriteLine(ex.Message);
                    foreach (Exception innerExeption in ex.InnerExceptions ) {
                        Console.WriteLine(innerExeption.Message);
                    }
                }
            }

            private void ExceptionsCollector(int input1, int input2) {

                var exceptions = new List<Exception>();
                if (input1 == 1) {
                    exceptions.Add(new ArgumentException("This is argument exception"));
                }
                if (input2 == 2) {
                    exceptions.Add(new NotImplementedException("This is not implemented exception"));
                }
                if(input1 == 3) {
                    exceptions.Add(new InvalidOperationException("This is invalid argument exception"));
                }
                if (exceptions.Any()) {
                    throw new AggregateException("All aggregated exceptions ", exceptions);
                }

            }

        }
    }
}
