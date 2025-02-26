using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace learn_006_dto_model_entity_poco.Models;

// Would be a Dto, but since it has validation, it's more or less a Model.
internal class UserRegistrationForm
{
    [Required] public string FirstName { get; set; } = null!;
    [Required] public string LastName { get; set; } = null!;
    [Required] public string Email { get; set; } = null!;
    [Required] public string Password { get; set; } = null!;
}

// Get
internal class UserEntity
{
    [Key]
    public string Id { get; set; } = null!;

    [Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = null!;
    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = null!;
    [Column(TypeName = "nvarchar(200)")]
    public string Email { get; set; } = null!;
    [Column(TypeName = "nvarchar(50)")]
    public string Password { get; set; } = null!;
}

// Send
internal class User
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
}