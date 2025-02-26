
string url = "https://youtu.be/MKjIhNYVMjM";
Console.WriteLine("Video Link " + url);

/// FOR LOOPS
/// 

// Start at zero, stop before ten.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// Start at one, stop at 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("LET'S GET READY TO RUMBLE!!");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Round " + i);

    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine(j);
    }

    Thread.Sleep(300);
}
Console.WriteLine("AND END!");

/// FOR LOOPS AND ARRAYS

string[] names = ["Slisk", "Ace", "Tenzo"];

// Short version singular output.
for (int i = 0; i < names.Length; i++)
    Console.WriteLine(names[i]);

// Bracket version, which is preferred even if it's just one singular output.
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

/// FOR LOOPS AND LISTS

List<string> namesList = ["Slisk", "Tisch", "Alyssa", "Alizé"];

for (int i = 0; i < namesList.Count; i++)
{
    string name = namesList[i];
    Console.WriteLine(name);
}

/// FOREACH LOOPS AND LISTS

// Curly bracket version for singular or multiple outputs per loop.
foreach (string name in namesList)
{
    Console.WriteLine(name);
}

// Shortened version for singular outputs.
foreach (string name in namesList)
    Console.WriteLine(name);

// there's also a built in loop function for lists and they look like this.
namesList.ForEach(name => Console.WriteLine(name));
// or like this. . . 
namesList.ForEach(name =>
{
    Console.Write("List Name: ");
    Console.WriteLine(name);
});

/// FOREACH LOOPS AND ARRAYS
// Oh yeah, foreach loops works for arrays too. 
foreach (string name in names)
{
    Console.Write("Array name: ");
    Console.WriteLine(name);
}

namesList.Add("Mats");
namesList.Sort();

IEnumerable<string> nameList = namesList;
foreach (string name in nameList)
{
    Console.Write("IEnumerable name: ");
    Console.WriteLine(name);
}

/// While Loops - while & do-while
/// 
/// While checks the conditions before it enters the loop.
/// Do-While checks the conditions after it enters the loop.

bool miffo = true;

while (miffo == true)
{
    Console.WriteLine(miffo);
    for (int i = 0; i < namesList.Count; i++)
    {
        Console.WriteLine(namesList[i]);
    }
    miffo = false;

    //if (miffo == false)
    //    break;
}

int number = 0;
bool run = true;

while (run == true)
{
    Console.WriteLine(run);
    run = false;
    Console.WriteLine(run);

    //if (run == false)
    //    break;
}

number = 0;

while (number < 10)
{
    Console.Clear();
    Console.WriteLine($"Number = {number}");

    for (int i = 0; i < 101; i++)
    {
        Console.WriteLine($"i = {i}");
    }

    if (number == 5)
        break;

    number++;
}
Console.WriteLine("All done!");

/// DO WHILE LOOP (MENU)

Console.Clear();
string answer = "";

// Do loop, while q is not chosen.
do
{
    Console.WriteLine("MENU OPTIONS");
    Console.WriteLine("1. OPTION 1");
    Console.WriteLine("2. OPTION 2");
    Console.WriteLine("3. OPTION 3");
    Console.WriteLine("Q. QUIT");

    answer = Console.ReadLine()!;

} while (answer != "q");

bool isConnected = true;

// This is not an optimal usecase for a do-while loop, since it starts it regardless if there's a problem or not.
// Do loop, if while isConnected is false (!)
do
{
    Console.Clear();
    Console.WriteLine("Connecting...");

} while (!isConnected);

// It's better to use While when encountering a situation that needs a condition before starting.
// While isConnected not true do this. (!)
while (!isConnected)
{
    Console.WriteLine("Connecting...");
    isConnected = true;
}

Console.WriteLine("Testing Testing");


Console.ReadKey();