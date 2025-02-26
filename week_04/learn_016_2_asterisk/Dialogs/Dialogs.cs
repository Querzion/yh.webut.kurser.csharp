using static System.Console;
namespace learn_016_2_asterisk.Dialogs;

public class Dialogs
{
    public static void MenuHeading(string heading)
    {
        Clear();
        WriteLine($"***************** {heading.ToUpper()} *****************\n");
    }

    public static string Prompt(string message)
    {
        Write(message);
        return ReadLine()!;
    }
}