using ex05_products.Dtos;
using ex05_products.Factories;
using ex05_products.Interfaces;
using ex05_products.Models;

namespace ex05_products.Services;

public class ProductService : IProductService
{
    private List<Product> _products = [];
    
    public void AddProduct(ProductDto productDto)
    {
        try
        {
            var product = ProductFactory.Create(productDto);
            _products.Add(product);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        
    }

    public Product GetProductById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        // ChatGPT because a simple problem with the return... It seems. "/
        if (product == null)
        {
            throw new KeyNotFoundException($"Product with ID {id} was not found.");
        }
        //
        return product;
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }
    
}