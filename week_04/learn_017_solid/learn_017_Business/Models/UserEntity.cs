namespace learn_017_Business.Models;

// Server / Database Table
public class UserEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string SecuredPassword { get; set; } = null!;
    public string SecuredKey { get; set; } = null!;
    public string? PhoneNumber { get; set; }
}