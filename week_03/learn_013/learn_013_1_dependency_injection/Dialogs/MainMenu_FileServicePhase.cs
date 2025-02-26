using static System.Console;
using Business.Models;
using Business.Services;
using learn_013_1_dependency_injection.Interfaces;

namespace learn_013_1_dependency_injection.Dialogs;

public class MainMenuFileServicePhase(IUserService userService) : IMainMenuFileServicePhase
{
    private readonly IUserService _userService = userService;
    
    public void ShowMenuOptions()
    {
        while (true)
        {
            Clear();
            WriteLine("************** USER MANAGEMENT **************");
            WriteLine("1. Create New User");
            WriteLine("2. View All Users");
            WriteLine("*********************************************");
            Write("Select an option: ");
            var option = ReadLine();
        
            switch (option)
            {
                case "1":
                    
                    break;
                case "2":
                   
                    break;
                default:
                    WriteLine("Invalid option");
                    break;
            }
        }
    }

    public void CreateUserOption()
    {
        var user = new User();
        
        Clear();
        WriteLine("**************** CREATE NEW USER ***************");
        Write("Enter First Name: ");
        user.FirstName = ReadLine();
        Write("Enter Last Name: ");
        user.LastName = ReadLine();
        
        _userService.CreateUser(user);
    }

    public void ViewAllUsers()
    {
        Clear();
        WriteLine("**************** VIEW ALL USERS ****************");

        foreach (var user in _userService.GetAllUsers())
        {
            WriteLine($"{user.FirstName} {user.LastName}");
        }

        ReadKey();
    }
}