namespace Delegaty.Classes;

public class SmsNotifier
{
    public void SendSms(string message)
    {
        Console.WriteLine($"Sending SMS.\nMessage: {message}");
    }
}