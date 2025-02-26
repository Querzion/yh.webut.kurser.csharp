using System.Text.Json;
using Business.Converters;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class UserService(IFileService fileService) : IUserService
{
    private readonly IFileService _fileService = fileService;
    private List<UserBase> _users = [];

    private readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        Converters = { new UserBaseJsonConverter() },
        WriteIndented = true,
    };

    public void AddUser(UserBase user)
    {
        // user.Id = _users.Count != 0 ? _users[^1].Id + 1 : 1;
        user.Id = _users.Count != 0 ? _users.Last().Id + 1 : 1;
        _users.Add(user);
        
        SaveUsersToFile();
    }

    // public UserBase? GetUserById(int userId)
    public UserBase GetUserById(int userId)
    {
        
        PopulateUsersFromFile();
        // 
        // var user = _users.FirstOrDefault(u => u.Id == userId, new AdminUser());
        var user = _users.FirstOrDefault(u => u.Id == userId);
        // if (user != null) 
        //     return user;
        //
        // return null;
        

        return user ?? null!;
    }

    public IEnumerable<UserBase> GetAllUsers()
    {
        PopulateUsersFromFile();
        
        return _users;
    }

    // public void UpdateUser(UserBase user)
    // {
    //     var existingUser = GetUserById(user.Id);
    //     if (existingUser != null)
    //     {
    //         existingUser.Name = user.Name;
    //         SaveUsersToFile();
    //     }
    // }
    
    
    public void PopulateUsersFromFile()
    {
        var json = _fileService.ReadContentFromFile();

        if (!string.IsNullOrEmpty(json))
        {
            _users = JsonSerializer.Deserialize<List<UserBase>>(json, _jsonSerializerOptions)!;
        }
        
    }

    public void SaveUsersToFile()
    {
        var json = JsonSerializer.Serialize(_users, _jsonSerializerOptions);
        _fileService.SaveContentToFile(json);
    }
}