namespace Delegaty.Classes;

public class PushNotifier
{
    public void SendPush(string message)
    {
        Console.WriteLine($"Sending push.\nMessage: {message}");
    }
}