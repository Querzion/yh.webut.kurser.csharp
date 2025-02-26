using switches;
using System;
using System.ComponentModel;
using System.Reflection.Metadata;

var url = "https://youtu.be/j69ckmAYRFU";
Console.WriteLine("Video Link " + url);

/// <summary>Relation Operators</summary>
/// 
/// ==  (Equals)
/// !=  (Not Equals)
/// >   (Larger then)
/// <   (Smaller then)
/// >=  (Larger then or equal with/to)
/// <=  (Smaller then or equal with/to)
/// 
/// <summary>Logic Operators</summary>
/// 
/// &&  (And)
/// ||  (or)
/// !   (Not)
/// 
/// <summary>Other Operators</summary>
/// 
/// ??      (Null coalescing operator)
/// new     (Create new instance)
/// typeof  (Get Type-object for a variable type)
/// is      (Variable Type control)
/// as      (Variable Typeconvertion with null-check)
/// 

int minValue = 0;
int maxValue = 100;

int currentValue = 10;

/// IF, ELSE IF, ELSE - STATEMENTS

// If is a start check, and else if is a followup statement.
if (currentValue < minValue)
{
    Console.WriteLine("Value is less then the minimum value.");
}
else if (currentValue > maxValue)
{
    Console.WriteLine("Value is greater then the maximum value.");
}
else if (currentValue > minValue)
{
    Console.WriteLine("Value is greater then the minimum value.");
}
else
{
    Console.WriteLine("Statement is false.");
}

// This is a separate if statement, and does not act as a followup, but rather a next statement.
if (currentValue < maxValue)
{
    Console.WriteLine("Value is less then the maximum value.");
}

// This if statement becomes a new statement and has a followup. 
if (currentValue <= minValue)
{
    Console.WriteLine("Value is less then or equal to the minValue.");
}
else if (currentValue >= maxValue)
{
    Console.WriteLine("Value is greater then or equal to the maxValue.");
}
else
{
    Console.WriteLine("Value is within the acceptable range.");
}


/// IF IN IF STATEMENTS (ANOTHER VERSION OF ELSE IF)

if (currentValue >= minValue || currentValue <= maxValue)
{
    Console.WriteLine("Maybe right.");

    if (currentValue >= maxValue)
    {
        Console.WriteLine("Maybe right.");
    }
    else
    {
        Console.WriteLine("Nope");
    }
}
else
{
    Console.WriteLine("Test of mindscape. . .");
}

/// CONDITIONS THROUGH BOOLEAN STATEMENTS

// This is a variable that has been created with a condition, and based on the condition it's going to change it's value.
string result = (currentValue < maxValue) ? "Statement is true" : "Statement is false";
Console.WriteLine(result);

bool isEnabled = true;
string result2 = isEnabled ? "That's true" : "That's false";

Console.WriteLine(result2);

// Since isEnabled is a boolean, it's only going to check if it's true or not. and then give multiple statements.
if (isEnabled)
{
    Console.WriteLine("Step 1 ... ");
    Console.WriteLine("Step 2 ... ");
    Console.WriteLine("Step 3 ... ");
    Console.WriteLine("Step 4 ... ");
}

// A condition cannot handle more then one statement at a time, as the if statement can.
var hasKitten = false;

string result3 = hasKitten
    ? "I found your kitten!"
    : "Oh! Did you lose your kitten again?";

Console.WriteLine(result3);


/// SWITCH & CASE STATEMENTS (IT ONLY CHECKS IF IT'S AN EQUAL STATEMENT ==)

string option = "1";

switch (option.ToLower())
{
    case "1":
        Console.WriteLine("Option 1 active.");
        break;
    case "2":
        Console.WriteLine("Option 2 active.");
        break;
    case "3":
        Console.WriteLine("Option 3 active.");
        break;
    case "4":
        Console.WriteLine("Option 4 active.");
        break;
    default:
        Console.WriteLine("Default active.");
        break;
}


