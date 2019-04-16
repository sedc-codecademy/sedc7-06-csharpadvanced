using BooksProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksLoader loader = new BooksLoader();
            var authors = loader.GetAllAuthors();
            var awards = loader.GetAwards();

            // What is the average number of books per autors?
            Console.WriteLine("What is the average number of books per autors?");
            double booksCount = authors.SelectMany(a => a.Books).Count();
            //double booksCount = authors.Sum(a => a.Books.Count());
            double authorCount = authors.Count();

            var average = booksCount / authorCount;
            Console.WriteLine(average);

            Console.WriteLine(authors.Average(a => a.Books.Count()));
            Console.WriteLine("------------");

            // Which book(s) has the longest title, and how long is it?
            Console.WriteLine("Which book(s) has the longest title, and how long is it?");
            var longestBook = authors
                .SelectMany(a => a.Books)
                .OrderByDescending(b => b.Title.Length)
                .First();

            Console.WriteLine(longestBook);
            Console.WriteLine(longestBook.Title.Length);

            var maxLength = authors.Max(a => a.Books.Max(b => b.Title.Length));

            var authorWithMaxLengthBook = authors.First(a => a.Books.Max(b => b.Title.Length) == maxLength);
            Console.WriteLine(authorWithMaxLengthBook);
            var longestBook2 = authorWithMaxLengthBook.Books.First(b => b.Title.Length == maxLength);
            Console.WriteLine(longestBook2);
            Console.WriteLine(longestBook.Title.Length);
            Console.WriteLine("------------");

            // Which author has the shortest average title for a book?
            Console.WriteLine("Which author has the shortest average title for a book?");
            var authorWithAverages = authors.Select(a => new
            {
                a.Name,
                Average = a.Books.Average(b => b.Title.Length)
            })
            .OrderBy(a => a.Average)
            .First();

            Console.WriteLine(authorWithAverages);
            Console.WriteLine("------------");

            // Which author has the shortest average title for a book? (Discount authors with less than three books)
            Console.WriteLine("Which author has the shortest average title for a book? (Discount authors with less than three books)");
            var authorWithAverages2 = authors
                .Where(a => a.Books.Count() >= 3)
                .Select(a => new
                {
                    a.Name,
                    Average = a.Books.Average(b => b.Title.Length)
                })
            .OrderBy(a => a.Average)
            .First();

            Console.WriteLine(authorWithAverages2);
            Console.WriteLine("------------");

            // What series has the most books?
            Console.WriteLine("What series has the most books?");

            var longestSeries = authors
                .SelectMany(a => a.Books)
                .Where(b => !string.IsNullOrEmpty(b.Series))
                .GroupBy(b => b.Series)
                .OrderByDescending(g => g.Count())
                .First();

            Console.WriteLine($"{longestSeries.Key} has {longestSeries.Count()} titles");
            Console.WriteLine("------------");

            // Which year has the most books published?
            Console.WriteLine("Which year has the most books published?");

            var mostBooksYear = authors
                .SelectMany(a => a.Books)
                .GroupBy(b => b.Year)
                .OrderByDescending(g => g.Count())
                .First();

            Console.WriteLine($"{mostBooksYear.Count()} titles were published in {mostBooksYear.Key}");
            Console.WriteLine("------------");

            //What is the average number of books published for years in the 21st centrury? (Starting with 2001, not 2000)
            Console.WriteLine("What is the average number of books published for years in the 21st centrury? (Starting with 2001, not 2000)");

            var yearBooksCentury = authors
                .SelectMany(a => a.Books)
                .GroupBy(b => b.Year)
                .OrderBy(g => g.Key)
                .SkipWhile(g => g.Key <= 2000);

            var yearBooksCentury2 = authors
                .SelectMany(a => a.Books)
                .Where(b => b.Year > 2000)
                .GroupBy(b => b.Year);

            var averageBooksCentury = yearBooksCentury2.Average(g => g.Count());

            Console.WriteLine(averageBooksCentury);
            Console.WriteLine("------------");

            //Which author has the most different series ?
            Console.WriteLine("Which author has the most different series ?");

            var authorsMostSeries = authors.Select(a => new
            {
                a.Name,
                NumSeries = a.Books
                    .Select(b => b.Series)
                    .Distinct()
                    .Where(series => !string.IsNullOrEmpty(series))
                    .Count()
            }).OrderByDescending(a => a.NumSeries).First();

            Console.WriteLine(authorsMostSeries);

            Console.WriteLine("------------");

            //Which author has the most books written that belong to a series?
            Console.WriteLine("Which author has the most books written that belong to a series?");
            var authorsMostBooksSeries = authors.Select(a => new
            {
                a.Name,
                NumBooksInSeries = a.Books.Count(b => !string.IsNullOrEmpty(b.Series))
            }).OrderByDescending(a => a.NumBooksInSeries).First();

            Console.WriteLine(authorsMostBooksSeries);
            Console.WriteLine("------------");

            // Which author has the longest career?
            Console.WriteLine("Which author has the longest career?");

            var longestCareer = authors.Select(a => new
            {
                a.Name,
                FirstBook = a.Books.Min(b => b.Year),
                LastBook = a.Books.Max(b => b.Year)
            }).OrderByDescending(a => a.LastBook - a.FirstBook).First();

            Console.WriteLine(longestCareer);
            Console.WriteLine("------------");
            Console.WriteLine("----BONUS---");
            Console.WriteLine("------------");
            // What series has the most authors?
            Console.WriteLine("What series has the most authors?");
            var booksWithSeries = authors.SelectMany(a => a.Books
                .Where(b => !string.IsNullOrEmpty(b.Series))
                .Select(b => new
                {
                    AuthorName = a.Name,
                    BookTitle = b.Title,
                    Series = b.Series
                }));

            var seriesGroups = booksWithSeries.GroupBy(
                abs => abs.Series, 
                abs => new { abs.AuthorName, abs.BookTitle }
            );

            var seriesAuthor = seriesGroups.Select(sg => new
            {
                Series = sg.Key,
                NumAuthors = sg.Select(ab => ab.AuthorName).Distinct().Count()
            });

            var mostAutorsSeries = seriesAuthor.OrderByDescending(sa => sa.NumAuthors).First();

            //PrintEnumerable(booksWithSeries.Take(100));
            //PrintGroups(seriesGroups.Take(4));
            //PrintEnumerable(seriesAuthor.Take(100));
            Console.WriteLine(mostAutorsSeries);
            Console.WriteLine("------------");

            // How long is the longest hiatus between two books for an author, and by whom?
            Console.WriteLine("How long is the longest hiatus between two books for an author, and by whom?");

            var hiatuses = authors.Select(a => {
                var orderedBooks = a.Books.OrderBy(b => b.Year);
                var pauses = orderedBooks.Select((book, index) =>
                {
                    if (index == 0)
                    {
                        return -17;
                    }
                    return book.Year - orderedBooks.ElementAt(index - 1).Year;
                }).Skip(1);

                return new
                {
                    a.Name,
                    a.Books,
                    Pauses = pauses
                };
            });


            var longestHiatus = hiatuses
                .Where(a => a.Pauses.Count() > 0)
                .Select(a => new
                {
                    a.Name,
                    LongestHiatus = a.Pauses.Max()
                })
                .OrderByDescending(a => a.LongestHiatus)
                .First();
                //.Skip(30)
                //.Take(10);

            //PrintEnumerable(longestHiatus);
            Console.WriteLine(longestHiatus);
        }

        static void PrintGroups<TKey, TItem>(IEnumerable<IGrouping<TKey, TItem>> groups)
        {
            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine($"  {item}");
                }
            }
        }

        static void PrintEnumerable<T> (IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
