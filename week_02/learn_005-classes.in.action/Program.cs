using Models;

/// DTOS
///
// DTOS = DATA TRANSFER OBJECT (So is S = Source?)
// Which is a suffix given to a class if it's purpose is to move something from one point to another.
/// MODELS
/// 
// Model can be given as a suffix. Models comes from the syntax design MVC/MVVM (Model Views Controller)
// the other is usually much more in focus when it's an application with a graphical interface, so MVVM, 
// is (Model View View Model)


/// This is one way to make a list, but it's only going to work if you don't overload your constructor, or if you add an empty constructor.
/// 
User user_0 = new User
{
    Id = 0,
    FirstName = "Slisk",
    LastName = "Lindqvist",
    Email = "slisk.lindqvist@querzion.com",
    Password = "JagVetInte",
};

/// You either do it like this. And this 
/// 
User user_2 = new User(2, "Slisk", "Lindqvist", "slisk.lindqvist@querzion.com", "JagVetInte");

/// Or because you made an empty constructor first, then you can declare your inputs in a later stage.
/// 
/// This is another way to make a list, quite clear. 
User user_1 = new User();

user_1.Id = 1;
user_1.FirstName = "Mats";
user_1.LastName = "Lindqvist";
user_1.Email = "something@querzion.com";
user_1.Password = "JagVetInte";

// Whichever is necessary, because the first is declared and filled at creation,
// while the other is declared, and filled in a later stage. Good for when you create forms, 
// or if you create something that doesn't need 

User user = new User();

Console.Write("Enter your first name: ");
user.FirstName = Console.ReadLine()!;

Console.Write("Enter your last name: ");
user.LastName = Console.ReadLine()!;

//Console.Write("Enter your email: ");
//user.Email = Console.ReadLine()!;

//Console.Write("Enter your password: ");
//user.Password = Console.ReadLine()!;

//Console.WriteLine($"Your name is {user.FirstName} {user.LastName}.");

Console.WriteLine($"Your name is {user.FullName}.");

Console.ReadKey();