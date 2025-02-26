using System.ComponentModel.DataAnnotations;

namespace learn_006_dto_model_entity_poco.Models;

// A model usually has validation logic syntax.
public class ProductModel
{
    public string? ArticleNumber { get; set; }

    [Required(ErrorMessage = "A Title is required")]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    [Required(ErrorMessage = "A price is required")]
    public decimal Price { get; set; }


    public void Validate()
    {
        if (Price <= 0)
            throw new ArgumentException("Price must be greater than 0.");
    }
}
