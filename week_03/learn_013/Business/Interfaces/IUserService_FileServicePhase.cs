using Business.Models;

namespace Business.Interfaces;

public interface IUserService_FileServicePhase
{
    void CreateUser(User user);
    IEnumerable<User> GetAllUsers();
}