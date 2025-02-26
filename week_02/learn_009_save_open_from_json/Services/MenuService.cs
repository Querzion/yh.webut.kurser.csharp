using learn_009_save_open_from_json.Models;

namespace learn_009_save_open_from_json.Services;

public class MenuService
{
    private readonly UserService _userService = new();

    public void CreateUserDialog()
    {
        Console.Clear();

        var user = new User();

        Console.Write("Enter your first name: ");
        user.FirstName = Console.ReadLine()!;

        Console.Write("Enter your last name: ");
        user.LastName = Console.ReadLine()!;

        Console.Write("Enter your email: "); 
        user.Email = Console.ReadLine()!;

        _userService.Add(user);
    }

    public void ViewAllUsersDialog()
    {
        Console.Clear();

        // This way is more appropriate for bugfixing.
        var users = _userService.GetAll();   
        foreach (var user in users)
        // Then this, but it works equally as like this.
        // foreach (var user in _userService.GetALL())
        {
            Console.WriteLine($"{"Id:",-15}{user.Id}");
            Console.WriteLine($"{"Name:",-15}{user.FirstName} {user.LastName}");
            Console.WriteLine($"{"Email:",-15}{user.Email}");
            Console.WriteLine("");
        }

        Console.ReadKey();
    }
}
