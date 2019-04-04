using Polymorphism.NotificationChannels;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing an encoder
            var encoder = new VideoEncoder();

            // After we initialize the encoder, we call that RegisterNotificationChannel()
            // and here we pass a concrete implementation of notification channel
            // MailNotificationChannel and SmsNotificationChannel
            // You can notice that with interfaces we also have a polymorphic behaviour
             
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());

            encoder.Encode(new Video());
        }
    }
}