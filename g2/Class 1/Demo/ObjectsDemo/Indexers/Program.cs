using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class BookStore
    {
        private string[] books;
        public BookStore()
        {
            books = new string[5] { "Book0", "Book1", "Book2", "Book3", "Book4" };
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Length)
                {
                    return null;
                }
                else
                {
                    return books[index];
                }
            }
            set
            {
                if (index >= 0 && index < books.Length)
                {
                    books[index] = value;
                }
            }
        }
    }

    class BookStore2
    {
        Dictionary<int, string> books;
        public BookStore2()
        {
            books = new Dictionary<int, string>();
            books.Add(0, "Book0");
            books.Add(1, "Book1");
            books.Add(2, "Book2");
            books.Add(3, "Book3");
            books.Add(4, "Book4");
        }
        public string this[int i]
        {
            get
            {
                if (books.ContainsKey(i))
                {
                    return books[i];
                }
                else
                {
                    return null;
                }
                
            }
            set
            {
                if (books.ContainsKey(i))
                    books[i] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Indexers BookStore
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("BookStore");
            //BookStore bs = new BookStore();
            //string book3 = bs[3];
            //Console.WriteLine($"bs[3]: {book3}");
            //bs[3] = "NewBook3";
            //book3 = bs[3];
            //Console.WriteLine($"bs[3]: {book3}");
            #endregion

            #region Indexers BookStore 2
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("BookStore2");
            BookStore2 bs = new BookStore2();
            string book3 = bs[3];
            Console.WriteLine($"bs[3]: {book3}");
            bs[3] = "NewBook3";
            book3 = bs[3];
            Console.WriteLine($"bs[3]: {book3}");
            #endregion

            Console.ReadLine();
        }
    }
}
