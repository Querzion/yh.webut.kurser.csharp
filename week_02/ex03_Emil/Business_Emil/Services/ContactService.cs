using System.Text.Json;
using Business_Emil.Models;

namespace Business_Emil.Services;

public class ContactService
{
    private readonly FileService _fileService = new();
    private List<ContactModel> _contactsList = [];
    
    // Skapar en kontakt
    public void CreateContacts(ContactModel model)
    {
        model.Id = _contactsList.Count > 0 ? _contactsList[^1].Id + 1 : 1;
        model.CreatedDate = DateTime.Now;
        
        _contactsList.Add(model);

        var json = JsonSerializer.Serialize(_contactsList);
        _fileService.SaveContentToFile(json);
    }

    // hämtar alla kontakter
    public IEnumerable<ContactModel> GetAllContacts(out bool hasError)
    {
        hasError = false;
        var json = _fileService.GetContentFromFile();
        if (!string.IsNullOrEmpty(json))
        {
            try
            {
                _contactsList = JsonSerializer.Deserialize<List<ContactModel>>(json) ?? [];
            }
            catch
            {
                hasError = true;
            }
        }
        return _contactsList;
    }
}