using learn_011_interfaces.Models;

namespace learn_011_interfaces.Interfaces;

public interface IUserService
{
    // void AddUser(User user);
    void CreateUser(User user);
    IEnumerable<User> GetUsers();
    User GetUserById(string id);
    User GetUserByEmail(string email);
}