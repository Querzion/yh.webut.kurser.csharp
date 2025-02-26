// TIMESAVING FEATURE!
using static System.Console;
using ex02_todo.Models;

namespace ex02_todo.Services;

public class MenuService
{
    private readonly TodoService _todoService = new ();

    public void ShowMainMenu()
    {
        bool isRunning = true;
        
        do
        {
            Clear();
            WriteLine("*************** MENU ***************");
            WriteLine("1. Add new item");
            WriteLine("2. View all items");
            WriteLine("Q. Quit Application");
            WriteLine("************************************");
            Write("Please select an option: ");
            string option = ReadLine()!;

            switch (option.ToLower())
            {
                case "1":
                    ShowAddTodo();
                    break;
                case "2":
                    ShowAllTodos();
                    break;
                case "q":
                    Clear();
                    WriteLine("Press any key to exit application...");
                    ReadKey();
                    isRunning = false;
                    
                    // Environment.Exit(0);
                    break;
                default:
                    InvalidOption("Invalid option, please try again!");
                    break;
            }
            
            

        } while (isRunning);
    }

    public void ShowAddTodo()
    {
        var todoModel = new TodoModel();
        
        Clear();
        WriteLine("*************** NEW TODO ***************");
        Write("Enter new todo: ");

        todoModel.Description = ReadLine()!;
        
        _todoService.AddTodoItem(todoModel);
        
    }

    public void ShowAllTodos()
    {
        var todos = _todoService.GetAllTodoItems();
        
        Clear();
        WriteLine("*************** ALL TODOS ***************");


        foreach (var todosItem in todos)
        {
            var status = todosItem.isCompleted ? "Completed" : "Un-Completed";
            WriteLine($"#{todosItem.Id} :: {todosItem.Description} ({status})");
        }
        
        WriteLine();
        WriteLine("Enter 'Id' to mark a todo as completed, else press 'Enter' to go back");
        var option = ReadLine();

        if (int.TryParse(option, out int id))
        {
            _todoService.UpdateTodoItem(id);
            ShowAllTodos();
        }
        
    }

    public void InvalidOption(string? message)
    {
        WriteLine(message);
        ReadKey();
    }
    
}