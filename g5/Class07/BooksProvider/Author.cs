using System;

namespace BooksProvider
{
    public class Author
    {
        public Author()
        {
            // Console.WriteLine("Creating an author");
        }

        public int WweId { get; set; }
        public string Name { get; set; }
        public int BookCount { get; set; }

        public override string ToString()
        {
            return $"#{WweId}: {Name} ({BookCount} books)";
        }
    }
}