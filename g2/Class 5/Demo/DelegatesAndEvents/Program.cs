using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    // a class to hold the information about the event
    // in this case it will hold only information
    // available in the clock class, but could hold
    // additional state information
    public class TimeInfoEventArgs : EventArgs
    {
        public int hour;
        public int minute;
        public int second;
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }

    // The publisher: the class that other classes
    // will observe. This class publishes one delegate:
    // SecondChangeHandler.
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        // the delegate the subscribers must implement
        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);
        
        // an instance of the delegate
        public event SecondChangeHandler SecondChanged;
        //public SecondChangeHandler SecondChanged;
        
        // set the clock running
        // it will raise an event for each new second
        public void Run()
        {
            while(true)
            //for (; ; )
            {
                // sleep 500 milliseconds
                System.Threading.Thread.Sleep(500);
                
                // get the current time
                System.DateTime dt = System.DateTime.Now;
                
                // if the second has changed
                // notify the subscribers
                if (dt.Second != second)
                {
                    // create the TimeInfoEventArgs object
                    // to pass to the subscriber
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
                    
                    // if anyone has subscribed, notify them
                    if (SecondChanged != null)
                    {
                        SecondChanged(this, timeInformation);
                    }
                }

                // update the state
                this.second = dt.Second;
                this.minute = dt.Minute;
                this.hour = dt.Hour;
            }
        }
    }

    // A subscriber: DisplayClock subscribes to the
    // clock's events. The job of DisplayClock is
    // to display the current time
    public class DisplayClock
    {
        // given a clock, subscribe to its SecondChangeHandler event
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += new Clock.SecondChangeHandler(TimeHasChanged);
        }

        // the method that implements the delegated functionality
        public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current Time: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }

    // a second subscriber whose job is to write to a file
    public class LogCurrentTime
    {
        // given a clock, subscribe to its SecondChangeHandler event
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += new Clock.SecondChangeHandler(WriteLogEntry);
            //theClock.SecondChanged = new Clock.SecondChangeHandler(WriteLogEntry);
        }

        // the method that implements the delegated functionality
        // this method should write to a file, we write to the console to see the effect
        public void WriteLogEntry(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Logging to file: {0}:{1}:{2}", ti.hour.ToString(), ti.minute.ToString(), ti.second.ToString());
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - The event keyword indicates to the compiler that the delegate can be invoked only by the defining class, and
                that other classes can subscribe to and unsubscribe from the delegate using only the appropriate += and -= operators, not with =
            - In one sense, event is simply a delegate instance to which you’ve restricted access
            - In another, more important sense, event is implemented by a delegate of type
            */
            #endregion

            // create a new clock
            Clock theClock = new Clock();
            
            // create the display and tell it to subscribe to the clock just created
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);
            
            // create a Log object and tell it to subscribe to the clock
            LogCurrentTime lct = new LogCurrentTime();
            lct.Subscribe(theClock);

            // Get the clock started
            theClock.Run();

            #region Solving Delegate Problems with Events
            //1. If LogCurrentTime Subscribe with
            //theClock.SecondChanged = new Clock.SecondChangeHandler(WriteLogEntry);
            //instead with
            //theClock.SecondChanged += new Clock.SecondChangeHandler(WriteLogEntry);

            //2. Hack without event
            //Console.WriteLine("Calling the method directly!");
            //System.DateTime dt = System.DateTime.Now.AddHours(2);
            //TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
            //theClock.SecondChanged(theClock, timeInformation);

            //Solution to add event keyword in Clock, in the declarataion of delegate of type SecondChangeHandler
            //public event SecondChangeHandler SecondChanged;
            //instead
            //public SecondChangeHandler SecondChanged;
            #endregion

            Console.ReadLine();
        }
    }
}
