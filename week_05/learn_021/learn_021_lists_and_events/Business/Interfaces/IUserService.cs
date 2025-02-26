using Business.Models;

namespace Business.Interfaces;

public interface IUserService
{
    bool CreateUser(UserRegistrationForm form);
    IEnumerable<User> GetUsers();
    bool UpdateUser(User user);
    public bool DeleteUser(string id);
}