namespace Models;

internal class User
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;


    public string FullName => $"{FirstName} {LastName}";

    /// = null!; or these. . . They basically do the same, but if the later path is taken, 

    //public User()
    //{
    //    FirstName = null!;
    //    LastName = null!;
    //    Email = null!;
    //    Password = null!;
    //}

    /// then the values needs to be added directly to the initilization of the class, 
    /// either as direct answers or as variable shortcuts. In order to overtake that shortcoming. . .
    /// you may start with an empty constructor, then create a constructor that needs value-inputs.
    /// this is a class overload.
    public User()
    {
        
    }
    public User(int id, string firstName, string lastName, string email, string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }
}

/// Hidden class
internal class UserRegistrationForm
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    // With a question marke, you are stating that it Doesn't need an initial value; set.
    public string? Phone { get; set; }

    public UserRegistrationForm()
    {
        FirstName = null!;
        LastName = null!;
        Email = null!;
        Password = null!;
        ConfirmPassword = null!;
        Phone = null!;
    }

    public UserRegistrationForm(string firstName, string lastName, string email, string password, string confirmPassword, string phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        ConfirmPassword = confirmPassword;
        Phone = phone;
    }
}