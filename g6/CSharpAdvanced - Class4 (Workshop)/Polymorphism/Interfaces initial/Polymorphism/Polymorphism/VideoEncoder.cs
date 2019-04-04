using System;

namespace Polymorphism
{
    /// <summary>
    /// Class responsible for encoding a video
    /// </summary>
    public class VideoEncoder
    {
        /// <summary>
        /// Tight dependency to the MailService class..
        /// If tomorrow we decide to have another way for notifying the user,
        /// for example, send them a text or maybe both, mail and sms. We have 
        /// to come back here and change the method Encode()..That means every class
        /// that contains or is dependent on this method, has to be recompiled and 
        /// there is a good chance we could "break" some other functionality in other class
        /// that is dependent on our Encode() method..
        /// 
        /// </summary>
        private readonly MailService _mailService;

        public VideoEncoder()
        {
            _mailService = new MailService();
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
             
            _mailService.Send(new Mail());
        }

        // Open-close principle(OCP) in object oriented programming, claims that our entities
        // should be open for extension but closed for modification..
    }
}
