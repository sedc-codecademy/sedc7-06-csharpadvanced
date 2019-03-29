using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces.Entities
{
    public class Human
    {
        public string FullName { get; set; }
        // Custom Getter and Setter
        private int _Age;
        public int Age
        {
            get
            {
                Console.WriteLine("Getter is called!");
                return _Age;
            }
            set
            {
                Console.WriteLine("Setter is called!");
                _Age = value;
            }
        }
        private string _Username;
        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value.ToLower();
            }
        }
    }
}
