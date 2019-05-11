using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Services
{
    public class HelperService
    {
        public string ReadFromFileSystem(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
        public List<Event> DeserializeEvents(string eventsJson)
        {
            return JsonConvert.DeserializeObject<List<Event>>(eventsJson);
        }
    }
}
