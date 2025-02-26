using Shared.Models;
using System.Data;

namespace Shared.Services;

public class CustomerService
{
    public List<Customer> Customers { get; private set; } = []; 

    public bool AddCustomerToList(Customer customer)
    {
        if (!string.IsNullOrWhiteSpace(customer.CompanyName))
        {
            Customers.Add(customer);
            return true;
        } 
        return false;
    }

    public IEnumerable<Customer> GetCustomers()
    {
        return Customers;
    }

    public bool RemoveCustomerFromList(Customer customer)
    {
        if (!string.IsNullOrWhiteSpace(customer.CompanyName))
        {
            var existingCustomer = Customers.FirstOrDefault(x => x.CompanyName == customer.CompanyName);
            
            if (existingCustomer != null)
            {
                Customers.Remove(existingCustomer);
                return true;
            }
        }
        return false;
    }
}
