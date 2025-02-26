using System.Security.Cryptography;
using System.Text;

namespace learn_012_3_phase11.Models;

public class Private : Customer
{
    private const string _saltKey = "ABC7895";
    
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    
    // Phase 11 - Local Salt (This is not the true phase 11, but it's about showing the implementation easier)
    // public override void SetSecurePassword(string password)
    // {
    //     var salt = "MultiToolExcavationSaltExtractor";
    //     using var sha256 = SHA256.Create();
    //     var saltedPassword = $"{password}{salt}";
    //     var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
    //     Password = Convert.ToBase64String(hashBytes);
    // }

    // Phase 12 - Imported Salt
    // public override void SetSecurePassword(string password)
    // {
    //     using var hmac = new HMACSHA256();
    //     Salt = Encoding.UTF8.GetString(hmac.Key);
    //     var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    //     Password = Convert.ToBase64String(hashBytes);
    // }
    //
    // public override bool ValidateSecurePassword(string password)
    // {
    //     using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(Salt));
    //     var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    //     var hashedPassword = Convert.ToBase64String(hashBytes);
    //     
    //     for (int i = 0; i < Password.Length; i++)
    //         // if (!hashedPassword.Equals(Password[i]))
    //         if (hashedPassword[i] != Password[i])
    //             return false; 
    //         
    //     return true;
    // }
    
    // Phase 13 - Move the Password logic to Customer file
    
    // Phase 14 - Override Password Logic
    public override void SetSecurePassword(string password)
    {
        password = $"{_saltKey}{password}";
        // Console.WriteLine(password);
        // Console.WriteLine($"Un-Doctored Password: {password}");
        base.SetSecurePassword(password);
    }
    
    public override bool ValidateSecurePassword(string password)
    {
        password = $"{_saltKey}{password}";
        // Console.WriteLine(password);
        // Console.WriteLine($"Validate Un-doctored Password: {password}");
        // Console.WriteLine($"Validate Un-doctored Password: {Password}");
        return base.ValidateSecurePassword(password);
    }
    
    // This code is a grave security risk.  
    // public string GetSecurePassword(string password)
    // {
    //     base.SetSecurePassword(password);
    //     return Password;
    // }
}