using Delegaty.Classes;

namespace Delegaty;

class Program
{
    static NotificationManager NotificationManager = new NotificationManager();

    static void Main(string[] args)
    {
        Console.WriteLine("Witaj w aplikcji powiadamiającej!");

        while (true)
        {
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Dodaj użytkownika");
            Console.WriteLine("2. Wyślij powiadomienie");
            Console.WriteLine("3. Zmień priorytet powiadomień");
            Console.WriteLine("4. Wyjdź");
            Console.Write("Twój wybór: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    SendNotification();
                    break;
                case "3":
                    ChangeNotifierPriority();
                    break;
                case "4":
                    Console.WriteLine("Dziękujemy za skorzystanie z aplikacji.");
                    return;
                default:
                    Console.WriteLine("Nieznana opcja.");
                    break;
            }
        }
    }

    static void AddUser()
    {
        Console.Write("Podaj imię użytkownika: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Wybierz typ powiadomienia:");
        Console.WriteLine("1. Email");
        Console.WriteLine("2. Push");
        Console.WriteLine("3. SMS");
        Console.Write("Twój wybór: ");

        string choice = Console.ReadLine() ?? string.Empty;
        NotifierType notifierType;

        switch (choice)
        {
            case "1":
                notifierType = NotifierType.Email;
                break;
            case "2":
                notifierType = NotifierType.Push;
                break;
            case "3":
                notifierType = NotifierType.Sms;
                break;
            default:
                Console.WriteLine("Nieznany typ powiadomienia!");
                return;
        }

        Console.Write("Podaj priorytet powiadomienia dla użytkownika: ");
        int priority = int.Parse(Console.ReadLine() ?? string.Empty);

        NotificationManager.AddUser(new User(name, notifierType, priority));
    }

    static void SendNotification()
    {
        Console.Write("Podaj treść powiadomienia: ");
        string message = Console.ReadLine() ?? string.Empty;

        Console.Write("Podaj priorytet powiadomienia: ");
        if (!int.TryParse(Console.ReadLine(), out int priority))
        {
            Console.WriteLine("Nieprawidłowy priorytet powiadomienia.");
            return;
        }

        NotificationManager.SetNewNotificationPriority(priority);
        NotificationManager.SendNotification(message);
    }

    static void ChangeNotifierPriority()
    {
        Console.Write("Podaj nowy priorytet powiadomienia: ");
        int priority = int.Parse(Console.ReadLine() ?? string.Empty);

        NotificationManager.SetNewNotificationPriority(priority);
    }
}