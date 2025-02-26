namespace Business.Models;

public class RegularUser : UserBase
{
    public string Role { get; set; } = "Regular";
    
    
    public override string GetRole()
    {
        return Role;
    }
}