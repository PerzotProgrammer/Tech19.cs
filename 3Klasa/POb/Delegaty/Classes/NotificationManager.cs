namespace Delegaty.Classes;

public class NotificationManager
{
    public delegate void NotificationSender(string message);

    private NotificationSender? Sender;

    public void AddSender(NotificationSender sender)
    {
        Sender += sender;
    }

    public void RemoveSender(NotificationSender sender)
    {
        Sender -= sender;
    }

    public void SendNotification(string message)
    {
        if (Sender == null)
        {
            Console.WriteLine("No senders added.");
            return;
        }

        Sender?.Invoke(message);
    }
}