using System.Security.Cryptography;
using System.Text;

namespace KartkowkaMarzec.Services;

public class PasswordManager
{
    private const string PasswordFilePath = "userPasswords.txt";
    public static event Action<string, bool>? PasswordVerified;

    static PasswordManager()
    {
        if (!File.Exists(PasswordFilePath))
        {
            File.Create(PasswordFilePath).Dispose();
        }
    }

    public static void SavePassword(string username, string password)
    {
        if (File.ReadLines(PasswordFilePath).Any(line => line.Split(',')[0] == username))
        {
            Console.WriteLine($"Użytkownik {username} już istnieje w systemie");
            return;
        }

        string hashedPassword = HashPassword(password);
        File.AppendAllText(PasswordFilePath, $"{username},{hashedPassword}\n");
        Console.WriteLine($"Użytkownik {username} został zapisany");
    }

    private static string HashPassword(string password)
    {
        using SHA256 sha256 = SHA256.Create();
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    public static bool VerifyPassword(string username, string password)
    {
        string hashedPassword = HashPassword(password);
        foreach (string line in File.ReadLines(PasswordFilePath))
        {
            string[] parts = line.Split(",");
            if (parts[0] == username && parts[1] == hashedPassword)
            {
                PasswordVerified?.Invoke(username, true);
                return true;
            }
        }

        PasswordVerified?.Invoke(username, false);
        return false;
    }
}