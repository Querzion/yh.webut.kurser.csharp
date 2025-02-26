using Data.Contexts;
using Data.Entities;

namespace Business.Services;

public interface IProductService
{
    void CreateProduct(string title, decimal price);
    IEnumerable<ProductEntity> GetAllProducts();
    ProductEntity GetProduct(int id);
}

public class ProductService(
    DataContext context
    ) : IProductService
{
    private readonly DataContext _context = context;
    
    public void CreateProduct(string title, decimal price)
    {
        var productEntity = new ProductEntity
        {
            Title = title,
            Price = price
        };
        
        _context.Products.Add(productEntity);
        _context.SaveChanges();
    }
    
    public IEnumerable<ProductEntity> GetAllProducts()
    {
        var products = _context.Products.ToList();
        return products;
    }

    public ProductEntity GetProduct(int id)
    {
        var product = _context.Products.Find(id);
        return product;
    }
}