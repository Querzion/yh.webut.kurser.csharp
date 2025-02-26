using System.ComponentModel.DataAnnotations;
using ExternalBase.Entities;
using ExternalBase.Helpers;
using ExternalBase.Models;

namespace ExternalBase.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static UserEntity Create(UserRegistrationForm userRegistrationForm)
    {
        return new UserEntity
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = userRegistrationForm.FirstName.Trim(),
            LastName = userRegistrationForm.LastName.Trim(),
            Email = userRegistrationForm.Email.Trim().ToLower(),
            Password = SecurePasswordGenerator.Generate(userRegistrationForm.Password),
            EmailConfirmed = false
        };
    }

    public static User Create(UserEntity userEntity)
    {
        return new User
        {
            Id = userEntity.Id,
            FirstName = userEntity.FirstName,
            LastName = userEntity.LastName,
            Email = userEntity.Email
        };
    }

    /// <summary>
    /// Validates a UserRegistrationForm and throws an exception if validation fails.
    /// </summary>
    /// <param name="form">The form to validate.</param>
    private static void Validate(UserRegistrationForm form)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(form);

        bool isValid = Validator.TryValidateObject(form, validationContext, validationResults, true);

        if (!isValid)
        {
            // Aggregate all validation errors into an exception message
            var errors = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
            throw new ValidationException($"Validation failed: {Environment.NewLine}{errors}");
        }
    }
}
