using System;
using Polymorphism.Interfaces;
using Polymorphism.MessageModels;

namespace Polymorphism.NotificationChannels
{
    /// <summary>
    ///  MailNotificationChannel class that implement INotificationChannel interface
    ///  and therefore we need to provide an implementation for the Send() that is inside
    ///  that interface
    /// </summary>
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send()
        {
            //Logic for sending an email message
            MailMessage message = new MailMessage("Some mail message");
            Console.WriteLine("Sending {0}...", message.Title);
        }
    }
}