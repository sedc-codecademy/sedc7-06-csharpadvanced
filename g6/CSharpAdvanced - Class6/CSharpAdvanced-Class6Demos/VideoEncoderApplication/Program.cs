namespace VideoEncoderApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();

            MailService mailService = new MailService();

            encoder.VideoEncoded += mailService.OnVideoEncoded;

            encoder.Encode(new Video() { Title = "Title" });
        }
    }
}
