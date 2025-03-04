using Zdarzenia.Enums;
using Zdarzenia.Users;

namespace Zdarzenia.Controllers;

public class AccessController
{
    private static readonly Dictionary<UserTypes, List<ActionTypes>> AccessMatrix;

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
        return AccessMatrix[userType].Contains(action);
    }
}