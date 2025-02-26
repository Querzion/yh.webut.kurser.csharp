using static System.Console;
namespace ex04.Dialogs;

public class MenuDialog
{
    private bool isRunning = true;
    
    public void ShowMenu()
    {
        do
        {
            ShowMenuOptions();
            
        } while(isRunning = true);
    }

    private void ShowMenuOptions()
    {
        Clear();
        WriteLine("Welcome to the Menu Dialog!");
        WriteLine("1. Add User");
        WriteLine("2. View User by Id");
        WriteLine("3. View All Users");
        WriteLine("Q. Exit");
        WriteLine("");
        WriteLine("Select an option:");
        var option = ReadLine()!;

        switch (option.ToUpper())
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "Q":
                QuitApplicationOption();
                // isRunning = false;
                break;
            default:
                Clear();
                WriteLine("Invalid option. Please try again.");
                break;
        }
    }

    private void QuitApplicationOption()
    {
        Clear();
        WriteLine("Exiting. Press any key to continue...");
        ReadKey();
        Environment.Exit(0);
    }
}