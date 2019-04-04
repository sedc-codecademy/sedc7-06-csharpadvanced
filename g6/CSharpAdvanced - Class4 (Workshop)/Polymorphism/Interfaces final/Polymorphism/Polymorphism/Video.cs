namespace Polymorphism
{
    public enum VideoType
    {
        AVI,        // Audio Video Interleave
        MP4,      // Moving Pictures Expert Group 4
        WMV,    // Windows Media Video
        FLV       // Flash Video Format
    }
    public class Video
    {
        public string Title { get; set; }
        public VideoType Type { get; set; }
        public double Duration { get; set; }
    }
}