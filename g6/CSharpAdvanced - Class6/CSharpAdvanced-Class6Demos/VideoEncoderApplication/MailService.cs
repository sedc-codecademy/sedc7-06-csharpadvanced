using System;

namespace VideoEncoderApplication
{
    public class MailService
    {
        /// <summary>
        /// We also changed this method because we changed the signature of our delegate. Remember? 
        /// This method and our delegate should have the same signature.
        /// Instead of EventArgs as a second parameter now we are taking a parameter of type VideoEventArgs
        /// thats the custom class we created which derives from EventArgs.. 
        /// Because of the custom class we created, here we can print the title of the video also.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            //Logic for sending an email

            Console.WriteLine("Sending email for video named as {0}..", e.Video.Title);
        }
    }
}
