using System.Diagnostics;
using Business.Factories;
using Business.Helpers;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

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
        try
        {
            _users = _userRepository.GetFromFile() ?? [];
    
            return _users.Select(user => UserFactory.Create(user))!;
            // return _users.Select(UserFactory.Create)!;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return new List<User>();
        }
    }
    
    // Get a user by ID
    // public User? GetUserById(string id)
    // {
    //     var user = _users.FirstOrDefault(u => u.Id == id);
    //     return user != null ? UserFactory.Create(user) : null; // Convert to User model
    // }

    // Get a user by email
    // public User? GetUserByEmail(string email)
    // {
    //     var user = _users.FirstOrDefault(u => u.Email == email);
    //     return user != null ? UserFactory.Create(user) : null; // Convert to User model
    // }
    
    // Delete a user by their ID
    public bool DeleteUser(string id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            _users.Remove(user); // Remove the user from the list
            _userRepository.SaveToFile(_users); // Save the updated list
            return true;
        }
        return false; // Return false if the user does not exist
    }

    // Update a user's information
    public bool UpdateUser(User user)
    {
        var userEntity = _users.FirstOrDefault(u => u.Id == user.Id);
        if (userEntity != null)
        {
            userEntity.FirstName = user.FirstName; // Update the user's name
            userEntity.LastName = user.LastName; // Update the user's name
            userEntity.Email = user.Email; // Update the user's email
            // Update other fields as necessary
            _userRepository.SaveToFile(_users); // Save the updated list
            return true;
        }
        return false; // Return false if the user does not exist
    }
}