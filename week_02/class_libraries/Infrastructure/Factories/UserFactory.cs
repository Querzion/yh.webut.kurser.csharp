using Infrastructure.Dtos;
using Infrastructure.Helpers;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create()
    {
        return new UserRegistrationForm();
    }

    public static User Create(UserRegistrationForm form)
    {
        return new User
        {
            Id = UniqueIdentifierGenerator.Generate(),
            FirstName = form.FirstName,
            LastName = form.LastName,
            Email = form.Email,
        };
    }
}
