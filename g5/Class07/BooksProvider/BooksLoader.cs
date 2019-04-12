using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksProvider
{
    public class BooksLoader
    {
        public IEnumerable<Author> GetAllAuthors()
        {
            string authors = File.ReadAllText("authors-list.json");
            var result = JsonConvert.DeserializeObject<List<Author>>(authors);
            return result;
        }


    }
}
