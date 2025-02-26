using learn_009_save_open_from_json.Models;

namespace learn_009_save_open_from_json.Services;

public class UserService
{
    // Initialize a construct list of type User.
    private List<User> _users = [];
    // Initialize a FileService Construct list, that is immutable.
    private readonly FileService _fileService = new FileService(@"C:\Projects\", "users.json");

    public void Add(User user)
    {
        // Add to the list using User.Add
        _users.Add(user);
        // Read into _fileService with the type User from _users.
        //_fileService.SaveListToFile<User>(_users);
        _fileService.SaveListToFile(_users);
    }

    public IEnumerable<User> GetAll()
    {
        _users = _fileService.LoadListFromFile();
        return _users;
    }
}
