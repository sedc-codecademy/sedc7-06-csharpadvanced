using System;
using Polymorphism.Interfaces;
using Polymorphism.MessageModels;

namespace Polymorphism.NotificationChannels
{
    class MailNotificationChannel : INotificationChannel
    {
        public void Send()
        {
            //Logic for sending an email message
            MailMessage message = new MailMessage("Some mail message");
            Console.WriteLine("Sending {0}...", message.Title);
        }
    }
}