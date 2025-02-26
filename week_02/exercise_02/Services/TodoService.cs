using exercise_02.Models;

namespace exercise_02.Services;

public class TodoService
{
    // underscore _______ signifies that the list of todo is a PRIVATE variable.
    private List<Todo> _todoService;

    public TodoService()
    {
        _todoService = [];
    }

    public void AddTodo(Todo todo)
    {
        _todoService.Add(todo);
    }

    public void RemoveTodo(Todo todo)
    {
        _todoService.Remove(todo);
    }

    public List<Todo> GetTodoList()
    {
        return _todoService;
    }

    //public IEnumerable<Todo> GotOne(int id)
    //{
    //    return _todoService.FirstOrDefault(x => x.Id == id);
    //}

    public void Clear()
    {
        _todoService.Clear();
    }
}
