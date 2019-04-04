using System;

namespace Polymorphism
{
    public class MailService
    {
        /// <summary>
        /// We are not implementing a logic for sending an email
        /// we are just logging message to the console..
        /// </summary>
        /// <param name="mail"></param>
        public void Send(Mail mail)
        {
            //Logic for sending an email
            Console.WriteLine("Sending email..");
        }
    }
}