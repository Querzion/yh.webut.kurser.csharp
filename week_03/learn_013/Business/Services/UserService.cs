using Business.Models;
using Data.Contexts;
using Data.Entities;

namespace Business.Services;



// Phase 3
// Primary constructor on UserService(DataContext context) (ctrl + .)
public interface IUserService
{
    void CreateUser(User user);
    IEnumerable<UserEntity> GetAllUsers();
    UserEntity GetUser(string id);
}

public class UserService(
    DataContext context
    ) : IUserService
{
    private readonly DataContext _context = context;

    // Phase 2
    // Initialized (ctrl + .)

    // // private readonly DataContext _context = new DataContext();
    // private readonly DataContext _context;
    //
    // // Initialized (ctrl + .)
    // public UserService(DataContext context)
    // {
    //     _context = context;
    // }


    // Phase 1
    // Here's a dependency injection, where in 'options' is connected to a list, that has a dependency,
    // so you have to inject it with a data context source, in this case a sql server database entry. . .   
    // public UserService()
    // {
    //     var options = new DbContextOptionsBuilder<DataContext>()
    //         .UseSqlServer("Data Source=(LocalDB)/MSSQLLocalDB;AttachDBFilename=/home/username/Projects/yh.webut.kurser/back.history/3_csharp-courses/week_03/learn_013/Data/Contexts/database.mdf;Integrated Security=True Timeout=30)")
    //         .Options;
    //     
    //     _context = new DataContext(options);
    // }
    
    public void CreateUser(User user)
    {
        var userEntity = new UserEntity
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,

        };
        
        _context.Users.Add(userEntity);
        _context.SaveChanges();
    }

    public IEnumerable<UserEntity> GetAllUsers()
    {
        var users = _context.Users;
        return users;
    }

    public UserEntity GetUser(string id)
    {
        return _context.Users.Find(id);
    }
}