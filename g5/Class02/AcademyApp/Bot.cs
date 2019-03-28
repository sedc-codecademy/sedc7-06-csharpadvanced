using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    class Bot : IUserLike
    {
        public Academy Academy { get; set; }
        public int ID { get; set; }
        public string Username
        {
            get
            {
                return "bot";
            }
            set
            {
            }
        }

        public IEnumerable<object> GetSomething()
        {
            return new List<string>{ "I'm a bot", "I don't do anything"};
        }

        public int BotMethod()
        {
            return 42;
        }

        public string GetRole()
        {
            return "BOT";
        }
    }
}
