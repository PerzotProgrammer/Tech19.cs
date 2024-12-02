using Delegaty.Classes;

namespace Delegaty;

class Program
{
    static void Main(string[] args)
    {
        NotificationManager notificationManager = new NotificationManager();
        
        PushNotifier pushNotifier = new PushNotifier();
        EmailNotifier emailNotifier = new EmailNotifier();
        SmsNotifier smsNotifier = new SmsNotifier();
        
        notificationManager.AddSender(pushNotifier.SendPush);
        notificationManager.AddSender(emailNotifier.SendEmail);
        notificationManager.AddSender(smsNotifier.SendSms);

        notificationManager.SendNotification("Hello, World!");
        
        notificationManager.RemoveSender(pushNotifier.SendPush);
        
        notificationManager.SendNotification("Hello, World! but not on push");

    }
}