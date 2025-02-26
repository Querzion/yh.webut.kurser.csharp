namespace Business.Models;

public class RegularUser : UserBase
{
    // public string FirstName { get; set; } = null!;
    // public string Email { get; set; } = null!;
    
    public override string GetRole()
    {
        return "Regular";
    }
}