namespace ex02_todo.Models;

public class TodoModel
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public bool isCompleted { get; set; }
}