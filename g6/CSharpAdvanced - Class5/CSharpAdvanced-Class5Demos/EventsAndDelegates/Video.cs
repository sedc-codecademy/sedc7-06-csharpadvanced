namespace EventsAndDelegates
{
    public enum VideoType
    {
        AVI,        // Audio Video Interleave
        MP4,        // Moving Pictures Expert Group 4
        WMV,        // Windows Media Video
        FLV         // Flash Video Format
    }

    /// <summary>
    /// Simpple class that represents a video with title,
    /// duration and from which type is the video
    /// </summary>
    public class Video
    {
        public string Title { get; set; }
        public VideoType Type { get; set; }
        public double Duration { get; set; }
    }
}