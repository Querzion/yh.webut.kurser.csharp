namespace learn_012_inheritance_abstract.Models;

// Keyword "abstract" makes it possible to share data with other classes, variables, methods and functions,
// but you cannot initialize it anywhere outside its designation.
public abstract class Customer
{
    // public string Id { get; set; } = null!;
    public string Email { get; set; } = null!;
 
    // Phase 6 - protected variables
    
    // set to protected if it's used for static variable data,
    // or public if it should be editable for later. 
    // protected string Id { get; set; } = null!;
    // protected string Email { get; set; } = null!;
    
    // Phase 7 - protected properties
    public string Id { get; protected set; } = null!;
    
    // Phase 8  - private properties which can only be set in the constructor.
    // public string Id { get; private set; } = null!;
    
    // Phase 9 - protected variables.
    protected string EncryptedPassword { get; set; } = null!;
    
    // Phase 4 & 5 - Separation of responsibility
    protected Customer(string id, string email)
    {
        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentNullException("Id cannot be null or empty", nameof(id));
        
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException("Email cannot be null or empty", nameof(email));
        
        Id = id;
        Email = email;
    }
    
    // Phase 10 - It is common practice to create variables where the logic is later on in separate files.
    // Methods can only be set as abstract in an abstract class.
    public abstract void SetSecuredPassword(string password);
    public abstract void ValidateSecurePassword(string password);
}