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
        UserDataManager.OperationResult += OnUserLogin;

        CurrentUser = UserDataManager.LoginUser(username, password) ?? CurrentUser;
        UserDataManager.OperationResult -= OnUserLogin;
    }

    public void RegisterUser(string username, string password, UserTypes type)
    {
        UserDataManager.OperationResult += OnUserRegister;
        UserDataManager.SaveUser(new User(username, password, type));
        UserDataManager.OperationResult -= OnUserRegister;
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