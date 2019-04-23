using BooksProvider;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ImageLocationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksLoader bl = new BooksLoader();
            var authorBooks = bl.GetAllAuthors().SelectMany(a => a.Books.Select(b => new
            {
                AuthorID = a.ID,
                AuthorName = a.Name,
                BookID = b.ID,
                BookTitle = b.Title
            }));

            var booksWithSingleAuthors = bl.GetAllAuthors().SelectMany(a => a.Books.Select(b => new
            {
                AuthorID = a.ID,
                AuthorName = a.Name,
                BookID = b.ID,
                BookTitle = b.Title
            }))
            .GroupBy(ba => ba.BookID)
            .Where(g => g.Count() == 1)
            .SelectMany(g => g.AsEnumerable());

            var errors = new List<object>();
            foreach (var ba in booksWithSingleAuthors)
            {
                var authorInitials = string.Join("", ba.AuthorName.Split(' ').Select(part => part[0])).ToLower();
                var bookName = string.Join("", ba.BookTitle.Split(' '));
                bookName = Regex.Replace(bookName, "[']", "");
                bookName = bookName.Substring(0, Math.Min(8, bookName.Length));
                var imageName = $"http://www.worldswithoutend.com/covers/{authorInitials}_{bookName}.jpg";
                WebClient wc = new WebClient();
                try
                {
                    wc.DownloadData(imageName);
                }
                catch (WebException wex)
                {
                    var response = wex.Response as HttpWebResponse;
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine(ba);
                        errors.Add(ba);
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            File.WriteAllLines("errors.txt", errors.Select(e => e.ToString()).ToArray());
        }
    }
}
