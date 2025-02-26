using ex05_Business.Dtos;
using ex05_Business.Interfaces;
using ex05_Business.Models;

namespace ex05_Business.Services;

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

    public Product GetProductById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            throw new KeyNotFoundException($"Product with ID {id} not found.");
        return product;
        
        // var product = _products.FirstOrDefault(p => p.Id == id);
        // if (product != null)
        //     return new ResponseResult<Product>
        //     {
        //         Success = true,
        //         StatusCode = 200,
        //         Result = product
        //     };

        // return new ResponseResult<Product>
        // {
        //     Success = false,
        //     StatusCode = 404,
        //     Error = $"Product with {id} not found."
        // };
    }

    // public IEnumerable<Product> GetAllProducts()
    // {
    //     return _products;
    // }
    
    public IEnumerable<Product> GetAllProducts() => _products;

    public class ResponseResult<T>
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string? Error  { get; set; }
        public T? Result { get; set; }
    }
}