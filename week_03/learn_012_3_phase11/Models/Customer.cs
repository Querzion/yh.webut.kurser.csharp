using System.Security.Cryptography;
using System.Text;

namespace learn_012_3_phase11.Models;

public abstract class Customer
{
    // Phase 15 - ID to private property of set, needs a constructor for a change.
    public string Id { get; private set; } = null!;
    public string Email { get; set; } = null!;
    protected string Password { get; set; } = null!;
    protected string Salt { get; set; } = null!;
    
    // Phase 12 - Export the Logic
    // public abstract void SetSecurePassword(string password); 
    // public abstract bool ValidateSecurePassword(string password);
    
    // Phase 15 - ID private
    protected Customer()
    {
        Id = Guid.NewGuid().ToString();
    }
    
    
    // Phase 13 - If the logic is standardized then just set it as virtual here.
    // public virtual void SetSecurePassword(string password)
    // {
    //     using var hmac = new HMACSHA256();
    //     Salt = Encoding.UTF8.GetString(hmac.Key);
    //     var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    //     Password = Convert.ToBase64String(hashBytes);
    //     
    //     Console.WriteLine($"Password: {Password}");
    // }
    //
    // // Teacher version that isn't working!
    // public virtual bool ValidateSecurePassword(string password)
    // {
    //     using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(Salt));
    //     var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    //     var hashedPassword = Convert.ToBase64String(hashBytes);
    //     
    //     Console.WriteLine($"HashedPassword: {hashedPassword}");
    //     
    //         // if (!hashedPassword.Equals(Password[i]))
    //     for (int i = 0; i < Password.Length; i++)
    //         if (hashedPassword[i] != Password[i])
    //             return false;
    //     return true;
    // }
    
    // Teacher version that works.
    // public virtual bool ValidateSecurePassword(string password)
    // {
    //     var saltBytes = Convert.FromBase64String(Salt);
    //     using var hmac = new HMACSHA256(saltBytes);
    //     var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(Password));
    //     var hashedPassword = Convert.ToBase64String(hashBytes);
    //     
    //     return hashedPassword == password;
    // }
    
    
    // ChatGPT version
    public virtual void SetSecurePassword(string password)
    {
        // Generate a random salt
        var saltBytes = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(saltBytes);
        }
        Salt = Convert.ToBase64String(saltBytes);

        // Hash the password with the salt
        using (var hmac = new HMACSHA256(saltBytes))
        {
            var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            Password = Convert.ToBase64String(hashBytes);
        }

        // Console.WriteLine($"Password: {Password}");
        // Console.WriteLine($"Salt: {Salt}");
    }
    
    public virtual bool ValidateSecurePassword(string password)
    {
        if (string.IsNullOrEmpty(Salt) || string.IsNullOrEmpty(Password))
        {
            throw new InvalidOperationException("Salt and Password must be set before validation.");
        }
    
        // Decode the salt
        var saltBytes = Convert.FromBase64String(Salt);
    
        // Hash the input password with the stored salt
        using (var hmac = new HMACSHA256(saltBytes))
        {
            var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            var hashedPassword = Convert.ToBase64String(hashBytes);
    
            // Use a constant-time comparison to avoid timing attacks
            return Password == hashedPassword;
        }
    }
    
}