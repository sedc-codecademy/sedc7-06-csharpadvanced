using System;

namespace Delegates
{
    public class MyFancyEffects
    {
        /// <summary>
        /// If we need an effect that was not included, we can create our own. The effect below applies
        /// shadow effect to the video. It takes a paramter of type Video and has void as a return 
        /// type. It is the same signature as our delegate, remeber ? Gets a paramteres of type Video and void
        /// as a return type.. Just to repeat once again, delegate is a pointer to a method or methods with that 
        /// signature.
        /// </summary>
        /// <param name="video"></param>

        public void Shadow(Video video)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Shadow effect applied on video named as {0}...\n", video.Title);
        }
    }
}
