namespace Business.Models;

public class AdminUser : UserBase
{
    public string Role { get; set; } = "Admin";
    
    
    public override string GetRole()
    {
        return Role;
    }
}