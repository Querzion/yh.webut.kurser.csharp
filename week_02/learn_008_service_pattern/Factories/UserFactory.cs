using learn_008_service_pattern.Helpers;
using learn_008_service_pattern.Models;

namespace learn_008_service_pattern.Factories;

public class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static UserEntity Create(UserRegistrationForm form)
    {
        return new UserEntity()
        {
            // The unique id can be created here, or in 
            //Id = UniqueIdentifierGenerator.GenerateUniqueId(),
            FirstName = form.FirstName,
            LastName = form.LastName,
            Email = form.Email,
            // Instead of creating this in UserService.
            //Password = SecurePasswordGenerator.Generate(form.Password),
        };
    }

    public static User Create(UserEntity entity)
    {
        return new User()
        { 
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
        };
    }
}
