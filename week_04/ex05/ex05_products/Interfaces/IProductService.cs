using ex05_products.Dtos;
using ex05_products.Models;

namespace ex05_products.Interfaces;

public interface IProductService
{
    public void AddProduct(ProductDto productDto);
    public Product GetProductById(int id);
    public List<Product> GetAllProducts();
}