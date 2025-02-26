
var url = "https://youtu.be/RI4brtlo3zU";
Console.WriteLine($"Video Link: {url}");

/// <summary>ARRAYS - Adding values after stating how long/big they are</summary>
// String array name create array with x amount of slots.
string[] array = new string[3];

array[0] = "Mats";

Console.WriteLine($"Array 1: {array[0]}");

array[1] = "Slisk";

Console.WriteLine($"Array 2: {array[1]}");

array[2] = array[0];

Console.WriteLine($"Array 3: {array[2]}");

array[0] = string.Empty;

Console.WriteLine($"Array 1: {array[0]}");
Console.WriteLine($"Array 2: {array[1]}");
Console.WriteLine($"Array 3: {array[2]}");

// singular Characters
char[] array2 = new char[2];

array2[0] = 'M';
array2[1] = 'S';

Console.WriteLine(array2[0]);
Console.WriteLine(array2[1]);


// Array where the static values are added directly.
string[] arrayNames = ["Mats", "Slisk", "Raymond", "Nikolaj", "Figge", "Ace", "Joy", "Linda", "Matilda", "Marika"];

// They can be accessed in the same way as before, but why make it a lot of extra text?
Console.WriteLine($"ArrayName 1: {arrayNames[0]}");
Console.WriteLine($"ArrayName 2: {arrayNames[1]}");

// This is when a loop comes in handy to render through an array.
foreach (string name in arrayNames)
    Console.WriteLine(name);

// But I don't want my order, I want the names sorted in alphabetical order.
Array.Sort(arrayNames);

// Lets re-run the render.
foreach (string name in arrayNames)
    Console.WriteLine(name);

// Adding values directly to an Array in it's creation.
int[] array3 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

foreach (int i in array3)
    Console.WriteLine(i);

/// <summary>LISTS - Declare a list, and change it as you see fit.</summary>
// List variabletype name it, create a new list function.
// A list can be written with it's full definition, but can also be shortened down.
List<string> list = new List<string>();
List<string> list2 = new();
List<string> list3 = [];

// If you create a var variable list, then you have to extend it to declare it's purpose as done in 'list'.
var customers = new List<string>();

list.Clear();
list2.Clear();
list3.Clear();
customers.Clear();
// The lists are now cleared from any prior data.

// If you want to add information to a list, you just use add.
customers.Add("Slisk");
customers.Add("Mats");
customers.Add("Anna-Maj");
customers.Add("Arijana");
customers.Add("Peter");

foreach (string name in customers)
    Console.WriteLine($"Names Added (Add): {name}");

// And if you want to remove information from a list, you just use remove.
customers.Remove("Mats");

foreach (string name in customers)
    Console.WriteLine($"One Name Removed (Remove): {name}");

customers.Sort();

foreach (string name in customers)
    Console.WriteLine($"Alphabetical (Sort): {name}");

customers.Reverse();

foreach (string name in customers)
    Console.WriteLine($"List (Reverse): {name}");

var customerFind = customers.Contains("Slisk");
Console.WriteLine($"Customer Exists (Contains): {customerFind}");

bool exists = customers.Contains("Anna");
Console.WriteLine($"Customer Exists (Contains): {exists}");

var listObjects = customers.Any();
Console.WriteLine($"List contains items (var Any): {listObjects}");
bool listObjects2 = customers.Any(customer => customer == "Pelle");
// This way of searching for something can come in handy when you are looking for specific in something bigger such a class property etc.
//var classObjects = customers.Any(customer => customer.FirstName == "Slisk");
Console.WriteLine($"List contains items (bool Any + Func): {listObjects2}");

var customerAmount = customers.Count();
Console.WriteLine($"Customer Count: {customerAmount} customers.");

// Faster way to write out all list items.
customers.ForEach(person => Console.WriteLine($"Customer: {person}"));

// New variable IEnumerable is a list that you can either make a new list into, or copy an already existing list to.
// An IEnumerable list cannot be changed with Add/Remove, it becomes somewhat a static list.
IEnumerable<string> mumbleNumbleFive = new List<string>();
IEnumerable<string> customerList = customers;
// This can be made with a normal list too, but that's a list you can Add/Remove to.
List<string> customerList2 = customers;

// Teacher Example:
// Remote Hardware
List<string> databaseList = [];
databaseList.Add("Slisk");

// Local Hardware (This will not work properly, even if it works in this example. So in order to add to the remote database in real life)
List<string> inMemoryList = databaseList;
inMemoryList.Add("Mats");

// You will have to force the change to happen on the remote database front, and that's why you use IEnumerable,
// So that you can gain access to the right data, at all times. 
IEnumerable<string> inMemoryList2 = databaseList;
//inMemoryList2.Add(); So you cannot Add/Remove to the IEnumerable list locally, and have to add it to the remote list, in order to gain access to the new item.
// IEnumerable is preferably the best and only way to gain access to correct database information.

foreach (string name in databaseList)
    Console.WriteLine(name);
foreach (string name in inMemoryList)
    Console.WriteLine(name);







Console.ReadKey();