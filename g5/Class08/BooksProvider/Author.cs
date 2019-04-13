using System.Collections.Generic;
using System.Linq;

namespace BooksProvider
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Book> Books { get; set; }

        public override string ToString()
        {
            return $"#{ID}: {Name} has {Books.Count()} books in the database";
        }
    }
}