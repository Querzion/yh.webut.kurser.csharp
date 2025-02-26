using ExternalBase.Factories;
using ExternalBase.Models;
using ExternalBase.Services;
using static System.Net.Mime.MediaTypeNames;

namespace exercise_03.Services;

public class MenuService
{
    private readonly UserService _userService = new UserService();
    public void Show()
    {
        while (true)
        {
            MainMenu();
        }
    }

    // With the first menu option, this needs to be a string and return option instead of the switch statement.
    private void MainMenu()
    {
        // The number that is visible in this output ($"{"This",-8} That") is the amount of spaces there is between "This" and "That". 

        Console.Clear();
        Console.WriteLine("************************************");
        Console.WriteLine($"{"1.",-8} Lägg till en användare");
        Console.WriteLine($"{"2.",-8} Visa alla användare");
        Console.WriteLine($"{"A.",-8} Avsluta applikation");
        Console.WriteLine("************************************");
        Console.Write("Välj alternativ: ");
        var option = Console.ReadLine()!;

        switch (option.ToLower())
        {
            case "A":
                QuitOption();
                break;

            case "1":
                CreateOption();
                break;

            case "2":
                ViewOption();
                break;

            default:
                InvalidOption();
                break;

        }

        Console.ReadKey();
    }


    public void QuitOption()
    {
        Console.Clear();

        Console.Write("Vill du verkligen avsluta applikationen? (j/n): ");
        var option = Console.ReadLine()!;

        if (option.Equals("j", StringComparison.CurrentCultureIgnoreCase))
        {
            Environment.Exit(0);
        }
    }

    public void CreateOption()
    {
        UserRegistrationForm userRegistrationForm = UserFactory.Create();

        Console.Clear();

        Console.Write("Skriv in förnamn: ");
        userRegistrationForm.FirstName = Console.ReadLine()!;

        Console.Write("Skriv in efternamn: ");
        userRegistrationForm.LastName = Console.ReadLine()!;

        Console.Write("Skriv in e-postadress: ");
        userRegistrationForm.Email = Console.ReadLine()!;

        Console.Write("Skriv in lösenord: ");
        userRegistrationForm.Password = Console.ReadLine()!;

        bool result = _userService.Create(userRegistrationForm);

        if (result)
            OutputDialogue("Användarkonto skapat.");
        else
            OutputDialogue("Något gick fel.");
    }

    public void ViewOption()
    {
        var users = _userService.GetTodoList();

        Console.Clear();

        Console.WriteLine("Lista över Användare: ");

        int i = 0;
        foreach ( var user in users)
        {
            i++;
            Console.WriteLine($"{i}. Namn: {user.FirstName}, E-Post: {user.Email}, Skapad: {user.DateTime}");
        }

        Console.WriteLine("Tryck valfri knapp för att fortsätta...");
        Console.ReadKey();
    }  

    public void InvalidOption()
    {
        Console.WriteLine("Du måste välja ett giltigt alternativ.");
        Console.ReadKey();
    }

    public void OutputDialogue(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Console.ReadKey();
    }
}
