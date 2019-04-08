namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // publisher of the event
            var encoder = new VideoEncoder(); 

            // subscriber of the event
            MailService mailNotification = new MailService();

            //PUBLISH <-> SUBSCRIBE
            // Before the call the Encode method, we need to do the subscription 
            // we start with the publisher, in our case 'encoder', if we press dot(.) 
            // we will see the event we defined in VideoEncoder class called VideoEncoded
            //  We use '+=' to register an event for that handler. Hanlder in our case is
            // MailService class, so we take mailNotificaition instance and call the Send method.
            // Also note that when we call the Send method we dont have the brackerts () which
            // we usually have when we are calling a method. Thats because it is a reference, a pointer 
            // to that method. VideoEncoded is just a list of pointers to methods.

            encoder.VideoEncoded += mailNotification.Send;

            encoder.Encode(new Video());
        }
    }
}