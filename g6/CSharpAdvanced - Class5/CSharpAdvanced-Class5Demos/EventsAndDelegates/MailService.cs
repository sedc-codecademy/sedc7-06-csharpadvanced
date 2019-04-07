using System;

namespace EventsAndDelegates
{
    /// <summary>
    /// SUBSCRIBER calss that is responsible for sending an email
    /// </summary>
    public class MailService
    {
        public string ServerPath { get; set; }

        /// <summary>
        ///  Here we are defining a method that has the same signature as 
        ///  our delegate. Remember ? Needs to be void and to take
        ///  two parameters, the source and EventArgs argument
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void Send(object source, EventArgs e)
        {
            //Logic for sending an email

            Console.WriteLine("Sending email..");
        }
    }
}