using Business.Dtos;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class ProductService(IProductFactory productFactory) : IProductService
{
    private readonly IProductFactory _productFactory = productFactory;
    private readonly List<Product> _products = [];

    public void AddProduct(ProductDto dto)
    {
        var product = _productFactory.Create(dto);
        if (product != null)
            _products.Add(product);
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public Product GetProductById(int id)
    {
        var product = _products.FirstOrDefault(x => x.Id == id);
        if (product != null)
            return product;

        throw new KeyNotFoundException($"Product with id {id} was not found.");
    }
}
