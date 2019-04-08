using Polymorphism.Interfaces;

namespace Polymorphism.MessageModels
{

    public class MailMessage : IMessage
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string Subject { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public MailMessage()
        {

        }

        public MailMessage(string title)
        {
            Title = title;
        }
    }
}