// Shown here. You can only use single statements, and not shift around in which direction it's checked half-ways either.
int numOption = 73;

switch (numOption)
{
    case <= 25:
        Console.WriteLine("Option 1 active.");
        break;
    case <= 50:
        Console.WriteLine("Option 2 active.");
        break;
    case <= 75:
        Console.WriteLine("Option 3 active.");
        break;
    case 100:
        Console.WriteLine("Option 4 active.");
        break;
    default:
        Console.WriteLine("Default active.");
        break;
}

/// USING THE PRINTINGSTATUS.CS FILE NOW!
//using switches;

var currentStatus = PrintingStatus.Starting;

while (true)
{
    switch (currentStatus)
    {
        case PrintingStatus.Idle:
            currentStatus = PrintingStatus.Starting;
            Console.WriteLine($"The printer is starting up.");
            break;

        case PrintingStatus.Starting:
            currentStatus = PrintingStatus.Loading;
            Console.WriteLine($"The printer is loading paper.");
            break;

        case PrintingStatus.Loading:
            currentStatus = PrintingStatus.Printing;
            Console.WriteLine($"The printer is printing.");
            break;

        case PrintingStatus.Printing:
            currentStatus = PrintingStatus.Cleaning;
            Console.WriteLine($"The printer is cleaning headers.");
            break;

        case PrintingStatus.Cleaning:
            currentStatus = PrintingStatus.Stopping;
            Console.WriteLine($"The printer is finishing print.");
            break;

        case PrintingStatus.Stopping:
            currentStatus = PrintingStatus.Idle;
            Console.WriteLine($"The printer is on Stand-by mode.");
            Thread.Sleep(3000);
            Console.WriteLine(" . . . ");
            break;
    }


    Thread.Sleep(2000);
    // This is added in order to break the eternity loop.
    break;
}

Console.Write("How old are you? : ");

// ! ignores a potential empty field error.
//string input_age = Console.ReadLine()!;
// ?? checks if there is a value present, if not the default will be used in order to not crash the application.
// This default value cannot be used, because it's a null value. even if it says "Hey Stan! I'm pregnant.". 
// It's a Null value, placeholder so that ReadLine won't crash the program.
string input_age = Console.ReadLine() ?? "0";
// When ?? Is used, then there's going to be a convertion error.
//int age = int.Parse(input_age);
Console.WriteLine("Your age is: " + input_age + " years.");

// Let's see now when it actually comes to use. ;P No errols are greater then those of the meme. ;P
// Since current age is declared to not have a null, it's the next value that is going to be used which is the ?? "Value".
string current_age = null!;
input_age = current_age ?? "Hey Stan! I'm pregnant.";

Console.WriteLine("Your age is: " + input_age + " years.");

// Let's stop fooling around and make it a real usable number from the static nullSYKE.
input_age = current_age ?? "0";

int age = int.Parse(input_age);

Console.WriteLine("Your age is: " + age + " years.");

// Now If I give the current age an actual number, then it's going to use that rather then the nullSYKE default value. ;P
current_age = "38";

input_age = current_age ?? "0";

age = int.Parse(input_age);

Console.WriteLine("Your age is: " + age + " years.");


// Let's see if I can actually add an input to the statement now.
Console.Write("How old are you? : ");
current_age = Console.ReadLine()!;

if (current_age.Length < 0)
{
    input_age = current_age ?? "0";

    age = int.Parse(input_age);

    Console.WriteLine("Your age is: " + age + " years.");
}
else
{
    Console.WriteLine("PSYKE! Age undetermined");
}
// Well that didn't work as expected. "/ Actually it's borked, till I learn more about how to play around with the true/false

/// NULL CONDITIONAL ?.
/// Used in order to avoid NullReferenceExceptions.
///

//string user.Firstname = null!;
// If there isn't a present displayname, don't add it. This is something that is used later on though. 
//var displayName = user?.FirstName;

Console.ReadKey();