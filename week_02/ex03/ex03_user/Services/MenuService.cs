using static System.Console;
using System.Runtime.InteropServices;
using ex03_infrastructure.Models;
using ex03_infrastructure.Services;

namespace ex03_user.Services;

public class MenuService
{
    private readonly UserService _userService = new ();
    
    public void ShowMenu()
    {
        while (true)
        {
            MainMenu();
        }
    }
    
    private void MainMenu()
    {
        Clear();
        WriteLine("************************************");
        WriteLine($"{"1.",-8} Create User");
        WriteLine($"{"2.",-8} List Users");
        WriteLine($"{"Q.",-8} Quit Application");
        WriteLine("************************************");
        Write("Choose an option: ");
        var option = ReadLine()!;
        
        MenuOptions(option);
    }

    private void MenuOptions(string option)
    {
        switch (option.ToLower())
        {
            case "1":
                Clear();
                AddUserOption();
                break;
            case "2":
                Clear();
                ShowAllUsersOption();
                break;
            case "q":
                QuitOption();
                break;
            default:
                OutputDialog("Invalid option, please try again.");
                break;
        }
    }

    private void QuitOption()
    {
        Clear();
        WriteLine("***********************************");
        Write("Do you really want to quit? (y/n): ");
        var confirm = ReadLine()!;

        if (confirm.Equals("y", StringComparison.CurrentCultureIgnoreCase))
        {
            Environment.Exit(0);
        }
    }

    public void AddUserOption()
    {
        var user = new User();
        
        Clear();
        WriteLine("************* ADD NEW CONTACT **************");
        
        Write("Enter contact firstname: ");
        user.FirstName = ReadLine()!;
        
        Write("Enter contact lastname: ");
        user.LastName = ReadLine()!;
        
        Write("Enter contact email: ");
        user.Email = ReadLine()!;
        
        _userService.CreateUsers(user);
    }

    public void ShowAllUsersOption()
    {
        bool hasError;
        var users = _userService.GetAllUsers(out hasError);
        
        Clear();
        WriteLine("************* VIEW ALL CONTACTS **************");

        if (hasError)
        {
            OutputDialog("There was an error getting all contacts. Please try again.");
            return;
        }
        
        if (!users.Any())
        {
            OutputDialog("There are no contacts found! Press any key to go back...");
            return;
        }

        foreach (var user in users)
        {
            WriteLine($"ContactId: {user.Id} Name: {user.FirstName} {user.LastName} Email: {user.Email} Date: {user.CreatedAt}");
        }
        ReadKey();
    }

    public void OutputDialog(string message)
    {
        WriteLine(message);
        ReadKey();
    }
}