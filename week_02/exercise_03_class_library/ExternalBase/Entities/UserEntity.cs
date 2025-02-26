using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExternalBase.Entities;

public class UserEntity
{
    [Key]
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;
    
    public string LastName { get; set; } = null!;
    
    public string Email { get; set; } = null!;
   
    public string Password { get; set; } = null!;
   
    public bool EmailConfirmed { get; set; }

}