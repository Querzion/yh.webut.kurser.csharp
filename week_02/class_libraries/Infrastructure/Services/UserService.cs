// Part of Lesson 010
using Infrastructure.Dtos;
using Infrastructure.Factories;
using Infrastructure.Models;

namespace Infrastructure.Services;

public class UserService
{
    private List<User> _users = [];
    private readonly FileService _fileService = new();

    public void Add(UserRegistrationForm form)
    {
        User user = UserFactory.Create(form);
        _users.Add(user);
        _fileService.SaveListToFile(_users);
    }

    public IEnumerable<User> GetAll()
    {
        _users = _fileService.LoadListFromFile();
        return _users;
    }

    public bool RemoveAll()
    {
        try
        {
            // Clear the in-memory user list
            _users.Clear();

            // Clear the persisted user data in the file
            _fileService.SaveListToFile(_users);

            return true; // Indicate success
        }
        catch
        {
            return false; // Indicate failure
        }
    }
}
