using Zdarzenia.Controllers;
using Zdarzenia.Enums;

namespace Zdarzenia.Users;

public class User
{
    public string Username { get; private set; }
    public string Password { get; private set; }
    public UserTypes UserType { get; private set; }

    public User(string username, string password, UserTypes userType)
    {
        Username = username;
        Password = password;
        UserType = userType;
    }

    public bool TryCreatePost(string title, string content)
    {
        AccessController.OperationResult += OnOperationResult;
        bool canPerform = AccessController.CanPerformAction(UserType, ActionTypes.Write);
        AccessController.OperationResult -= OnOperationResult;
        if (canPerform)
        {
            OperationsController.CreatePost(title, content);
            return true;
        }

        return false;
    }

    public bool TryReadPost(string title)
    {
        AccessController.OperationResult += OnOperationResult;
        bool canPerform = AccessController.CanPerformAction(UserType, ActionTypes.Read);
        AccessController.OperationResult -= OnOperationResult;
        if (canPerform)
        {
            string? post = OperationsController.ReadPost(title);
            if (post != null)
            {
                Console.WriteLine(post);
                return true;
            }
        }

        return false;
    }

    public bool TryUpdatePost(string title, string content)
    {
        AccessController.OperationResult += OnOperationResult;
        bool canPerform = AccessController.CanPerformAction(UserType, ActionTypes.Update);
        AccessController.OperationResult -= OnOperationResult;
        if (canPerform)
        {
            OperationsController.UpdatePost(title, content);
            return true;
        }

        return false;
    }

    public bool TryDeletePost(string title)
    {
        AccessController.OperationResult += OnOperationResult;
        bool canPerform = AccessController.CanPerformAction(UserType, ActionTypes.Delete);
        AccessController.OperationResult -= OnOperationResult;
        if (canPerform)
        {
            OperationsController.DeletePost(title);
            return true;
        }

        return false;
    }

    public void OnOperationResult(ActionResultTypes result, bool success)
    {
        Console.WriteLine(success ? "Operation successful!" : $"Operation failed: {result.ToString()}");
    }
}