namespace learn_017_Business.Models;

public class ProductEntity
{
    public string Id { get; set; } = null!;
    public string? ArticleNumber { get; set; }
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int StockQuantity { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsService { get; set; }
}