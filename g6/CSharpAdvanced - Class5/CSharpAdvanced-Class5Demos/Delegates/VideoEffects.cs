using System;

namespace Delegates
{
    /// <summary>
    /// Class that represents all the methods responsible for
    /// applying a specific effect to some video.
    /// For simplicity, we are just using Console.Writeline() inside
    /// we are not going to implement the real algorithms for 
    /// each of these methods..
    /// 
    /// </summary>
    public class VideoEffects
    {
        public void SlowMotion(Video video)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Slow motion effect applied on video named as {0}...\n", video.Title);
        }

        public void BlackAndWhite(Video video)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Black and White effect applied on video named as {0}...\n", video.Title);
        }

        public void DoubleSpeed(Video video)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Double Speed effect applied on video named as {0}...\n", video.Title);
        }
    }
}