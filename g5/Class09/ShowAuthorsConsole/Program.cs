using BooksProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAuthorsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksLoader loader = new BooksLoader();
            var authors = loader.GetAllAuthors();
            var awards = loader.GetAwards();

            // we can get top dog from the data
            var topDog = awards
                .GroupBy(a => a.Author)
                .Select(g => new
                {
                    Name = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(a => a.Count)
                .First();

            Console.WriteLine(topDog);

            // and even the ID
            var china = authors.Single(a => a.Name == topDog.Name);
            Console.WriteLine(china);

            var result = from a in authors
                         join ad in awards on a.Name equals ad.Author
                         select new
                         {
                             a.Name,
                             a.ID,
                             ad.Award,
                             ad.Title
                         };

            PrintAuthors(result.Take(20));

            var onlyAuthors = authors.Select(a => new { a.ID, a.Name });
            var onlyBooks = authors.SelectMany(a => a.Books.Select(b => new { b.ID, AuthorID = a.ID, b.Title }));

            PrintAuthors(onlyAuthors.Take(10));
            PrintAuthors(onlyBooks.Take(10));

            var rehidrated = from a in onlyAuthors
                             join b in onlyBooks on a.ID equals b.AuthorID
                             select new
                             {
                                 AuthorID = a.ID,
                                 BookID = b.ID,
                                 a.Name,
                                 b.Title
                             };

            PrintAuthors(rehidrated.Take(10));

            var rehidrated2 = from a in onlyAuthors
                             join b in onlyBooks on a.ID equals b.AuthorID into bookGroup
                             select new
                             {
                                 a.ID,
                                 a.Name,
                                 Books = bookGroup,
                                 BooksCount = bookGroup.Count()
                             };

            PrintAuthors(rehidrated2.Take(2));
            PrintAuthors(rehidrated2.First().Books);


        }

        static void PrintAuthors<T>(IEnumerable<T> authors)
        {
            foreach (var author in authors)
            {
                Console.WriteLine(author);
            }
            Console.WriteLine("---------------");
        }
    }
}
