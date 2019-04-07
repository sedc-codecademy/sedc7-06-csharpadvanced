using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person andrej = new Person("Andrej");
            Person miodrag = new Person("Miodrag");

            // Creating three delegate instances..
            StringProcessor andrejsVoice = andrej.Talk;
            StringProcessor miodragsVoice = miodrag.Talk;
            StringProcessor background = Background.Note;

            // invoking delegate instances..
            // When andrejVoice is invoked, it calls the Talk method on Person object with the name Andrej,likewise
            // when miodragVoice is invoked, it uses the object with the name Miodrag.
            andrejsVoice("Hello Miodrag");
            miodragsVoice("Hello Andrej");
            background("The class just started");

            // You can argue that there is no need of delegate to achieve the same behaviour and you are correct.
            // This example is just for demonstrational purpose for you to feel more comfortable with delegates.
            // We can call methods directly, correct ? If you remember the morbid example with the lawyer :), that needs 
            // to act on our instructions from the testament. Just because we want something to happen doesn't mean
            // we are always there at the right time to make it happen. Sometimes, we need to give instructions
            // to delegate responsibility. It's just about specifiyng some code to be executed at a particular time,
            // when we are not able to change the code that is running at that point.
            // 
        }
    }
}
