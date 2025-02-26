using static System.Console;

using learn_015_Business.Models;
using learn_015_Business.Services;
using learn_015_generics.Interfaces;

namespace learn_015_generics.Dialogs;

public class MenuDialogs(ProductService productService, UserService userService)
{
    private readonly ProductService _productService = productService;
    private readonly UserService _userService = userService;

    public void ShowMenu()
    {
        while (true)
        {
            MenuOptionsDialog();
        }
    }

    private void MenuOptionsDialog()
    {
        Dialogs.MenuHeading("Main Menu");
        WriteLine("1. New Product");
        WriteLine("2. View Products");
        WriteLine("3. New User");
        WriteLine("4. View Users");
        WriteLine("_____________________________________");
        var option = Dialogs.Prompt(" Select an option: ");
        
        MenuOptionsSwitcher(option);
    }

    private void MenuOptionsSwitcher(string option)
    {
        switch (option)
        {
            case "1":
                AddProductDialog();
                break;
            case "2":
                ViewProductsDialog();
                break;
            case "3":
                AddUserDialog();
                break;
            case "4":
                ViewUsersDialog();
                break;
            default:
                WriteLine("Invalid option, please try again.");
                break;
        }
    }

    private void AddProductDialog()
    {
        Dialogs.MenuHeading("New Product");

        var product = new Product
        {
            Title = Dialogs.Prompt("Enter Product Title: "),
            Price = Dialogs.Prompt("Enter Product Price: ")
        };
        
        var result = _productService.SaveProduct(product);
        
        if (result.Success)
            WriteLine($"Product was successfully added.");
        else
            WriteLine($"{result.Message}");

        ReadKey();
    }

    private void ViewProductsDialog()
    {
        Dialogs.MenuHeading("Products");

        var items = _productService.GetAllProducts().Result!;
        
        if (items.Any())
            foreach (var product in items)
                WriteLine($"#{product.Id} - {product.Title} ({product.Price} SEK)");
        
        ReadKey();
    }

    private void AddUserDialog()
    {
        Dialogs.MenuHeading("New User");

        var user = new User
        {
            FirstName = Dialogs.Prompt("Enter First Name: "),
            LastName = Dialogs.Prompt("Enter Last Name: "),
            Email = Dialogs.Prompt("Enter Email: ")
        };
        
        var result = _userService.SaveUser(user);
        
        if (result.Success)
            WriteLine($"User was successfully added.");
        else
            WriteLine($"{result.Message}");
        
        ReadKey();
    }

    private void ViewUsersDialog()
    {
        Dialogs.MenuHeading("Users");
        
        var items = _userService.GetAllUsers().Result!;
        
        if (items.Any())
            foreach (var user in items)
                WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
        
        ReadKey();
    }
}