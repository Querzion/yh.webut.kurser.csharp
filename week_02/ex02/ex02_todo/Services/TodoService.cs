using ex02_todo.Models;

namespace ex02_todo.Services;

public class TodoService
{
    private readonly List<TodoModel> _todos = [];
    
    // Lägga till 
    public void AddTodoItem(TodoModel todo)
    {
        // Förenklad if sats - Om listan är tom så blir första objektet 1, annars blir senaste objektet +1 i ID. 
        todo.Id = _todos.Count > 0 ? _todos[^1].Id + 1 : 1;
        // Addera ny todo till listan.
        _todos.Add(todo);
    }
    
    // Visa todo
    // Skapar en readonly utskrivning utav typen TodoModel i listan _todos.
    public IEnumerable<TodoModel> GetAllTodoItems()
    {
        return _todos;
    }
    
    // Uppdatera todo
    public bool UpdateTodoItem(int id)
    {
        var todoToUpdate = _todos.FirstOrDefault(todo => todo.Id == id);
        if (todoToUpdate != null)
        {
            todoToUpdate.isCompleted = true;
            return true;
        }
        return false;
        
    }
    
}