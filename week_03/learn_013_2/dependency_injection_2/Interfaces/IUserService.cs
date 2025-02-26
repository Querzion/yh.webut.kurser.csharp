using dependency_injection_2.Models;

namespace dependency_injection_2.Interfaces;

public interface IUserService
{
    void AddUser(User user);
    IEnumerable<User> GetUsers();
}