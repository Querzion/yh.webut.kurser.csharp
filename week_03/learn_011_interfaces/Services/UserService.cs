using learn_011_interfaces.Interfaces;
using learn_011_interfaces.Models;

namespace learn_011_interfaces.Services;

public class UserService : IUserService
{
    private List<User> _users = [];
    
    public void CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetUsers()
    {
        throw new NotImplementedException();
    }

    public User GetUserById(string id)
    {
        throw new NotImplementedException();
    }

    public User GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public void AddUserToList(User user)
    {
        _users.Add(user);
    }
}