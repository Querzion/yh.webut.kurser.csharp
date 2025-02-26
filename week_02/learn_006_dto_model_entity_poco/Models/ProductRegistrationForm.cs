using System.ComponentModel.DataAnnotations;

namespace learn_006_dto_model_entity_poco.Models;

public class ProductRegistrationForm
{
    [Required(ErrorMessage = "A title is required")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "A price is required")]
    public decimal Price { get; set; }

    public string? ArticleNumber { get; set; }
    public string? Descrpition { get; set; }
}
