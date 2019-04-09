using System;

namespace VideoRenderingApplication
{
    public class VideoEditor
    {
        //public delegate void VideoEffectsHandler(Video video);

        /// <summary>
        /// Do we know what is a delegate now ? :) A pointer to a function or group of functions..
        /// Above, you can notice the commented out delegate. We defined that delegate to points to a method
        /// or group of methods with the same signature, it returns void and takes one parameter of type Video. Correct ?! 
        /// Instead of creating a custom delegate like above, we can use one of the predifned delegates that comes
        /// in .Net Framework . They are Func<> and Action<>. Func<> represents a method with zero or more
        /// arguments and returns value, Action<> on the other hand is another delegate that provides the same
        /// functionallity but returns void. Thats the only difference you should remember for Action and Func. They are both 
        /// delegates but Func returns a value, Action does not(return void).
        /// 
        /// Thats the reason why we are using Action<Video> as an argument to our function, because you can see above
        /// our custom deleagate that is commented out, RETURNS VOID and takes one paramter of type video. We can achieve 
        /// the same with Action but we avoid defining our custom delegate.
        /// </summary>
        public void ProcessVideo(string filePath, string fileName, Action<Video> videoEffectsHandler)
        {
            Video video = Video.InitialLoad(filePath, fileName);

            videoEffectsHandler(video);

            video.Render();
        }
    }
}
