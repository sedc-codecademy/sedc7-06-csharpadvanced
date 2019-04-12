using System;

namespace VideoRenderingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // object of type VideoEditor
            VideoEditor editor = new VideoEditor();

            string videoPath = "VacationMemories.avi";
            string videoName = "OhridSummer2018";

            // we are creating an instance from VideoEffects class
            VideoEffects effects = new VideoEffects();

            // Here, instead of using our custom delegate that we already removed
            // we are creating delegate instance of type Action<Video> and it points
            // to a method called SlowMotion. Why we can point to or refer to that method
            // SlowMotion? Because it has the same signature as our delegate instance
            // it returns void(thats why we are using Action instead of Func) and takes
            // one parameter of type video. 

            Action<Video> videoEffectsHandler = effects.SlowMotion;
            videoEffectsHandler += effects.BlackAndWhite;

            videoEffectsHandler += Shadow;

            editor.ProcessVideo(videoPath, videoName, videoEffectsHandler);
        }

        static void Shadow(Video video)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Shadow effect applied on video named as {0}...\n", video.Title);
        }
    }
}
