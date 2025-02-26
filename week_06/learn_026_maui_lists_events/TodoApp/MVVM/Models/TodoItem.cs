namespace TodoApp.MVVM.Models;

public class TodoItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}
