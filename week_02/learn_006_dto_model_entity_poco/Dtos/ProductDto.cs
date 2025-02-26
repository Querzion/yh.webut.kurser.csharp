
namespace learn_006_dto_model_entity_poco.Dtos;

internal class Product
{
    public string? ArticleNumber { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
}

public record ProductDto(string? ArticleNumber, string Title, string? Description, decimal Price);