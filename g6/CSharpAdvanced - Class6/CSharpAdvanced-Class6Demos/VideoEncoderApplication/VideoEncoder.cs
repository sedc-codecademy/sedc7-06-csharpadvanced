using System;

namespace VideoEncoderApplication
{
    /// <summary>
    /// Below in VideoEncoer class we have two delegates that are commented at the moment. They are doing the same
    /// thing don't get confused. We wanted you to have the basic delegate that we start with, that's the first
    /// delegate below, which takes two paramters of type object and EventArgs.  Because we decided to extend our solution
    /// and to send the title of the video that is encoded to the user, we added the second delegate. To achieve that we need 
    /// to create a custom class in our case called VideoEventArgs, that derives from EventArgs class and includes any 
    /// additional data that we want to send to our subscribers. Note below in the new class, we have just one property
    /// of type Video and thats the video that was encoded. You can see in the second delegate below, instead of EventArgs
    /// as a second parameter we are sending VideoEventArgs.
    /// 
    /// </summary>
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);


        /// <summary>
        /// If we want to write less code, we can do the same thing on a different way, without
        /// declaring the two delegates that are commented out above.. We don't need to declare a
        /// new delegate every time we declare an event. In .Net we have a delegate type called
        /// EventHanlder, it comes in two forms , normal and generic one. EventHanlder and EventHanlder<TEvent>.
        /// This means we can use that delegate instead of creating a new delegate. Thats what we are doing with
        /// the line below, we are making use of generic version of EventHanlder. Note the parameter in the angle 
        /// brackets, its of type VideoEventArgs because we are sending it as an additonal data. In a situatuon when
        /// we don't want to send additional data, we will use the normal version of EventHanlder (without angle brackets).
        /// </summary>
        public event EventHandler<VideoEventArgs> VideoEncoded;

        /// <summary>
        /// Here in the Encode method, we have a reference to the actual video that was encoded, so
        /// we just pass that video object to the method OnVideoEncoded below
        /// </summary>
        public void Encode(Video video)
        {
            // Video encoding logic

            Console.WriteLine("Video encoding...");

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
