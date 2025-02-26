namespace Business.Models;

public abstract class UserBase
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public abstract string GetRole();
}

public interface IUserBase
{
    string GetRole();
}