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
            PrintAuthors(authors31);

            PrintAuthors(authors.Where(a => a.Name.StartsWith("Jeff ")));

            var between = authors
                 .Where(a => a.WweId >= 2200)
                 .Where(a => a.WweId <= 2300)
                 .Where(a => a.Name.StartsWith("A"))
                 .Where(a => a.BookCount > 2);
            PrintAuthors(between);

            var between2 = from a in authors
                           where a.WweId >= 2200 && a.WweId <= 2300
                           where a.Name.StartsWith("A")
                           where a.BookCount > 2
                           select a;

            PrintAuthors(between2);

            var moreThanNinetyEven1 = new List<Author>();
            var authorsArr = authors.ToArray();

            for (int index = 0; index < authorsArr.Length; index++)
            {
                var author = authorsArr[index];
                if (author.BookCount > 90)
                {
                    if (index % 2 == 0)
                    {
                        moreThanNinetyEven1.Add(author);
                    }
                }
            }
            PrintAuthors(moreThanNinetyEven1);

            var moreThanNinetyEven2 = authors
                .Where((author, index) => index % 2 == 0)
                .Where(author => author.BookCount > 90);

            PrintAuthors(moreThanNinetyEven2);

            var moreThanNinetyEven3 = authors
                .Select((author, index) => new {
                    author.Name,
                    author.BookCount,
                    Index = index,
                })
                .Where(author => author.Index % 2 == 0)
                .Where(author => author.BookCount > 90);
            PrintAuthors(moreThanNinetyEven3);

            var nemaSpaces = authors
                //.Where(a => a.Name.IndexOf(" ") == -1)
                .Select(author => new
                {
                    author.Name,
                    FirstSpace = author.Name.IndexOf(" "),
                    HasSpace = author.Name.IndexOf(" ") != -1
                })
                .Select(author => new
                {
                    author.Name,
                    FirstName = author.HasSpace ? author.Name.Substring(0, author.FirstSpace) : author.Name,
                    LastName = author.HasSpace ? author.Name.Substring(author.FirstSpace + 1) : ""
                })
                .Where(author => author.LastName.IndexOf(" ") != -1);

            PrintAuthors(nemaSpaces);
            Console.WriteLine(nemaSpaces.Count());

        }

        static void PrintAuthors<T>(IEnumerable<T> authors)
        {
            foreach (var author in authors)
            {
                Console.WriteLine(author);
            }
            Console.WriteLine("---------------");
        }

        static bool Has31Books1(Author author)
        {
            return author.BookCount == 31;
        }
    }
}
