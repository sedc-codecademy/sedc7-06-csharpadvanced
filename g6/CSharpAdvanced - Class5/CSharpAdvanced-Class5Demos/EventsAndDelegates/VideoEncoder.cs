using System;

namespace EventsAndDelegates
{

    /// <summary>
    ///  PUBLISHER or Event sender class. VideoEncoder class with the new solution, doesn't know anything 
    ///  about MailService. If we want to extend our application and for example add functionallity for
    ///  sending a SMS message. We can just create a new class and subscribe to that VideoEncoded event.
    ///  That way, VideoEncoder doesn't need to be recompiled, because we are not changing the class
    ///  but just extending it with creating a new class.
    /// </summary>
    public class VideoEncoder
    {
        /// <summary>
        ///  An event is a mechanism for communication between objects. An even might be a button click,
        ///  menu selection and so forth. Something happens and you must respond to it. Other classes
        ///  will be interested in responding to some event. How they respond is not of interest to the
        ///  class raising the event. The button says "I was clicked" and the responding classes react 
        ///  appropriately. But, how does VideoEncoder notify his subscribers and how it knows which methods to be called?
        ///  We need agreement or contract between publisher and subscribers. Here comes the magic of delegates :) 
        ///  Delegate is contract betwwen Publisher and Subscribers and determines the signature of the event handler
        ///  in Subscriber. And thats the purpose of our delegate below,  when the video is encoded and we want to notify
        ///  subscribers you should have a method that is void and with the parameters that our delegate below has.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="arg"></param>


        //public readonly MailService _mailService;

        // 1. Define a delegate
        // 2. Create and event based on the delegate
        // 3. Provide a method that will trigger the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs arg);
        public event VideoEncodedEventHandler VideoEncoded;

        /// <summary>
        ///  Previously before implementing the solution with delegates and events we 
        ///  had tight dependency to MailService class and used _mailService to send an email. But what if in the 
        ///  future we decide to sent a text message to the user ? We must go in the method below and add
        ///  extra line of code or lines of code. That way we will change the Encode method needs to be recompiled,
        ///  the class itself needs to be recompiled and all other classes that are dependent on this VideoEncoder class
        ///  needs to be recompiled and redeployed. Because of this change, there is a good possibility we will break some
        ///  code that worked previously. Thats the reason why we want to design our application such that when we make some
        ///  change, that change has minimal impact on the whole application.
        /// </summary>
        /// <param name="video"></param>
        public void Encode(Video video)
        {
            // Video encoding logic

            //_mailService.Send(video);

            Console.WriteLine("Video encoding...");

            // we just call a method called OnVideoEncoded. His purpose is
            // to notify the subscribers that event was raised.
            OnVideoEncoded();

        }

        /// <summary>
        ///  This method is responsible for raising an event. By convetion int .Net framework 
        ///  the event publisher methods are protected, virtual and void. It is recommended also
        ///  to start with 'On' and then the name of the event (OnVideoEncoded).
        ///  With first line of code we check are there any subscribers to this event.
        /// </summary>
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}