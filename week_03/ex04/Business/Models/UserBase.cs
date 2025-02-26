namespace Business.Models;

public abstract class UserBase
{
    public int Id { get; set; }
    public string Name { get; set; }

    public abstract string GetRole();
}