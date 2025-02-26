using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shared.Models;
using Shared.Services;
using System.Collections.ObjectModel;

namespace MauiWithMvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly CustomerService _customerService;

    public MainViewModel(CustomerService customerService)
    {
        _customerService = customerService;

        //foreach(Customer customer in _customerService.GetCustomers())
        //{
        //    CustomerList.Add(customer);
        //}
    }
    
    [ObservableProperty]
    private Customer _registrationForm = new();

    [ObservableProperty]
    private ObservableCollection<Customer> _customerList = [];

    [RelayCommand]
    public void AddContactToList()
    {
        if (RegistrationForm != null && !string.IsNullOrWhiteSpace(RegistrationForm.CompanyName))
        {
            var result = _customerService.AddCustomerToList(RegistrationForm);

            if (result)
            {
                // Converts the customers list in order to add to an observable collection list of Customer.
                UpdateCustomerList();
                // Empties the fields after an update has been made.
                RegistrationForm = new();
            }
        }
    }

    [RelayCommand]
    public void RemoveContactFromList(Customer customer)
    {
        if (customer != null)
        {
            var result = _customerService.RemoveCustomerFromList(customer);
            if (result)
            {
                UpdateCustomerList();
            }
        }
    }

    public void UpdateCustomerList()
    {
        CustomerList = new ObservableCollection<Customer>(_customerService.Customers.Select(customer => customer).ToList());
    }
}
