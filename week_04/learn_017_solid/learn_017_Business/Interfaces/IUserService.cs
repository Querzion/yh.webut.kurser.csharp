using learn_017_Business.Models;

namespace learn_017_Business.Interfaces;

public interface IUserService
{
    bool CreateUser(UserRegistrationForm form); 
    IEnumerable<User> GetUsers();
}