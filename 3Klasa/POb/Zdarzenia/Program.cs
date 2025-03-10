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
        userStorage.RegisterUser("guest", "guest", UserTypes.Guest);
        userStorage.LoginUser("admin", "admin");
        userStorage.LoginUser("admin", "wrongpassword");
        userStorage.LoginUser("nonexistinguser", "password");
        userStorage.RegisterUser("admin", "admin", UserTypes.Admin);
        userStorage.LoginUser("guest", "guest");
        userStorage.CurrentUser.TryCreatePost("FirstPost", "This is the first post ever!");
        userStorage.CurrentUser.TryReadPost("FirstPost");
        userStorage.CurrentUser.TryUpdatePost("FirstPost", "This is the updated post!");
        userStorage.CurrentUser.TryDeletePost("FirstPost");
        userStorage.LoginUser("admin", "admin");
        userStorage.CurrentUser.TryDeletePost("FirstPost");
        userStorage.CurrentUser.TryCreatePost("AdminNotes", "Shhh... this is secret note");
    }
}