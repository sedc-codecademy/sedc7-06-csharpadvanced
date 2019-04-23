using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionBase
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Year})";
        }
    }
}
