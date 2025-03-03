using Zdarzenia.Users;

namespace Zdarzenia.RBAC;

public class AccessController
{
    private readonly Dictionary<UserTypes, List<ActionTypes>> AccessMatrix;

    public AccessController()
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

    public bool CanPerformAction(UserTypes userType, ActionTypes action)
    {
        return AccessMatrix[userType].Contains(action);
    }
}