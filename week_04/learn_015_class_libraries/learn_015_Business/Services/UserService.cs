using learn_015_Business.Models;
using learn_015_Data.Data;

namespace learn_015_Business.Services;

public class UserService(DataContext<User> context)
{
    private readonly DataContext<User> _context = context;

    public ResponseResult<User> SaveUser(User user)
    {
        try
        {
            // If the item doesn't exist "_context.Add(user);"
            if (_context.Items().All(x => x.Email != user.Email))
            {
                // Count user id as long as the count is not 0 take the last id and add +1 otherwise set it as 1.
                // user.Id = _context.Items().Count() != 0 ? _context.Items().Last().Id + 1 : 1;
                // If the source is null/empty give it id 1, otherwise take the last id and add +1
                user.Id = _context.Items().Any() ? _context.Items().Last().Id + 1 : 1;
                _context.Save(user);
                return new ResponseResult<User>
                {
                    Success = true,
                    Message = "User saved successfully."
                };
            }
            else
            {
                return new ResponseResult<User>
                {
                    Success = false,
                    Message = "A user with the same email already exists!"
                };
            }
        }
        catch (Exception ex)
        {
            return new ResponseResult<User>
            {
                Success = false,
                Message = $"Something went wrong: {ex.Message}"
            };
        }
    }

    // public IEnumerable<User> GetAllUsers()
    // {
    //     return _context.Items();
    // }

    public ResponseResult<IEnumerable<User>> GetAllUsers()
    {
        try
        {
            return new ResponseResult<IEnumerable<User>>
            {
                Success = true,
                // Result = _context.Items().ToList(),
                Result = _context.Items()
            };

        }
        catch (Exception e)
        {
            return new ResponseResult<IEnumerable<User>>
            {
                Success = false,
                Message = $"Something went wrong: {e.Message}"
            };
        }
    }
}