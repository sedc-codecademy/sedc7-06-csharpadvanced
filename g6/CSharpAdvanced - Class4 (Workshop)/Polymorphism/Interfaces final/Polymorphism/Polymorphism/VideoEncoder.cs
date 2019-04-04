using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    /// <summary>
    /// Class responsible for encoding a video
    /// </summary>
    public class VideoEncoder
    {
        // Here we have a list of notification channel, becaues maybe
        // we will need to send more than one notification. For example
        // sent an email and sms to the user.
        private readonly List<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            //_mailService = new MailService();
            // Here in constructor, we are just initializing that list to an
            // empty list

            _notificationChannels = new List<INotificationChannel>();
        }

        /// <summary>
        /// Simple method for encoding, it takes a Video obejct and after
        /// encoing is done, we use the _mailService to send an email 
        /// to the person who uploaded the video to our website...
        /// 
        /// There are parts in our system(application) where there is potentail for change
        /// like in VideoEncoder we know that potentially we could sent an sms to the user 
        /// or notify them while they are online on their site. Here is an area that will be affected 
        /// because of that chamge..    
        /// When we design this class, we should not think about MailService. We should think in abstraction. 
        /// We should think when VideoEncoder finish his job it needs to send a notification to the user. How? We dont know.. 
        /// We dont know if it is a mail or text message, VideoEncoder should not know about that..
        /// 
        /// </summary>
        /// <param name="video"></param>
        public void Encode(Video video) 
        {
            // Video encoding logic
            Console.WriteLine("Video encoding...");

            //  We are just iterating in notification channels
            // and calling Send() method for each of them
            foreach (var channel in _notificationChannels)
            {
                channel.Send();
            }
        }

        /// <summary>
        ///  _notificationChannel list is private because it is implementation detail for this class
        ///  and we dont want to expose it to the outside, we need this method RegisterNotificationChannel
        /// which gets parameter of type INotificationChannel and all we do is we add that to our list..
        /// This is the method that we use from the outside.
        /// </summary>
        /// <param name="channel"></param>
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}