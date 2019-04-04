using System;
using Polymorphism.Interfaces;
using Polymorphism.MessageModels;

namespace Polymorphism.NotificationChannels
{
    /// <summary>
    /// SmsNotificationChannel that implements INotificationChannel
    /// and we need to provide implementation for Send() method.
    /// You can try with adding a new notification channel. 
    /// If we want to add new notification channel, we just need to 
    /// create a new class that implement the INotificationChannel
    /// and provide an implementation for the Send() method..
    /// </summary>
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