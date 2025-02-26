
List<string> shoppingList = new List<string>();

shoppingList.Add("Äpplen");
shoppingList.Add("Mjölk");

var addToList = "";
string month = DateTime.UtcNow.ToString("MMMM");

bool isRunning = true;

do
{
    Console.WriteLine($"Shoppinglista inför {month} (Avsluta genom att skriva 'Klar')");
    Console.Write($"Addera : ");
    addToList = Console.ReadLine()!;
    // Min version
    //if (addToList != "")
    //{
    //    if (addToList != "klar")
    //    {
    //        shoppingList.Add(addToList!);
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("Du la inte till något.");
    //}

    // Från Emils version
    if (string.IsNullOrWhiteSpace(addToList))
    {
        Console.WriteLine("Du måste ange en vara");
    }
    else
    {

        switch (addToList)
        {
            case "klar":
                isRunning = false;
                break;

            case "ej tillåtet":
                break;

            default:
                shoppingList.Add(addToList);
                Console.WriteLine($"{addToList} har lagts till i listan.");
                break;
        }
    }

    Console.WriteLine("Tryck valfri knapp för att fortsätta.");
    Console.ReadKey();
    Console.Clear();

} while (isRunning);
//} while (addToList.Equals("klar", StringComparison.CurrentCultureIgnoreCase));
//} while (addToList != "Klar" && addToList != "klar");

Console.WriteLine("Din shoppinglista:");
int i = 1;

foreach (var item in shoppingList)
{
    Console.WriteLine($"{i}: {item}.");
    i++;
}

Console.WriteLine("Tryck valfri knapp för att avsluta.");
Console.ReadKey();