namespace LogoAlkoLator;

class Program
{
    static void Main()
    {
        string? user = Logowanie();
        if (user != "niezalogowany") Trzezwosc(user);
    }
    
    // SYSTEM LOGOWANIA
    static string? Logowanie()
    {
        Console.Write("Podaj nazwę użytkownika: ");
        string? user = Console.ReadLine();
        Console.Write("Podaj hasło użytkownika: ");
        string? passwd = Console.ReadLine();

        string?[] UsersDB = new string[100];
        string?[] PasswdsDB = new string[100];
        
        StreamReader Users = new("users.txt");
        int index = 0;
        while (!Users.EndOfStream)
        {
            UsersDB[index] = Users.ReadLine();
            index++;
        }

        index = 0;
        StreamReader Passwds = new("passwds.txt");
        while (!Passwds.EndOfStream)
        {
            PasswdsDB[index] = Passwds.ReadLine();
            index++;
        }

        bool CzyZalogowany = false;
        
        for (int i = 0; i < UsersDB.Length; i++)
        {
            if(user == UsersDB[i] && passwd == PasswdsDB[i])
            {
                Console.WriteLine("Logowanie udane!");
                CzyZalogowany = true;
                return user;
            }
        }

        Console.WriteLine("Logowanie nieudane!");
        return "niezalogowany";
    }

    // NIE DZIAŁA
    // Sprawdzanie trzeźwości
    static bool Trzezwosc(string? user)
    {
        Random Rand = new();
        double promil = Rand.NextDouble();

    }
}