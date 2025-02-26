using System.Security.Cryptography;
using System.Text;

namespace learn_012_inheritance_abstract.Models;

public class Company : Customer
{
    public string CompanyName { get; set; } = null!;
    public string ContactPerson { get; set; } = null!;
    
    
    // Phase 3 - Creating a Constructor
    // public Company()
    // {
    //     
    // }
    
    // Phase 4 - Link Customer variables with base, and they can be eradicated from the Company constructor 
    // id & email are now validated through the Customer class. 
    // Phase 5 (real life example "databaseintegration project")
    public Company(string id, String email, string companyName, string contactPerson) 
        : base(id, email)
    {
        // Id = id;
        // Email = email;
        CompanyName = companyName;
        ContactPerson = contactPerson;
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
        // by doing this you can add indications like C for company Customer.
        Id = "C-" + id;
    }

    public override void SetSecuredPassword(string password)
    {
        var salt = "mustardSalt";
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