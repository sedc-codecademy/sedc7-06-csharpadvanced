using BooksProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAuthors
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksLoader loader = new BooksLoader();
            var authors = loader.GetAllAuthors();

            //var authors31 = new List<Author>();
            //foreach (var author in authors)
            //{
            //    if (author.BookCount == 31)
            //    {
            //        authors31.Add(author);
            //    }
            //}

            //var authors31 = authors.Where(Has31Books1);

            //Func<Author, bool> has31books2 = author => author.BookCount == 31;
            //var authors31 = authors.Where(has31books2);

            var authors31 = authors.Where(author => author.BookCount == 31);

            foreach (var author in authors31)
            {
                Console.WriteLine(author.Name);
            }
        }

        static bool Has31Books1(Author author)
        {
            return author.BookCount == 31;
        }
    }
}
