using dependency_injection_2.Interfaces;
using dependency_injection_2.Models;

namespace dependency_injection_2.Services;

// Phase 0 - Original class
// public class UserService
// Phase 6 - Extract Interface from UserService to its own file.
// public class UserService
// Phase 7 - Ready for Dependency Injection
public class UserService : IUserService
{
    // Phase 1 - Create List Array
    // private List<User> _users = [];
    // When you extract an interface and use that instead; then there's going to be problems with the list.
    // Phase 12 - Shorten it for a constructor initialization.
    // private List<User> _users;
    // Phase 13 - CTRL + . >> Initiate Constructor
    private readonly List<User> _users;
    // Phase 14 - Constructor created.
    public UserService(List<User> users)
    {
        _users = users;
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public IEnumerable<User> GetUsers()
    {
        return _users;
    }
}