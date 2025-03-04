using System.Security.Cryptography;
using System.Text;
using Zdarzenia.Enums;
using Zdarzenia.Users;

namespace Zdarzenia.Controllers;

public static class PasswordManager
{
    private const string PasswordsFilePath = "./UserData.csv";
    public static event Action<LoginResultTypes, bool>? OperationResult;

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
                string[] parts = reader.ReadLine()!.Split(",");
                if (parts[0] == user.Username)
                {
                    OperationResult?.Invoke(LoginResultTypes.NameTaken, false);
                    return;
                }
            }
        }

        using StreamWriter writer = new(PasswordsFilePath, true);
        writer.WriteLine($"{user.Username}, {HashPassword(user.Password)}, {user.Type.ToString()}");
        OperationResult?.Invoke(LoginResultTypes.Ok, true);
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
                    OperationResult?.Invoke(LoginResultTypes.Ok, true);
                    return new User(username, password, type);
                }

                OperationResult?.Invoke(LoginResultTypes.IncorrectPassword, false);
                return null;
            }
        }

        OperationResult?.Invoke(LoginResultTypes.UserDoesntExist, false);
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