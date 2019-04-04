using Polymorphism.Interfaces;

namespace Polymorphism.MessageModels
{
    public class SmsMessage : IMessage
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string DeviceSerialNumber { get; set; }

        public SmsMessage()
        {

        }

        public SmsMessage(string title)
        {
            Title = title;
        }
    }
}