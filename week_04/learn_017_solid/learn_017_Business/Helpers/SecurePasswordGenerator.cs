using System.Security.Cryptography;
using System.Text;

namespace learn_017_Business.Helpers;

public static class SecurePasswordGenerator
{
    public static (string, string) GenerateSecurePassword(string password)
    {
        using var hmac = new HMACSHA256();
        var securedKey = Convert.ToBase64String(hmac.Key);
        var securedPassword = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
        
        return (securedKey, securedPassword);
    }
}