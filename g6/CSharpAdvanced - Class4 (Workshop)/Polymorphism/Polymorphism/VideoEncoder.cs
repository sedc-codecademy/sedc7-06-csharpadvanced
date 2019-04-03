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
        //private readonly MailService _mailService;
        private readonly List<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            //_mailService = new MailService();
            _notificationChannels = new List<INotificationChannel>();
        }

        /// <summary>
        /// Simple method for encoding, it takes a Video obejct and after
        /// encoing is done, we use the _mailService to send an email 
        /// to the person who uploaded the video to our website...
        /// </summary>
        /// <param name="video"></param>
        public void Encode(Video video)
        {
            // Video encoding logic
            Console.WriteLine("Video encoding...");

            // _mailService.Send(new Mail());
            // _smsService.Send(new Sms());
            foreach (var channel in _notificationChannels)
            {
                channel.Send();
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}