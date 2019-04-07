namespace Delegates
{
    public class VideoEditor
    {
        //Definition of one delegate in C#

        /// <summary>
        ///  When we are defining a delegate we need to define the signature of the method that this
        ///  delegate will be responsible for calling. Note the void as a return type and it takes a 
        ///  parameter of type Video. VideoEffectsHandler is the name of our delegate, so an instance  
        ///  of this delegate can hold a pointer to a method or group of methods that have the same signature.
        ///  They needs to be void and take a paramter of type Video(like our delegate).
        ///     
        /// </summary>
        /// <param name="video"></param>
        public delegate void VideoEffectsHandler(Video video);

        /// <summary>
        /// This method takes the file path to the video, file name and we are passing a delegate instance videoEffectsHanlder,
        /// which we are calling below and just passing video object. Method doesn't know which effect will be applied. Its 
        /// the responsibility of whoever is using that, they wil define the effects they want. Maybe someone wants to apply
        /// one effect, someone else wil want to apply 5 effects and so on...This file doesn't need to be changed or recompiled.
        /// That makes this code extensible.
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param>
        /// <param name="videoEffectsHanlder"></param>
        public void ProcessVideo(string filePath, string fileName, VideoEffectsHandler videoEffectsHanlder)
        {
            Video video = Video.InitialLoad(filePath, fileName);

            videoEffectsHanlder(video);


            video.Render();
        }
    }
}
