using System.Text.Json;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class UserService_FileServicePhase : IUserService_FileServicePhase
{
    private readonly IFileService _fileService;
    private List<User> _users;

    public UserService_FileServicePhase(IFileService fileService)
    {
        _fileService = fileService;
        
        try
        {
            _users = JsonSerializer.Deserialize<List<User>>(_fileService.GetContentFromFile())!;
        }
        catch (Exception e)
        {
            _users = [];
        }

    }

    #region Methods

    public void CreateUser(User user)
    {
        user.Id = Guid.NewGuid().ToString();
        _users.Add(user);
        _fileService.SaveToFile(JsonSerializer.Serialize(_users));
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _users;
    }
    
    #endregion
}