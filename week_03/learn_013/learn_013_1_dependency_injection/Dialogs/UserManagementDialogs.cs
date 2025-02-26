using static System.Console;
using Business.Services;

namespace learn_013_1_dependency_injection.Dialogs;

public interface IUserManagementDialogs
{
    void ShowMenuOptions();
}

public class UserManagementDialogs(IUserService userService) : IUserManagementDialogs
{
    private readonly IUserService _userService = userService;

    public void ShowMenuOptions()
    {
        WriteLine("************** USER MANAGEMENT **************");
        WriteLine("1. Create New User");
        WriteLine("2. View All Users");
        WriteLine("3. View User");
        WriteLine("*********************************************");
        Write("Select an option: ");
        var option = ReadLine();
        
        switch (option)
        {
            case "1":
                // _userService.CreateUser();
                break;
            case "2":
                _userService.GetAllUsers().ToList();
                break;
            case "3":
                // _userService.GetUser();
                break;
            default:
                WriteLine("Invalid option");
                break;
        }
    }
}