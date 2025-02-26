using System.ComponentModel.DataAnnotations;

namespace learn_017_Business.Models;

public abstract class ItemRegistrationForm
{
    [Required] 
    public string Title { get; set; } = null!;
    
    [Required]
    public decimal Price { get; set; }
    public string? Description { get; set; }

    public abstract bool IsService();
}