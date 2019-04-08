using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Publisher
    {
        public delegate void DataProcessingDelegate(string message);
        public event DataProcessingDelegate DataProcessingHandler;

        public void ProcessData(string message) // business logic
        {
            Console.WriteLine("Processing data...");
            Thread.Sleep(3000); // zavrsuva rabota! mnogu e tesko! 3 sekundi!
            WhenDataIsProcessed(message);
        }
        // It notifies all subscribers for the message that is processed from the ProcessData method
        protected void WhenDataIsProcessed(string message)
        {
            if (DataProcessingHandler != null)
            {
                DataProcessingHandler(message);
            }
        }
    }
}
