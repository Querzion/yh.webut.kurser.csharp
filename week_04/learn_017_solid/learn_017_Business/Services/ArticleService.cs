using System.Diagnostics;
using learn_017_Business.Factories;
using learn_017_Business.Helpers;
using learn_017_Business.Interfaces;
using learn_017_Business.Models;

namespace learn_017_Business.Services;

public class ArticleService(IArticleRepository articleRepository) : IArticleService
{
    private readonly IArticleRepository _articleRepository = articleRepository;
    private List<ProductEntity> _items = [];

    // Implement Id on an item that uses int instead of string.
    // var id = IdGenerator.AutoIncrementId(_items.Last().Id);
    
    public bool CreateItem(ItemRegistrationForm form)
    {
        try
        {
            var productEntity = ProductFactory.Create(form);
            productEntity.Id = IdGenerator.GenerateUniqueId();
            
            _items.Add(productEntity);

            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
    
    public IEnumerable<Product> GetAllItems()
    {
        _items = _articleRepository.GetFromFile()!;
        
        // Get all items regardless if they are a service or not.
        return _items
            .Select(item => ProductFactory.Create(item));
    }
    
    public IEnumerable<Product> GetAllProductItems()
    {
        _items = _articleRepository.GetFromFile()!;
        
        // Get all items that are not part of any service (Only Products)
        return _items
            .Where(item => item.IsService == false)
            .Select(item => ProductFactory.Create(item));
    }

    public IEnumerable<Product> GetAllServiceItems()
    {
        _items = _articleRepository.GetFromFile()!;
        
        // Get all items that is part of a service (Only Services)
        return _items
            .Where(item => item.IsService == true)
            .Select(item => ProductFactory.Create(item));
    }
}