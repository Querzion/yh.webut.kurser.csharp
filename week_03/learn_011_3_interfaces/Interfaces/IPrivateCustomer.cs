namespace learn_011_3_interfaces.Interfaces;

public interface IPrivateCustomer : ICustomer
{
    string FirstName { get; set; }
    string LastName { get; set; }
}