using System.ComponentModel.DataAnnotations;
using Business.Factories;
using Business.Interfaces;
using Business.Models;
using MA_Presentation_Console.Interfaces;
using static System.Console;

namespace MA_Presentation_Console.Dialogs;

public class MenuDialog(IUserService userService) : IMenuDialog
{
    private readonly IUserService _userService = userService;
    private bool isRunning = true;
    

    public void ShowMainMenu()
    {
        do 
        {
            MainDialogOptions();
        } while (isRunning);
    }

    public void MainDialogOptions()
    {
        Dialogs.MenuHeading("Main Menu");
        WriteLine("1. Create User");
        WriteLine("2. View Users");
        WriteLine("Q. Exit Application");
        WriteLine("_____________________________________________");
        var option = ReadLine()!;

        switch (option.ToLower())
        {
            case "1":
                Dialogs.MenuHeading("Create User");
                UserRegistrationDialog();
                // ReadKey();
                break;
            case "2":
                Dialogs.MenuHeading("View Users");
                ViewContactsOption();
                ReadKey();
                break;
            case "q":
                Dialogs.MenuHeading("Exit Application");
                WriteLine("Program exit... Press any key to exit...");
                ReadKey();
                isRunning = false;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }

    public void ViewContactsOption()
    {
        try
        {
            // Get the contacts from the file
            var users = _userService.GetUsers();
        
            // Check if the list is null or empty
            if (users == null || users.Count() == 0)
            {
                WriteLine("No contacts found.");
                return;
            }

            // Display the contacts
            WriteLine("Users List:");
            foreach (var user in users)
            {
                // Display the contact details (adjust the fields as needed)
                WriteLine($"ID: {user.Id}");
                WriteLine($"Name: {user.DisplayName}");
                WriteLine($"Email: {user.Email}");
                WriteLine(new string('-', 50)); // Divider for readability
            }
        }
        catch (Exception ex)
        {
            // Log the error and show a friendly message
            WriteLine("An error occurred while loading the contacts.");
            WriteLine($"Error: {ex.Message}");
        }
    }
    
    private void UserRegistrationDialog()
    {
        // var urf = new UserRegistrationForm();
        var urf = UserFactory.Create();
        
        urf.FirstName = PromptAndValidate("Enter your first name: ", nameof(urf.FirstName), urf);
        urf.LastName = PromptAndValidate("Enter your last name: ", nameof(urf.LastName), urf);
        urf.Email = PromptAndValidate("Enter your email: ", nameof(urf.Email), urf);
        
        // Prompt for password and confirm password
        urf.Password = PromptAndValidate("Enter your password: ", nameof(urf.Password), urf);
        urf.ConfirmPassword = PromptAndValidate("Confirm your password: ", nameof(urf.ConfirmPassword), urf);
        
        // Manually compare password and confirm password to handle the Compare validation
        if (!string.Equals(urf.Password.Trim(), urf.ConfirmPassword.Trim(), StringComparison.Ordinal))
        {
            WriteLine("Passwords do not match. Please try again.");
            return; // Exit the registration process if passwords do not match
        }

        // Validate the entire form after data entry
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(urf);
        if (!Validator.TryValidateObject(urf, validationContext, validationResults, true))
        {
            // If validation fails, display the error message and prompt the user again
            foreach (var validationResult in validationResults)
            {
                WriteLine(validationResult.ErrorMessage);
            }
            return; // Exit the registration process if validation fails
        }

        // Pass the validated form to the service
        var result = _userService.CreateUser(urf);
        
        Clear();

        if (result)
        {
            WriteLine();
            WriteLine("\nUser registration successful!");
            WriteLine("New Contact successfully created.");
        }
        else
        {
            WriteLine();
            WriteLine("\nNew Contact failed to be created. Please try again.");
        }
        
        ReadKey();
    }

    private string PromptAndValidate(string prompt, string propertyName, UserRegistrationForm urf)
    {
        while (true)
        {
            WriteLine();
            WriteLine(prompt);
            
            // Check if the property being validated is Password or ConfirmPassword
            string input = propertyName == nameof(UserRegistrationForm.Password) || propertyName == nameof(UserRegistrationForm.ConfirmPassword)
                ? ReadPassword() // If it's a password field, read input with hidden characters
                : ReadLine() ?? string.Empty; // Otherwise, use ReadLine for normal input

            var results = new List<ValidationResult>();
            var context = new ValidationContext(urf) { MemberName = propertyName };
            
            if (Validator.TryValidateProperty(input, context, results))
                return input;
            
            WriteLine($"{results[0].ErrorMessage}. Please try again.");
        }
    }

    private string ReadPassword()
    {
        string password = string.Empty;
        ConsoleKey key;

        do
        {
            var keyInfo = ReadKey(intercept: true); // Do not display the key
            key = keyInfo.Key;

            if (key == ConsoleKey.Backspace && password.Length > 0)
            {
                // Remove the last character from the password
                password = password.Remove(password.Length - 1);
                Write("\b \b"); // Move the cursor back, overwrite with a space, and move back again
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                password += keyInfo.KeyChar; // Add the character to the password
                Write("*"); // Display an asterisk instead
            }
        } while (key != ConsoleKey.Enter); // Stop when the Enter key is pressed

        WriteLine(); // Move to the next line after Enter
        return password;
    }
}