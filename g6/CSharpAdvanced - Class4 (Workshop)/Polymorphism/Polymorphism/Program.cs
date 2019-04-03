using Polymorphism.NotificationChannels;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder encoder = new VideoEncoder();

            //encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());

            encoder.Encode(new Video());
        }
    }
}