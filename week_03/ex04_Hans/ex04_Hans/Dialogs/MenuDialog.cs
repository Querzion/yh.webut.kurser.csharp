using Business.Interfaces;
using Business.Models;
using static System.Console;

namespace ex04_Hans.Dialogs;

public class MenuDialog(IUserService userService)
{
    private readonly IUserService _userService = userService;

    public void ViewAllUsers()
    {
        WriteLine();
        WriteLine("------ VIEW ALL USERS ------");
        
        foreach (var user in _userService.GetAllUsers())
            WriteLine($"{user.Name} ({user.GetRole()})");

        ReadKey();
    }

    public void NewRegularUser()
    {
        var user = new RegularUser();
        
        WriteLine();
        WriteLine("------ NEW REGULAR USER ------");
        WriteLine("Please enter user name: ");
        user.Name = ReadLine()!;
        
        _userService.AddUser(user);
    }
    
    public void NewAdminUser()
    {
        var user = new AdminUser();
        
        WriteLine();
        WriteLine("------ NEW ADMIN USER ------");
        WriteLine("Please enter user name: ");
        user.Name = ReadLine()!;
        
        _userService.AddUser(user);
    }
}