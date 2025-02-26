using learn_007_factory_pattern;
using learn_007_factory_pattern.Factories;
using learn_007_factory_pattern.Models;
using System.ComponentModel.DataAnnotations;

var url = "https://youtu.be/JFDEzfBjbOM";
Console.WriteLine("Video Link: " + url);


UserRegistrationForm userRegistrationForm = UserFactory.Create();
#region User Registration Dialogue

// Validation loop by ChatGPT
while (true)
{
    Console.Write("Enter your first name: ");
    userRegistrationForm.FirstName = Console.ReadLine()!;

    Console.Write("Enter your last name: ");
    userRegistrationForm.LastName = Console.ReadLine()!;

    Console.Write("Enter your email: ");
    userRegistrationForm.Email = Console.ReadLine()!;

    Console.Write("Enter new password: ");
    userRegistrationForm.Password = Console.ReadLine()!;

    Console.Write("Enter the password again: ");
    userRegistrationForm.ConfirmPassword = Console.ReadLine()!;

    // Validate the form
    var validationResults = new List<ValidationResult>();
    var context = new ValidationContext(userRegistrationForm);
    if (Validator.TryValidateObject(userRegistrationForm, context, validationResults, true))
    {
        break; // Exit loop if validation is successful
    }

    Console.WriteLine("\nValidation Errors:");
    foreach (var error in validationResults)
    {
        Console.WriteLine($"- {error.ErrorMessage}");
    }
    Console.WriteLine("Please try again.\n");
}

#endregion

UserEntity userEntity = UserFactory.Create(userRegistrationForm);
#region UserEntity Output Dialogue

// The number that is visible in this output ($"{"This",-8} That") is the amount of spaces there is between "This" and "That". 
Console.WriteLine("");
Console.WriteLine("UserEntity:");
Console.WriteLine($"{"Id:",-15}{userEntity.Id}");
Console.WriteLine($"{"Name:",-15}{userEntity.FirstName} {userEntity.LastName}");
Console.WriteLine($"{"Email:", -15}{userEntity.Email}");
Console.WriteLine($"{"Password:",-15}{userEntity.Password}");
Console.WriteLine("");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

#endregion

User user = UserFactory.Create(userEntity);
#region User Output Dialogue

// The number that is visible in this output ($"{"This",-8} That") is the amount of spaces there is between "This" and "That". 
Console.WriteLine("");
Console.WriteLine("User:");
Console.WriteLine($"{"Id:",-15}{user.Id}");
Console.WriteLine($"{"Name:",-15}{user.FirstName} {user.LastName}");
Console.WriteLine($"{"Email:",-15}{user.Email}");
Console.WriteLine("");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

#endregion

Console.WriteLine("");
Console.WriteLine("Press any key to quit...");
Console.ReadKey();