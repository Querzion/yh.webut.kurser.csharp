/*///     PROPERTIES
///     
///     There are four definitions that you can give,
///     a variable, method or class, and they work like this.
///     

///     Public
///     
//      Works Internally,
//      between classes that are nested,
//      between different classes in the same project,
//      between different classes in the same solution.

///     Internal
///     
//      Works internally,
//      between classes that are nested,
//      between different classes in the same project.

///     Protected
///     
//      Works internally,
//      between classes that are nested.

///     Private
///     
//      Works internally.*/

// When a private field/variable is created, use underscore as the opening character, 
// to the variable name to signify that it's a variable that is private.

using learn_005_classes.Models;


User user = new User("Stevie", "Wonder");


// var userTestCamp = new User()
// {
//     FirstName = "Dracul"
// };

Console.Write("Gift me your first name: ");
user.FirstName = Console.ReadLine()!;
Console.WriteLine(user.FirstName);
Console.Write("Gift me your last name: ");
user.LastName = Console.ReadLine()!;
Console.WriteLine(user.LastName);

// if (user.FirstName == "Why?")
// {
//     user.FirstName = userTestCamp.FirstName;
//     Console.WriteLine("Is it " + user.FirstName + " then?");
//
//     user.FirstName = "Slisk";
//     Console.WriteLine("I know what you did last summer " + user.FirstName);
// }

/*/// FIELDS
/// 
// TokenGenerator & UserService variables

/// READONLY
/// 
// UserService

/// CONSTRUCTOR
/// 
// Is named the same as the class - User & UserService - the parenthesis is the constructor initialization. 
//var userService = new UserService();

//var korvkoiskOwner = new User("Slisk", "Lindqvist");

//Console.WriteLine(korvkoiskOwner.FirstName);

/// METHODS
/// */
// A method is very different from a function, a function has its own separate call and functionality, while a 
// method is directly linked as a function for a class, and is within a class.
//User.Greeting();

//string greeting = User.GreetingTwo();

//Console.WriteLine(greeting);


// Calculator
//var result = Calculator.Add(11);











Console.ReadKey();