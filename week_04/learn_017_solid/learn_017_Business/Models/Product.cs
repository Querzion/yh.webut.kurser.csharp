namespace learn_017_Business.Models;

public class Product
{
    public string Id { get; set; } = null!;
    public string? ArticleNumber { get; set; }
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public bool IsService { get; set; }
}