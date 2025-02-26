using static System.Console;
namespace learn_017_solid.Dialogs;

public class MenuDialog
{
    private bool isRunning = true;
    
    public void ShowMainMenu()
    {
        
        while (isRunning)
        {
            MenuDialogOptions();
        }
    }

    private void MenuDialogOptions()
    {
        Dialogs.MenuHeading("Menu Options");
        WriteLine("1. Register User");
        WriteLine("2. View Users");
        WriteLine("3. Register Product");
        WriteLine("4. View Products");
        WriteLine("5. Exit");
        WriteLine("________________________________________________");
        var switchOption = Dialogs.Prompt("Choose option: ");

        switch (switchOption)
        {
            case "1":
                Dialogs.MenuHeading("Register User");
                ReadKey();
                break;
            case "2":
                Dialogs.MenuHeading("View Users");
                ReadKey();
                break;
            case "3":
                Dialogs.MenuHeading("Register Product");
                ReadKey();
                break;
            case "4":
                Dialogs.MenuHeading("View Products");
                ReadKey();
                break;
            case "5":
                Dialogs.MenuHeading("Exit");
                WriteLine("Bye bye! Press any key to exit.");
                ReadKey();
                isRunning = false;
                break;
            default:
                WriteLine("Invalid option, please try again.");
                break;
        }
    }
}