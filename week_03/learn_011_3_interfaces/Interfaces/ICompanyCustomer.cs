namespace learn_011_3_interfaces.Interfaces;

public interface ICompanyCustomer : ICustomer
{
    string CompanyName { get; set; }
}