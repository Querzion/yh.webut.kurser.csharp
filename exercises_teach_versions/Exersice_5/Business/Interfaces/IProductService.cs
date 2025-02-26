using Business.Dtos;
using Business.Models;

namespace Business.Interfaces;

public interface IProductService
{
    void AddProduct(ProductDto dto);
    Product GetProductById(int id);
    IEnumerable<Product> GetAllProducts();
}
