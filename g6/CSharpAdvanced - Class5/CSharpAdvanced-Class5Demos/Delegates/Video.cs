using System;

namespace Delegates
{
    public enum VideoType
    {
        AVI,        // Audio Video Interleave
        MP4,        // Moving Pictures Expert Group 4
        WMV,        // Windows Media Video
        FLV         // Flash Video Format
    }
    public class Video
    {
        public string Title { get; set; }
        public VideoType Type { get; set; }
        public double Duration { get; set; }

        public Video()
        {

        }

        public Video(string title)
        {
            Title = title;
        }

        public static Video InitialLoad(string videoFilePath, string fileName)
        {
            return new Video(fileName);
        }

        public void Render()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Selected video file was successfully rendered.\n");

            Console.ResetColor();
        }
    }
}