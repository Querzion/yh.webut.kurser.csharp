namespace learn_008_service_pattern.Models;

public class UserEntity
{
    public string Id { get; set; } = null!;

    // Instead of using null or the UserService or UserFactor for Id, you can create the Unique Id from here. Like this. 
    //public string Id { get; set; } = UniqueIdentifierGenerator.GenerateUniqueId();

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}

public class User
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

}

