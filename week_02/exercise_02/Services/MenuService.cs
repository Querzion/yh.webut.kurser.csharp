using exercise_02.Models;
using exercise_02.Services;
using static System.Net.Mime.MediaTypeNames;

namespace learn_008_service_pattern.Services;

public class MenuService
{
    private readonly TodoService _todoService = new TodoService();
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
        Console.WriteLine("*******************************");
        Console.WriteLine($"{"1.",-8} CREATE TO:DO");
        Console.WriteLine($"{"2.",-8} VIEW TO:DO LIST");
        Console.WriteLine($"{"Q.",-8} QUIT APPLICATION");
        Console.WriteLine("*******************************");
        Console.Write("Choose your menu option: ");
        var option = Console.ReadLine()!;

        switch (option.ToLower())
        {
            case "q":
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

        Console.Write("Do you want to exit this application (y/n): ");
        var option = Console.ReadLine()!;

        if (option.Equals("y", StringComparison.CurrentCultureIgnoreCase))
        {
            Environment.Exit(0);
        }
    }

    public void CreateOption()
    {
        Console.Clear();
        Console.Write("Add Todo: ");
        var text = Console.ReadLine()!;
        var todo = new Todo(text); 
        _todoService.AddTodo(todo);
        Console.WriteLine($"Added: {todo.Description}");
    }

    public void ViewOption()
    {
        var todos = _todoService.GetTodoList();

        Console.Clear();
        int i = 0;
        foreach ( var todo in todos)
        {
            Console.Clear();
            Console.Write($"Is the todo '{todo.Description}' done? (y/n): ");
            var status = Console.ReadLine()!;

            switch (status.ToLower())
            {
                case "y":
                    todo.IsCompleted = true;
                    break;
                case "n":
                    todo.IsCompleted = false;
                    break;
                default:
                    Console.WriteLine("Todo set to 'no'");
                    todo.IsCompleted = false;
                    break;
            }
        }

        Console.Clear();
        
        Console.WriteLine("-------------------------------------");

        foreach (var todo in todos)
        {
            i++;
            todo.Id = i;
            if (todo.IsCompleted == false)
            {
                var todoStatus = "in progress";
                Console.WriteLine($"{$"{todo.Id}:",-5}{todo.Description} {$"({todoStatus})"}");
            }
            else
            {
                var todoStatus = "Completed";
                Console.WriteLine($"{$"{todo.Id}:",-5}{todo.Description} {$"({todoStatus})"}");
            }

            Console.WriteLine("");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }  

    public void InvalidOption()
    {
        Console.WriteLine("You must enter a valid option.");
        Console.ReadKey();
    }
}
