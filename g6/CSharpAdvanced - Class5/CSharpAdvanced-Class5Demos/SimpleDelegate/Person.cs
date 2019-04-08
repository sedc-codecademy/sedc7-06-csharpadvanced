using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    /// <summary>
    ///  By defining a delegate, you are saying to the user of your class, "Please feel free to assign,
    ///  any method that matches this signature, to the delegate and it will be called each
    ///  time my delegate is called".
    /// </summary>
    /// <param name="input"></param>
    public delegate void StringProcessor(string input);
    public class Person
    {
        public string Name { get; set; }

        /// <summary>
        /// Constructor with one paramer
        /// </summary>
        /// <param name="name"></param>
        public Person(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Delcaring compatible instance method, same signature as our 
        /// delegate, void as a return type and get one paramter of
        /// type string.
        /// </summary>
        /// <param name="message"></param>
        public void Talk(string message)
        {
            Console.WriteLine("{0} says : {1}", Name,message);

        }
    }
}
