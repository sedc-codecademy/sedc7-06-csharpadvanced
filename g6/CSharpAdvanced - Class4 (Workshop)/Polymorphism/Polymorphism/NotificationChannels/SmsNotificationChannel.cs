using System;
using Polymorphism.Interfaces;
using Polymorphism.MessageModels;

namespace Polymorphism.NotificationChannels
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send()
        {
            //Logic for sending an email message
            SmsMessage message = new SmsMessage("Some sms message");
            Console.WriteLine("Sending {0}...", message.Title);
        }
    }
}