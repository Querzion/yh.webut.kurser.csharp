using Business.Helpers;
using Domain2.Dtos;
using Domain2.Factories;
using Domain2.Models;

namespace Business.Services;

public class UserService
{
    private List<User> _users = [];
    private readonly FileService _fileService = new();

    public void Add(UserRegistrationForm form)
    {
        User user = UserFactory.Create(form);
        user.Id = UniqueIdentifierGenerator.Generate();

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