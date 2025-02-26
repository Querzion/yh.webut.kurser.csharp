using TodoApp.MVVM.Models;

namespace TodoApp.Services;

public class TodoService
{
    private List<TodoItem> _todoItems = [];

    public event EventHandler? TodoItemsUpdated;

    public void Add(TodoItem item)
    {
        _todoItems.Add(item);
        TodoItemsUpdated?.Invoke(this, EventArgs.Empty);
    }

    public IEnumerable<TodoItem> GetAll()
    {
        return _todoItems;
    }

    public void Update(TodoItem item)
    {
        var todoItem = _todoItems.FirstOrDefault(item => item.Id == item.Id);
        if (todoItem != null)
        {
            todoItem = item;
            TodoItemsUpdated?.Invoke(this, EventArgs.Empty);
        }
    }

    public void Remove(TodoItem item)
    {
        var todoItem = _todoItems.FirstOrDefault(item => item.Id == item.Id);
        if (todoItem != null)
        {
            _todoItems.Remove(todoItem);
            TodoItemsUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
