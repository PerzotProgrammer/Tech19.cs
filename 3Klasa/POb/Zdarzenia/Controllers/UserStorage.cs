using Zdarzenia.Enums;
using Zdarzenia.Users;

namespace Zdarzenia.Controllers;

public class UserStorage
{
    private static UserStorage? Instance;
    public User CurrentUser { get; private set; }

    private UserStorage()
    {
        CurrentUser = new User("Anonymous", "", UserTypes.Anonymous);
    }

    public static UserStorage GetInstance()
    {
        return Instance ??= new UserStorage();
    }

    public void LoginUser(string username, string password)
    {
        PasswordManager.OperationResult += OnUserLogin;

        CurrentUser = PasswordManager.LoginUser(username, password) ?? CurrentUser;
        PasswordManager.OperationResult -= OnUserLogin;
    }

    public void RegisterUser(string username, string password, UserTypes type)
    {
        PasswordManager.OperationResult += OnUserRegister;
        PasswordManager.SaveUser(new User(username, password, type));
        PasswordManager.OperationResult -= OnUserRegister;
    }

    public void LogoutUser()
    {
        CurrentUser = new User("Anonymous", "", UserTypes.Anonymous);
    }

    private static void OnUserLogin(LoginResultTypes result, bool success)
    {
        Console.WriteLine(success ? "Login successful!" : $"Login failed: {result.ToString()}");
    }

    private static void OnUserRegister(LoginResultTypes result, bool success)
    {
        Console.WriteLine(success ? "Registration successful!" : $"Registration failed: {result.ToString()}");
    }
}