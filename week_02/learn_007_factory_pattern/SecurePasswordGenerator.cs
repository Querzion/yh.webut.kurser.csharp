using System.Security.Cryptography;
using System.Text;

namespace learn_007_factory_pattern;

public static class SecurePasswordGenerator
{
    // Encryption snippet from ChatGPT
    /// <summary>
    /// Generates a hashed password using a secure hashing algorithm (e.g., SHA256).
    /// </summary>
    /// <param name="password">The plain-text password to hash.</param>
    /// <returns>A hashed password string.</returns>
    public static string Generate(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password cannot be null or empty.");

        using (var sha256 = SHA256.Create())
        {
            // Convert the password to a byte array
            var passwordBytes = Encoding.UTF8.GetBytes(password);

            // Compute the hash
            var hashBytes = sha256.ComputeHash(passwordBytes);

            // Convert the hash bytes to a Base64 string
            return Convert.ToBase64String(hashBytes);
        }
    }
}
