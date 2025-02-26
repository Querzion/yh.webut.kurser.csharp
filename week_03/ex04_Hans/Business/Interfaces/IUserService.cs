using Business.Models;

namespace Business.Interfaces;

public interface IUserService
{
    public void AddUser(UserBase user);
    // UserBase? GetUserById(int userId);
    UserBase GetUserById(int userId);
    IEnumerable<UserBase> GetAllUsers();
}