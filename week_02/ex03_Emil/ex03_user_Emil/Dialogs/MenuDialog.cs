using static System.Console;

using Business_Emil.Models;
using Business_Emil.Services;

namespace ex03_user_Emil.Dialogs;

public class MenuDialog
{
    private readonly ContactService _contactService = new();


    public void ShowMenu()
    {
        var isRunning = true;
        
        do
        {
            Clear();
            WriteLine("************* CONTACT LIST **************");
            WriteLine("1. Add New Contact");
            WriteLine("2. View ALl Contacts");
            WriteLine("Q. Exit Application");
            WriteLine("*****************************************");
            Write("Select an option: ");
            var selection = ReadLine()!;

            switch (selection.ToLower())
            {
                case "1":
                    ShowAddContact();
                    break;
                case "2":
                    ShowAllContacts();
                    break;
                case "q":
                    Clear();
                    OutputDialog("Program terminated. Press any key to exit.");
                    isRunning = false;
                    break;
                default:
                    OutputDialog("Invalid selection, please try again!");
                    break;
            }
            
        } while(isRunning);
    }

    public void ShowAddContact()
    {
        var contact = new ContactModel();
        
        Clear();
        WriteLine("************* ADD NEW CONTACT **************");
        
        Write("Enter contact firstname: ");
        contact.FirstName = ReadLine()!;
        
        Write("Enter contact lastname: ");
        contact.LastName = ReadLine()!;
        
        Write("Enter contact email: ");
        contact.Email = ReadLine()!;
        
        _contactService.CreateContacts(contact);
    }

    public void ShowAllContacts()
    {
        bool hasError;
        var contacts = _contactService.GetAllContacts(out hasError);
        
        Clear();
        WriteLine("************* VIEW ALL CONTACTS **************");

        if (hasError)
        {
            OutputDialog("There was an error getting all contacts. Please try again.");
            return;
        }
        
        if (!contacts.Any())
        {
            OutputDialog("There are no contacts found! Press any key to go back...");
            return;
        }

        foreach (var contact in contacts)
        {
            WriteLine($"ContactId: {contact.Id} Name: {contact.FirstName} {contact.LastName} Email: {contact.Email} Date: {contact.CreatedDate}");
        }
        ReadKey();
    }

    public void OutputDialog(string message)
    {
        WriteLine(message);
        ReadKey();
    }
}