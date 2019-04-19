using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1 {
    class Program {
        static void Main(string[] args) {

            int num = 100;
            int divisor = 0;
            int calculated;

            try {
                calculated = num / divisor;
            }
            catch (Exception ex) {
                Console.WriteLine("An error occurred during division.");
                Console.WriteLine("Message: {0}\n", ex.Message);
                Console.WriteLine("Source: {0}\n", ex.Source);
                Console.WriteLine("Target site: {0}\n", ex.TargetSite);
                Console.WriteLine("Stack trace: {0}\n", ex.StackTrace);
                ex.HelpLink = "https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch";
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine("Not a good result: {0}",ex.HResult);
                calculated = ex.HResult;
            }

            Console.WriteLine("Result = {0}", calculated);

            try {
                calculated = num / divisor;
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine("Division by zero occurred.");
                Console.WriteLine("Message: {0}\n", ex.Message);
                calculated = int.MaxValue;
            }
            finally {
                Console.WriteLine("Clearing up any resources. Closing connections to database, etc...");
            }
            Console.WriteLine("Result = {0}", calculated);
        }
    }
}
