using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    public class Button
    {
        // define a delegate type
        public delegate void EventHandler(object sender, EventArgs e);
        public EventHandler Click;

        public void SimulateClick()
        {
            EventArgs e = new EventArgs();
            Click(this, e);
        }
    }

    public class KeyEventArgs:EventArgs
    {
        public string Key { get; set; }
        public KeyEventArgs(string key)
        {
            this.Key = key;
        }
    }

    public class Key
    {
        // define a delegate type
        public delegate void EventHandler(object sender, KeyEventArgs e);
        public EventHandler KeyPressed;

        public void SimulateKeyPressed()
        {
            Console.WriteLine("Pres key a or b");
            string keyFromKeyboard = Console.ReadLine().ToUpper();
            if (keyFromKeyboard == "A")
            {
                KeyEventArgs e = new KeyEventArgs(keyFromKeyboard);
                KeyPressed(this, e);
            }
        }
    }

    public class Loger
    {
        public void SubscribeToButton(Button btnTest)
        {
            btnTest.Click += new Button.EventHandler(btnTest_Click);
        }

        void btnTest_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnTest is clicked");
        }

        public void SubscribeToKey(Key keyTest)
        {
            keyTest.KeyPressed += new Key.EventHandler(keyTest_KeyPressed);
        }

        void keyTest_KeyPressed(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"keyTest: {e.Key} is pressed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - Events in C# are implemented with delegates
            - The publishing class does two things
                - first defines a delegate
                - and then Raise the event (Invoke delegate)
            - The subscribing class does two things
                - first, it creates a method that matches the signature of the delegate
                - and then it creates an instance of that delegate type encapsulating that method (subscribe)
            - By convention in .NET Framework
                - Event handlers always return void and take two parameters
                - The first parameter is sender, the source of the event (that is, the publishing object)
                - The second parameter is an object derived from EventArgs
                - EventArgs class is an empty bucket that you can use to supply any information you want about the event, or no information at all
                - What the subscribing class does with that information is the subscriber’s business; it doesn’t matter to the publisher
            */
            #endregion

            //Microsoft WinForms
            //public delegate void EventHandler(object sender, EventArgs e);
            //this.btnTest.Click += new System.EventHandler(this.btnTest_Click);

            Button btnTest = new Button();
            Key keyTest = new Key();

            Loger log = new Loger();
            log.SubscribeToButton(btnTest);
            btnTest.SimulateClick();

            log.SubscribeToKey(keyTest);
            keyTest.SimulateKeyPressed();

            Console.ReadLine();
        }
    }
}
