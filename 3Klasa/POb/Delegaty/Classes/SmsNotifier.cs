namespace Delegaty.Classes;

public class SmsNotifier : INotifier
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"Sending SMS to {recipient}.\nMessage: {message}");
    }
}