using BooksProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRest
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksLoader loader = new BooksLoader();
            var authors = loader.GetAllAuthors();
            var awards = loader.GetAwards();

            var longestSeries = authors
                .SelectMany(a => a.Books)
                .Where(b => !string.IsNullOrEmpty(b.Series))
                .GroupBy(b => b.Series)
                .OrderByDescending(g => g.Count())
                .First();

            var longestSeriesinLongestLine = Enumerable.First(
                Enumerable.OrderByDescending(
                    Enumerable.GroupBy(
                        Enumerable.Where(
                            Enumerable.SelectMany(authors, a => a.Books), 
                        b => !string.IsNullOrEmpty(b.Series)), 
                    b => b.Series), 
                 g => g.Count())
            );

            Console.WriteLine(longestSeries.Key);
            Console.WriteLine(longestSeriesinLongestLine.Key);

            var lotsaSeven = Enumerable.Repeat(7, 300);
            var squares = Enumerable.Range(11, 10).Select(n => n*n);
            PrintEnumerable(squares);

            Random r = new Random();
            var random = Enumerable.Repeat(0, 50).Select(_ => r.Next(1000));
            PrintEnumerable(random);

            Dictionary<int, Author> authorsDict = authors.Aggregate(new Dictionary<int, Author>(), (dict, author) =>
            {
                dict.Add(author.ID, author);
                return dict;
            });

            Console.WriteLine(authorsDict[1350]);
            
        }

        static void PrintEnumerable<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
