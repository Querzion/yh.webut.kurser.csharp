using learn_011_3_interfaces.Interfaces;
using learn_011_3_interfaces.Models;

// IPrivateCustomer privateCustomer = new PrivateCustomer();
// ICompanyCustomer companyCustomer = new CompanyCustomer();
//
// List<ICustomer> customers = [];
//
// customers.Add(privateCustomer);
// customers.Add(companyCustomer);

var url = "https://youtu.be/CTVrxtH8zqg";
Console.WriteLine("Video Link: " + url);

IPrivateCustomer privateCustomer = new PrivateCustomer
{
    Id = "1",
    Email = "slisk.lindqvist@querzion.com",
    FirstName = "Slisk",
    LastName = "Lindqvist"
};

ICompanyCustomer companyCustomer = new CompanyCustomer
{
    Id = "2",
    Email = "info@domain.com",
    CompanyName = "EPN Sverige AB"
};

List<ICustomer> customers = [];

customers.Add(privateCustomer);
customers.Add(companyCustomer);

foreach (var customer in customers)
{
    // This output will only give out Id and Email,
    // in order to gain access to more data, it's going to need a different approach.
    // Console.WriteLine($"{customer.Id} - {customer.Email}");

    if (customer is IPrivateCustomer pCustomer)
    {
        Console.WriteLine("\nPrivate Customer");
        Console.WriteLine($"Id: {pCustomer.Id}");
        Console.WriteLine($"Email: {pCustomer.Email}");
        Console.WriteLine($"FirstName: {pCustomer.FirstName}");
        Console.WriteLine($"LastName: {pCustomer.LastName}");
    }
    else if (customer is ICompanyCustomer cCustomer)
    {
        Console.WriteLine("\nCompany Customer");
        Console.WriteLine($"Id: {cCustomer.Id}");
        Console.WriteLine($"Email: {cCustomer.Email}");
        Console.WriteLine($"Company: {cCustomer.CompanyName}");
    }
    
}


Console.WriteLine("\nPress any key to continue...");
Console.ReadKey();