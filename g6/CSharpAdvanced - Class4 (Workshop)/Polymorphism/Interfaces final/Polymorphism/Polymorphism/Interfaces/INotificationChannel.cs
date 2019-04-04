namespace Polymorphism.Interfaces
{
    /// <summary>
    ///  Interface with one method Send().
    ///  Mail could be one notification channel, SMS can be another noticiatoin channel, 
    ///  so we just creat a class(notification channel) that implements this interface
    /// </summary>
    public interface INotificationChannel
    {
        void Send();
    }
}