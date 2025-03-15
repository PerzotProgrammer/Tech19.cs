using Zdarzenia.Controllers;
using Zdarzenia.Enums;
using Zdarzenia.Users;

namespace Zdarzenia;

class Program
{
    static void Main(string[] args)
    {
        UserStorage userStorage = UserStorage.GetInstance();

        Console.WriteLine("Witamy w aplikacji do robienia notatek!");
        while (true)
        {
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1. Zaloguj się");
            Console.WriteLine("2. Zarejestruj się");
            Console.WriteLine("3. Stwórz notatkę");
            Console.WriteLine("4. Przeczytaj notatkę");
            Console.WriteLine("5. Zaktualizuj notatkę");
            Console.WriteLine("6. Usuń notatkę");
            Console.WriteLine("7. Wyloguj się");
            Console.WriteLine("8. Wyjdź");
            Console.WriteLine("Twój wybór:");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Podaj nazwę użytkownika: ");
                    string? loginUsername = Console.ReadLine();
                    Console.Write("Podaj hasło: ");
                    string? loginPassword = Console.ReadLine();
                    userStorage.LoginUser(loginUsername!, loginPassword!);
                    break;
                case "2":
                    Console.Write("Podaj nazwę użytkownika: ");
                    string? registerUsername = Console.ReadLine();
                    Console.Write("Podaj hasło: ");
                    string? registerPassword = Console.ReadLine();
                    Console.WriteLine("Wybierz typ użytkownika: 1. Admin 2. User 3. Anonymous");
                    string? userTypeChoice = Console.ReadLine();
                    UserTypes userType = userTypeChoice switch
                    {
                        "1" => UserTypes.Admin,
                        "2" => UserTypes.Guest,
                        _ => UserTypes.Anonymous
                    };
                    userStorage.RegisterUser(registerUsername!, registerPassword!, userType);
                    break;
                case "3":
                    Console.Write("Podaj tytuł notatki: ");
                    string? createTitle = Console.ReadLine();
                    Console.Write("Podaj treść notatki: ");
                    string? createContent = Console.ReadLine();
                    Console.WriteLine(userStorage.CurrentUser.TryCreatePost(createTitle!, createContent!)
                        ? "Notatka została stworzona."
                        : "Nie masz uprawnień do stworzenia notatki.");

                    break;
                case "4":
                    Console.Write("Podaj tytuł notatki: ");
                    string? readTitle = Console.ReadLine();
                    if (!userStorage.CurrentUser.TryReadPost(readTitle!))
                    {
                        Console.WriteLine("Nie masz uprawnień do przeczytania notatki lub notatka nie istnieje.");
                    }

                    break;
                case "5":
                    Console.Write("Podaj tytuł notatki: ");
                    string? updateTitle = Console.ReadLine();
                    Console.Write("Podaj nową treść notatki: ");
                    string? updateContent = Console.ReadLine();
                    Console.WriteLine(userStorage.CurrentUser.TryUpdatePost(updateTitle!, updateContent!)
                        ? "Notatka została zaktualizowana."
                        : "Nie masz uprawnień do zaktualizowania notatki.");

                    break;
                case "6":
                    Console.Write("Podaj tytuł notatki: ");
                    string? deleteTitle = Console.ReadLine();
                    Console.WriteLine(userStorage.CurrentUser.TryDeletePost(deleteTitle!)
                        ? "Notatka została usunięta."
                        : "Nie masz uprawnień do usunięcia notatki.");

                    break;
                case "7":
                    userStorage.LogoutUser();
                    Console.WriteLine("Wylogowano.");
                    break;
                case "8":
                    Console.WriteLine("Do widzenia!");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }
}