using System.Security.Cryptography;
using System.Text;

namespace learn_012_inheritance_abstract.Models;

public class Private : Customer
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    
    // Phase 3 - Creating a Constructor
    // public Private()
    // {
    //     
    // }
    
    // Phase 4 - Link Customer variables with base, and they can be eradicated from the Private constructor
    // id & email are now validated through the Customer class.
    // Phase 5 (real life example "database integration project")
    public Private(string id, String email, string firstName, string lastName) : base(id, email)
    {
        // Id = id;
        // Email = email;
        FirstName = firstName;
        LastName = lastName;
    }

    // Phase 6 - Protected variables!
    // If there are variables that end up being protected, there's basically only a few ways to interact with them.
    // By creating methods that get or set the properties of those variables.
    public string GetId()
    {
        return Id;
    }

    public void SetId(string id)
    {
        // by doing this you can add indications like P for private Customer.
        Id = "P-" + id;
    }
    
    // Phase 9 - Protected variables!
    public void SetSecurePassword(string password)
    {
        // create a variable that uses a set encryption method
        using var hmac = new HMACSHA256();
        // convert and save the entered password into an encrypted phrase
        EncryptedPassword = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
    }

    public bool ValidatePassword(string password)
    {
        var storedPassword = EncryptedPassword;

        if (storedPassword == password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Phase 10 - Adding the Abstract methods from Customer!
    public override void SetSecuredPassword(string password)
    {
        var salt = "SaltySecrets";
        using var sha256 = SHA256.Create();
        var saltedPassword = $"{password}{salt}";
        var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
        EncryptedPassword = Convert.ToBase64String(hashBytes);
    }

    public override void ValidateSecurePassword(string password)
    {
        throw new NotImplementedException();
    }
}