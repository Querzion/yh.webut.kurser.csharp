using learn_011_3_interfaces.Interfaces;

namespace learn_011_3_interfaces.Models;

public class PrivateCustomer : IPrivateCustomer
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Id { get; set; } = null!;
    public string Email { get; set; } = null!;
}