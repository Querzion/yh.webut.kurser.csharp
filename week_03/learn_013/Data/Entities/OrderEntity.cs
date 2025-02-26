namespace Data.Entities;

public class OrderEntity
{
    protected string Id { get; set; } = null!;
    
    
    public string CustomerId { get; set; } = null!;
    
    public string CustomerName { get; set; } = null!;

    public DateTime OrderDate { get; set; } = DateTime.Now;
    public DateTime DueDate { get; set; }
}