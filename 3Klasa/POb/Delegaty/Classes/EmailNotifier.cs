namespace Delegaty.Classes;

public class EmailNotifier
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email.\nMessage: {message}");
    }
}