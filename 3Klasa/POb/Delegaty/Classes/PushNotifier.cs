namespace Delegaty.Classes;

public class PushNotifier : INotifier
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"Sending push to {recipient}.\nMessage: {message}");
    }
}