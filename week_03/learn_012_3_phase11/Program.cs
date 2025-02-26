using learn_012_3_phase11.Models;

// Private privateCustomer = new Private();
//
// privateCustomer.FirstName = "John";
// privateCustomer.LastName = "Doe";
// privateCustomer.Email = "johndoe@gmail.com";
// // Id is set through a constructor in Customer.cs
// // privateCustomer.Id = Guid.NewGuid().ToString();
//
// Console.Write("Enter a secure private password: ");
// var input = Console.ReadLine();
// privateCustomer.SetSecurePassword(input);
//
// Company companyCustomer = new Company()
// {
//     // Id is set through the constructor in Customer.cs
//     // Id = Guid.NewGuid().ToString(),
//     Email = "email@email.com",
//     CompanyName = "John Doe Express",
//     ContactPerson = "John Doe"
// };
//
// Console.Write("Enter a secure company password: ");
// input = Console.ReadLine();
// companyCustomer.SetSecurePassword(input);
//
// // Phase 14 - privateCustomer custom changes with override.
// privateCustomer.GetSecurePassword(input);
//
// Console.Write("Whoops! Your private password hash was leaked... Multiple times... >> \n");
// Console.WriteLine(privateCustomer.GetSecurePassword(input));
// Console.WriteLine(privateCustomer.GetSecurePassword(input));
// Console.WriteLine(privateCustomer.GetSecurePassword(input));


var privateCustomer_1 = new Private()
{
    Email = "email@email.com",
    FirstName = "John",
    LastName = "Doe"
};

Console.WriteLine("Private Password is being set to the default value:\nIs the password set to the same?  ");
// input = Console.ReadLine();

privateCustomer_1.SetSecurePassword("FUNKAR_VISST!");
var result = privateCustomer_1.ValidateSecurePassword("FUNKAR_VISST!");

Console.WriteLine(privateCustomer_1.Id);
Console.WriteLine($"Result: {result}");

var companyCustomer_1 = new Company()
{
    Email = "email@email.com",
    CompanyName = "John Doe Express",
    ContactPerson = "John Doe"
};

Console.WriteLine("Company Password is being set to the default value:\nIs the password set to the same?  ");
companyCustomer_1.SetSecurePassword("FALSE");
result = companyCustomer_1.ValidateSecurePassword("FALSE");

Console.WriteLine(companyCustomer_1.Id);
Console.WriteLine($"Result: {result}");

Console.WriteLine("");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();