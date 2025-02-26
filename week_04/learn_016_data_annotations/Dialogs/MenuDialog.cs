using System.ComponentModel.DataAnnotations;
using learn_016_Business.Dtos;
using static System.Console;
namespace learn_016_data_annotations.Dialogs;

public class MenuDialog
{
    public void ShowMenu()
    {
        while (true)
        {
            MenuDialogOptions();
        }
    }

    private void MenuDialogOptions()
    {
        Dialogs.MenuHeading("Menu Options");
        WriteLine("1. Register User");
        var switchOption = Dialogs.Prompt("Choose option: ");

        switch (switchOption)
        {
            case "1":
                Dialogs.MenuHeading("Register User");
                UserRegistrationDialog();
                break;
            default:
                WriteLine("Invalid option");
                break;
        }
    }

    private void UserRegistrationDialog()
    {
        var urf = new UserRegistrationForm();
        
        urf.FirstName = PromptAndValidate("Enter your first name: ", nameof(urf.FirstName), urf);
        urf.LastName = PromptAndValidate("Enter your last name: ", nameof(urf.LastName), urf);
        urf.Email = PromptAndValidate("Enter your email: ", nameof(urf.Email), urf);
        urf.Password = PromptAndValidate("Enter your password: ", nameof(urf.Password), urf);
        urf.ConfirmPassword = PromptAndValidate("Confirm password: ", nameof(urf.ConfirmPassword), urf);
        
        WriteLine("User registration successful!");
        ReadKey();
    }

    private string PromptAndValidate(string prompt, string propertyName, UserRegistrationForm urf)
    {
        while (true)
        {
            WriteLine();
            WriteLine(prompt);
            var input = ReadLine() ?? string.Empty;
            
            var results = new List<ValidationResult>();
            var context = new ValidationContext(urf) { MemberName = propertyName };
            
            if (Validator.TryValidateProperty(input, context, results))
                return input;
            
            WriteLine($"{results[0].ErrorMessage}. Please try again.");
        }
    }
}