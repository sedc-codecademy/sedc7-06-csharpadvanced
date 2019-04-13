using System.Collections.Generic;

namespace BooksProvider
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}