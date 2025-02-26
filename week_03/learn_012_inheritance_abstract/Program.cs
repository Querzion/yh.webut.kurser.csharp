

using learn_012_inheritance_abstract.Models;

// Phase 1 - From phase 3 onwards it's not possible to initialize the classes
// as they were created before, since there exists no empty constructor.

// Inheritance from Customer, makes it possible to add Id and Email to Private.
// Private privateCustomer = new Private()
// {
//     Id = "1",
//     FirstName = "John",
//     LastName = "Doe",
//     Email = "john.doe@domain.com"
// };

// Inheritance from Customer, makes it possible to add Id and Email to Company.
// Company companyCustomer = new Company()
// {
//     Id = "2",
//     CompanyName = "John Doe Express",
//     ContactPerson = "John Doe",
//     Email = "john.doe@domain.com"
// };

// Phase 2

// This is however the problem, Customer becomes its own function, and can be initialized, that's bad. 
// "abstract" is added, and you can no longer initialize Customer outside its inheritance features.
// Customer customerCustomer = new Customer()
// {
//     Id = "3",
//     Email = "?@domain.com"
// };

// Phase 3

// For this to work, a constructor is needed, and it too, inherits from the Customer class.
Private privateCustomer2 = new Private("4", "john.doe@domain.com", "John", "Doe");
Company companyCustomer2 = new Company(
    id: "5", 
    email: "john.doe@domain.com", 
    companyName: "John Doe Express", 
    contactPerson: "John Doe"
);

// Phase 6 - protected variables
// privateCustomer2.SetId("1");
// privateCustomer2.GetId();
// companyCustomer2.SetId("2");
// companyCustomer2.GetId();

// Phase 7 - protected properties
// get info
var id = companyCustomer2.Id; 
// get is cleared
// set info while protected
// companyCustomer2.id = "2";
// didn't work.
companyCustomer2.SetId("2");
// set is cleared

// Phase 7 - private properties... Cannot be changed outside of the class.

// Phase 9 - encrypted password.
privateCustomer2.SetSecurePassword("password");
Console.WriteLine($"P-id: {privateCustomer2.GetId()}, password: Byte Me. . . ;D");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();