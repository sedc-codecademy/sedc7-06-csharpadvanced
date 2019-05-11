using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GameService
    {
        private List<Event> _events;
        public List<Event> GetEvents()
        {
            return _events;
        }
    }
}
