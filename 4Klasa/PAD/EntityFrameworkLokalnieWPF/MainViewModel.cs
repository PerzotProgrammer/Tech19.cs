using System.Collections.ObjectModel;

namespace EntityFrameworkLokalnieWPF;

public class MainViewModel
{
    private UserDatabase _databaseContext;
    public ObservableCollection<User> UsersList { get; }

    public MainViewModel()
    {
        _databaseContext = new UserDatabase();
        UsersList = new ObservableCollection<User>(_databaseContext.Users);
    }

    public void AddUser(User user)
    {
        _databaseContext.Users.Add(user);
        _databaseContext.SaveChanges();
        UsersList.Add(user);
    }
}