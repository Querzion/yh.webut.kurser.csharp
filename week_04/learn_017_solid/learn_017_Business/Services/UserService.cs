using System.Diagnostics;
using learn_017_Business.Factories;
using learn_017_Business.Helpers;
using learn_017_Business.Interfaces;
using learn_017_Business.Models;

namespace learn_017_Business.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;
    private List<UserEntity> _users = [];

    public bool CreateUser(UserRegistrationForm form)
    {
        try
        {
            var userEntity = UserFactory.Create(form);

            if (userEntity != null)
            {
                userEntity.Id = IdGenerator.AutoIncrementId(_users.Last().Id);
                (userEntity.SecuredKey, userEntity.SecuredPassword) = SecurePasswordGenerator.GenerateSecurePassword(form.Password);
                
                _users.Add(userEntity);
                _userRepository.SaveToFile(_users);
                
                return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public IEnumerable<User> GetUsers()
    {
        _users = _userRepository.GetFromFile()!;
        
        return _users.Select(user => UserFactory.Create(user))!;
    }
}