using static System.Console;
using dependency_injection_2.Interfaces;
using dependency_injection_2.Models;
using dependency_injection_2.Services;

namespace dependency_injection_2.Dialogs;

// Phase 0 - Original class
// public class StandardMenuDialogs
// Phase 5 - Primary Constructor is created.
// public class StandardMenuDialogs(UserService userService)
// Phase 6 - Extract Interface from StandardMenuDialogs to its own file.
// public class StandardMenuDialogs(UserService userService)
// Phase 7 - Ready for Dependency Injection
// public class StandardMenuDialogs(UserService userService) : IStandardMenuDialogs
// Phase 15 - Switch over from Base file to the Interface (IUserService)
public class StandardMenuDialogs(IUserService userService) : IStandardMenuDialogs
{
    // Phase 16 - Link List
    private readonly IUserService _userService = userService;
    // Phase 1 - Create list
    // private readonly UserService _userService = new UserService();
    // Phase 2 - Shorten it for a constructor initialization.
    // private readonly UserService _userService;
    // Phase 3 - CTRL + . >> Initiate Constructor
    // private readonly UserService _userService;
    // Phase 4 - Constructor is created 
    //  Next >> CTRL + . >> Convert to primary constructor  
    // public StandardMenuDialogs(UserService userService)
    // {
    //     _userService = userService;
    // }
    // Phase 8 - Make a link
    
    public void CreateUserOption()
    {
        var user = new User();
        
        WriteLine("STANDARD - ADD USER");
        Write("Enter name: ");
        user.Name = ReadLine()!;

        // userService.AddUser(user);
        _userService.AddUser(user);
        
        ReadKey();
        WriteLine();
    }

    public void ShowAllUsersOption()
    {
        // var users = userService.GetUsers();
        var users = _userService.GetUsers();
        
        WriteLine("STANDARD - VIEW ALL USERS");
        foreach (var user in users)
            WriteLine(user.Name);
        
        ReadKey();
        WriteLine();
    }
}