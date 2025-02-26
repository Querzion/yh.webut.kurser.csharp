using System.ComponentModel.DataAnnotations;

namespace learn_016_Business.Dtos;

public class UserRegistrationForm
{
    [Required (ErrorMessage = "First name is required")]
    [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
    public string FirstName { get; set; } = null!;
    
    [Required (ErrorMessage = "Last name is required")]
    [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
    public string LastName { get; set; } = null!;
    
    [Required (ErrorMessage = "Email is required")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email must be in a valid format like user@mail.com")]
    public string Email { get; set; } = null!;
    
    [Required (ErrorMessage = "Password is required")]
    [RegularExpression(@"^(?=.*[a-ö])(?=.*[A-Ö])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "Password must be at least 8 characters, have one capital letter, one number and one special character & one number")]
    public string Password { get; set; } = null!;
    
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;
}