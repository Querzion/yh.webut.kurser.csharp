using System.Text.Json;
using learn_014_moq_mocking.Interfaces;
using learn_014_moq_mocking.Models;

namespace learn_014_moq_mocking.Services;

// public class ProductService : IProductService
public class ProductService(IFileService fileService) : IProductService
{
    // Part One
    // private List<Product> _products = [];
    //
    // public bool AddProductToList(Product product)
    // {
    //     try
    //     {
    //         _products.Add(product);
    //         return true;
    //     }
    //     catch
    //     {
    //         return false;
    //     }
    // }
    //
    // public bool CreateProduct(ProductRegistrationForm form)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public IEnumerable<Product> GetProducts()
    // {
    //     return _products;
    // }
    
    // Part Two
    private readonly IFileService _fileService = fileService;
    private List<Product> _products = [];

    public bool CreateProduct(ProductRegistrationForm form)
    {
        try
        {
            var product = new Product { Title = form.Title, Price = form.Price };
            _products.Add(product);
            
            var json = JsonSerializer.Serialize(product);
            _fileService.SaveContentToFile(json);
            
            return true;
        }
        catch
        {
            return false;
        }
    }

    public IEnumerable<Product> GetProducts()
    {
        try
        {
            var json = _fileService.GetContentFromFile();
            _products = JsonSerializer.Deserialize<List<Product>>(json) ?? [];
            return _products;
        }
        catch
        {
            return [];
        }
    }
}