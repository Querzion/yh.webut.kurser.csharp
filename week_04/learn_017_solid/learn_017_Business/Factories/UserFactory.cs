using System.Diagnostics;
using learn_017_Business.Models;

namespace learn_017_Business.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static UserEntity? Create(UserRegistrationForm form)
    {
        try
        {
            return new UserEntity
            {
                FirstName = form.FirstName,
                LastName = form.LastName,
                Email = form.Email,
                PhoneNumber = form.PhoneNumber
            };
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating UserEntity: {ex.Message}");
            return null;
        }
    }

    public static User? Create(UserEntity entity)
    {
        try
        {
            return new User
            {
                Id = entity.Id,
                Name = $"{entity.FirstName} {entity.LastName}",
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber
            };
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating User: {ex.Message}");
            return null;
        }
    }
}