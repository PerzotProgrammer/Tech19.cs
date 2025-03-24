using KartkowkaMarzec.Enums;

namespace KartkowkaMarzec.Models;

public class User
{
    public string Username { get; set; }
    public List<Role> Roles { get; set; }

    public User(string username)
    {
        Username = username;
        Roles = new List<Role>();
    }

    public void AddRole(Role role)
    {
        if (!Roles.Contains(role))
        {
            Roles.Add(role);
        }
    }
}