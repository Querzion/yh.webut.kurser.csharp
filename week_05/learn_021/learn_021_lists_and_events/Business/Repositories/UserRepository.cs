using System.Diagnostics;
using System.Text.Json;
using Business.Interfaces;
using Business.Models;

namespace Business.Repositories;

public class UserRepository : BaseRepository<UserEntity>, IUserRepository
{
    private readonly IUserFileService _userFileService;

    public UserRepository(IUserFileService userFileService)
    {
        _userFileService = userFileService;
    }

    public override bool SaveToFile(List<UserEntity> list)
    {
        try
        {
            var json = JsonSerializer.Serialize(list);
            Debug.WriteLine($"Serialized JSON: {json}");
            _userFileService.SaveContentToFile(json);
            
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error saving to file: {ex.Message}");
            return false;
        }
    }

    public override List<UserEntity>? GetFromFile()
    {
        var json = _userFileService.GetContentFromFile();
        var list = Deserialize(json);
        return list;
    }
}