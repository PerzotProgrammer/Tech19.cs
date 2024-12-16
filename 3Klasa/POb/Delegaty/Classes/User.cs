namespace Delegaty.Classes;

public class User
{
    public string Name { get; private set; }
    public INotifier Notifier { get; private set; }
    public int NotifierPriority { get; private set; }

    public User(string name, NotifierType notifierType, int notifierPriority)
    {
        Name = name;
        NotifierPriority = notifierPriority;

        switch (notifierType)
        {
            case NotifierType.Email:
                Notifier = new EmailNotifier();
                break;
            case NotifierType.Push:
                Notifier = new PushNotifier();
                break;
            case NotifierType.Sms:
                Notifier = new SmsNotifier();
                break;
            default:
                throw new ArgumentException("Unknown notifier type.");
        }
    }

    public void Notify(string message)
    {
        Notifier.Send(message, Name);
    }

    public void ChangeNotifierPriority(int newPriority)
    {
        NotifierPriority = newPriority;
    }
}