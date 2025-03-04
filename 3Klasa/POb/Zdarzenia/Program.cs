using Zdarzenia.Controllers;
using Zdarzenia.Enums;
using Zdarzenia.Users;

namespace Zdarzenia;

class Program
{
    static void Main(string[] args)
    {
        UserStorage userStorage = UserStorage.GetInstance();
        userStorage.RegisterUser("admin", "admin", UserTypes.Admin);
        userStorage.LoginUser("admin", "admin");
        userStorage.LoginUser("admin", "wrongpassword");
        userStorage.LoginUser("nonexistinguser", "password");
        userStorage.RegisterUser("admin", "admin", UserTypes.Admin);
    }
}