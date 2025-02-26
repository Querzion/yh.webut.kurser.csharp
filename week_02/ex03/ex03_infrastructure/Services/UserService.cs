using System.Text.Json;
using ex03_infrastructure.Models;

namespace ex03_infrastructure.Services;

public class UserService
{
    private readonly FileService _fileService = new ();
    private List<User> _usersList = [];

    public void CreateUsers(User user)
    {
        user.Id = _usersList.Count > 0 ? _usersList[^1].Id + 1 : 1;
        user.CreatedAt = DateTime.Now;
        
        _usersList.Add(user);
        
        var json = JsonSerializer.Serialize(_usersList);
        _fileService.SaveUsersToFile(json);
    }

    public IEnumerable<User> GetAllUsers(out bool hasError)
    {
        hasError = false;
        var json = _fileService.GetUsersFromFile();
        if (!string.IsNullOrEmpty(json))
        {
            try
            {
                _usersList = JsonSerializer.Deserialize<List<User>>(json) ?? [];
            }
            catch
            {
                hasError = true;
            }
        }
        
        return _usersList;
    }
}