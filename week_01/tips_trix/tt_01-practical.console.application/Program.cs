
using System.Net.Mail;

/* Create Variables */
string[] userDataName = new string[1];
List<string> userDataEmail = [];
var answer = "";

// Create a Start message.
Console.WriteLine("Hello & Welcome!");

// Name Segment

do
{
    Console.Write("Please enter your full name: ");
    answer = Console.ReadLine()!;

} while (answer == "");

userDataName[0] = answer;


// Email Segment

do
{
    Console.Write("Please enter your email-address: ");
    answer = Console.ReadLine()!;

} while (answer == "");
userDataEmail.Add(answer);

// Print Answers;
foreach (string name in userDataName)
    Console.Write($"Hello {name}, ");

foreach (string email in userDataEmail)
    Console.WriteLine($"you will be contacted via email on {email}, asap.");

Console.WriteLine("Thank you for your interest." );


Console.WriteLine("Press any key to exit... ");
Console.ReadKey();

/// Teacher Version
/// 

answer = "";

do
{
    Console.Clear();
    Console.WriteLine("Ange din e-postaddress: ");
    answer = Console.ReadLine()!;
    userDataEmail.Add(answer);

    if (string.IsNullOrEmpty(answer))
    {
        Console.WriteLine("Du måste ange en e-postaddress.");
        Console.ReadKey();
        Console.Clear();
    }

} while (string.IsNullOrEmpty(answer));

Console.Clear();
Console.WriteLine($"{userDataName[0]} <{answer}>");

Console.WriteLine("Press any key to exit... ");
Console.ReadKey();