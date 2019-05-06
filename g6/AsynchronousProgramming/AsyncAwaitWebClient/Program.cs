using System;
using System.IO;
using System.Net;
using System.Threading;

namespace AsyncAwaitWebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebAccess();

            Console.WriteLine("Hey hey, another logic... :) ");

            Console.ReadLine();
        }

        static async void WebAccess()
        {
            WebClient client = new WebClient();

            string taskFirst = await client.DownloadStringTaskAsync(new Uri("https://msdn.microsoft.com/library"));
            var taskSecond = await client.DownloadStringTaskAsync(new Uri("https://html.com/"));
            var taskThird = await client.DownloadStringTaskAsync(new Uri("https://developer.mozilla.org/en-US/docs/Learn/HTML/Howto/Author_fast-loading_HTML_pages"));

            Thread.Sleep(2000);


            using (var stream = new StreamWriter(@"C:\Users\Miodrag.Cekikj\Desktop\htmlDataMiodragAndrej.txt"))
            {
                await stream.WriteAsync(taskFirst + taskSecond + taskThird);
            }

            Console.WriteLine("Check the file now... :) ");
        }
    }
}
