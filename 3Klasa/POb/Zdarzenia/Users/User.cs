using Zdarzenia.Enums;

namespace Zdarzenia.Users;

public class User
{
    public string Username { get; private set; }
    public string Password { get; private set; }
    public UserTypes Type { get; private set; }

    public User(string username, string password, UserTypes type)
    {
        Username = username;
        Password = password;
        Type = type;
    }
}