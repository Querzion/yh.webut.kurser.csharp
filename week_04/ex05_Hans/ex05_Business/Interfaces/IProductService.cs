using ex05_Business.Dtos;
using ex05_Business.Models;

namespace ex05_Business.Interfaces;

public interface IProductService
{
    void AddProduct(ProductDto dto);
    Product GetProductById(int id);
    IEnumerable<Product> GetAllProducts();
}