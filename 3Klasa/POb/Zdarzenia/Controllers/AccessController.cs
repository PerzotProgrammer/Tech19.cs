using Zdarzenia.Enums;
using Zdarzenia.Users;

namespace Zdarzenia.Controllers;

public class AccessController
{
    private static readonly Dictionary<UserTypes, List<ActionTypes>> AccessMatrix;
    public static event Action<ActionResultTypes, bool>? OperationResult;


    static AccessController()
    {
        AccessMatrix = new Dictionary<UserTypes, List<ActionTypes>>
        {
            { UserTypes.Anonymous, [ActionTypes.Read] },
            { UserTypes.Guest, [ActionTypes.Read, ActionTypes.Write] },
            { UserTypes.Moderator, [ActionTypes.Read, ActionTypes.Write, ActionTypes.Update] },
            {
                UserTypes.Admin,
                [ActionTypes.Read, ActionTypes.Write, ActionTypes.Update, ActionTypes.Delete, ActionTypes.SuperUser]
            }
        };
    }

    public static bool CanPerformAction(UserTypes userType, ActionTypes action)
    {
        bool canPerform = AccessMatrix[userType].Contains(action);

        if (!canPerform)
        {
            OperationResult?.Invoke(ActionResultTypes.Forbidden, false);
            return false;
        }

        OperationResult?.Invoke(ActionResultTypes.Ok, true);
        return true;
    }
}