using learn_011_3_interfaces.Interfaces;

namespace learn_011_3_interfaces.Models;

public class CompanyCustomer : ICompanyCustomer
{
    public string CompanyName { get; set; } = null!;
    public string Id { get; set; } = null!;
    public string Email { get; set; } = null!;
}