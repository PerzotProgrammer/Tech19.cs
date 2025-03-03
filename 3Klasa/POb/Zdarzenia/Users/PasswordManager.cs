using System.Security.Cryptography;
using System.Text;

namespace Zdarzenia.Users;

public static class PasswordManager
{
    private const string PasswordsFilePath = "passwords.txt";
    public static event Action<string, bool>? PasswordVerified;

    static PasswordManager()
    {
        if (!File.Exists(PasswordsFilePath))
        {
            File.Create(PasswordsFilePath).Close();
        }
    }

    public static void SaveUser(User user)
    {
        using (StreamReader reader = new StreamReader(PasswordsFilePath))
        {
            while (!reader.EndOfStream)
            {
                string[] parts = reader.ReadLine()!.Split(", ");
                if (parts[0] == user.Username)
                {
                    PasswordVerified?.Invoke("User already exists", false);
                    return;
                }
            }
        }

        using StreamWriter writer = new(PasswordsFilePath, true);
        writer.WriteLine($"{user.Username}, {HashPassword(user.Password)}, {user.Type.ToString()}");
        PasswordVerified?.Invoke("User created", true);
    }

    public static User? LoginUser(string username, string password)
    {
        using StreamReader reader = new StreamReader(PasswordsFilePath);
        while (!reader.EndOfStream)
        {
            string[] parts = reader.ReadLine()!.Split(", ");
            if (parts[0] == username)
            {
                if (ComparePassword(password, parts[1]))
                {
                    UserTypes type = Enum.Parse<UserTypes>(parts[2]);
                    PasswordVerified?.Invoke("User logged in", true);
                    return new User(username, password, type);
                }

                PasswordVerified?.Invoke("Incorrect password", false);
                return null;
            }
        }

        PasswordVerified?.Invoke("User doesn't exists", false);
        return null;
    }

    private static string HashPassword(string password)
    {
        using SHA256 sha256 = SHA256.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(password);
        byte[] hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }

    private static bool ComparePassword(string password, string hash)
    {
        return HashPassword(password) == hash;
    }
}