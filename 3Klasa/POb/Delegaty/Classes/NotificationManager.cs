namespace Delegaty.Classes;

public class NotificationManager
{
    public delegate void NotificationSender(string message);

    private NotificationSender? Sender;
    private List<User> Users;

    public NotificationManager()
    {
        Users = new List<User>();
    }

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public void RemoveUser(User user)
    {
        Users.Remove(user);
    }

    public void SendNotification(string message)
    {
        Sender?.Invoke(message);
    }

    public void SetNewNotificationPriority(int newPriority)
    {
        if (Sender != null)
        {
            foreach (Delegate notificationSubscription in Sender.GetInvocationList())
            {
                Sender -= (NotificationSender)notificationSubscription;
            }

        }

        List<User> users = Users.Where(user => user.NotifierPriority >= newPriority).ToList();

        foreach (User user in users)
        {
            Sender += user.Notify;
        }
    }
}