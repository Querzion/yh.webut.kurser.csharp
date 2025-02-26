using System.ComponentModel.DataAnnotations;

namespace learn_007_factory_pattern;

// Would be a Dto, but since it has validation, it's more or less a Model.
public class UserRegistrationForm
{
    [Required] 
    public string FirstName { get; set; } = null!;

    [Required] 
    public string LastName { get; set; } = null!;
    
    [Required]
    [EmailAddress]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
    public string Email { get; set; } = null!;

    [Required]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
    // Password RegularExpression de-limited by ChatGPT
    [RegularExpression(@"(?=.*[a-ö])(?=.*[A-Ö])(?=.*\d)(?=.*[!@#$%^&*()\-_+=\[{\]};:'""|\\<,>.?/`~€£¥₹]).*[A-Öa-ö\d!@#$%^&*()\-_+=\[{\]};:'""|\\<,>.?/`~€£¥₹]{8,}$",
    ErrorMessage = "Password must be at least 8 characters long, contain at least one lowercase letter, one uppercase letter, one number, and one special character.")]
    public string Password { get; set; } = null!;


    [Required]
    [Compare(nameof(Password), ErrorMessage = "Passwords don't match")]
    public string ConfirmPassword { get; set; } = null!;

    public string FullName => $"{FirstName} {LastName}";
}