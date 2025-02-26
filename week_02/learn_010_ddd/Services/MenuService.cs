//using Infrastructure.Dtos;
//using Infrastructure.Factories;
//using Infrastructure.Models;
//using Infrastructure.Services;

using Business.Services;
using Domain2.Dtos;
using Domain2.Factories;

namespace learn_010_ddd.Services;

public class MenuService
{
    private readonly UserService _userService = new();

    public void ShowMenuDialog()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n------------ MENU OPTIONS ------------\n");
            Console.WriteLine($"{"1.",-3} CREATE USER");
            Console.WriteLine($"{"2.",-3} VIEW ALL USERS");
            Console.WriteLine($"{"3.",-3} REMOVE ALL USERS");
            Console.WriteLine($"{"Q.",-3} QUIT");
            Console.WriteLine("\n--------------------------------------\n");
            Console.Write("Selected Option: ");
            var option = Console.ReadLine()!;

            switch (option.ToUpper())
            {
                case "1":
                    CreateUserDialog();
                    break;
                case "2":
                    ViewAllUsersDialog();
                    break;
                case "3":
                    RemoveAllUsersDialog();
                    break;
                case "Q":
                    QuitApplicationDialog();
                    break;
                default:
                    InvalidOptionDialog();
                    break;

            }
        }
    }

    public void CreateUserDialog()
    {
        Console.Clear();
        Console.WriteLine("\n------------ CREATE USER ------------\n");

        UserRegistrationForm user = UserFactory.Create();

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
        Console.WriteLine("\n------------ VIEW ALL USERS ------------\n");

        var users = _userService.GetAll();
        foreach (var user in users)
        {
            Console.WriteLine($"{"Id:",-15}{user.Id}");
            Console.WriteLine($"{"Name:",-15}{user.FirstName} {user.LastName}");
            Console.WriteLine($"{"Email:",-15}{user.Email}");
            Console.WriteLine("");
        }

        Console.ReadKey();
    }

    public void RemoveAllUsersDialog()
    {
        Console.Clear();
        Console.WriteLine("\n------------ REMOVE ALL USERS ------------\n");
        Console.Write("You are about to remove all users \n\nAre you sure this is what you want? y/n: ");
        var option = Console.ReadLine()!;

        if (option.ToLower() == "y")
        {
            Console.Clear();
            var result = _userService.RemoveAll();
            if (result)
                Console.WriteLine("All users was successfully  removed.");
            else
                Console.WriteLine("Something went wrong. Users was not removed.");

            Console.ReadKey();
        }
    }

    public void QuitApplicationDialog()
    {
        Console.Clear();
        Console.WriteLine("\n------------ QUIT APPLICATION ------------\n");
        Console.Write("Are you sure you want to exit? (y/n): ");
        var option = Console.ReadLine()!;

        if (option.ToLower() == "y")
            Environment.Exit(0);
    }

    public void InvalidOptionDialog()
    {
        Console.WriteLine("");
        Console.WriteLine("Invalid option selected. Please try again.");
        Console.ReadKey();
    }
}