namespace Business.Models;

public class AdminUser : UserBase
{
    // public string AccountId { get; set; } = null!;
    // public string KeyAccountId { get; set; } = null!;
    
    public override string GetRole()
    {
        return "Admin";
    }
}