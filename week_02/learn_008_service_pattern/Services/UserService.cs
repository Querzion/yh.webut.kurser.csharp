using learn_008_service_pattern.Factories;
using learn_008_service_pattern.Helpers;
using learn_008_service_pattern.Models;
using System.Diagnostics;

namespace learn_008_service_pattern.Services; 

public class UserService
{

    /*
        C = Create
        R = Read/Get/View
        U = Update
        D = Delete

     */

    private readonly List<UserEntity> _users = [];

    // This is what the = []; means ^. It's a constructor that allocates an array to _users.
    //public UserService()
    //{
    //    _users = [];
    //}

    public bool Create(UserRegistrationForm form)
    {
        try
        {
            UserEntity userEntity = UserFactory.Create(form);

            // Instead of using the UserFactory creation. This is the better location especially for debugging.
            userEntity.Id = UniqueIdentifierGenerator.GenerateUniqueId();
            userEntity.Password = SecurePasswordGenerator.Generate(form.Password);

            _users.Add(userEntity);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public IEnumerable<User> GetAll()
    {
        //var list = new List<User>();

        //foreach (var userEntity in _users) 
        //    list.Add(UserFactory.Create(userEntity));

        //return list;

        // Shorter version of basically the same thing
        return _users.Select(UserFactory.Create);
    }

    //public void ClearList()
    //{
    //    _users.Clear();
    //}
}
