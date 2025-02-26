using Business.Models;

namespace Business.Services;

public class UserService(List<UserBase> users)
{
    public void AddUser(UserBase user)
    {
        users.Add(user);
    }

    public IEnumerable<UserBase> GetUserById(int id)
    {
        return users.Where(u => u.Id == id);
    }
    
    public IEnumerable<UserBase> GetAllUsers()
    {
        return users;
    }
}