namespace Delegaty.Classes;

public class EmailNotifier : INotifier
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"Sending email to {recipient}.\nMessage: {message}");
    }
}