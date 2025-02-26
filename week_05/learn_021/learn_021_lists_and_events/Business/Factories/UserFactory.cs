using System.Diagnostics;
using Business.Helpers;
using Business.Models;

namespace Business.Factories;

public class UserFactory
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
                Id = IdGenerator.GenerateUniqueId(),
                FirstName = form.FirstName,
                LastName = form.LastName,
                Email = form.Email,
                
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
                DisplayName = $"{entity.FirstName} {entity.LastName}",
                Email = entity.Email,
            };
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating User: {ex.Message}");
            return null;
        }
    }
}