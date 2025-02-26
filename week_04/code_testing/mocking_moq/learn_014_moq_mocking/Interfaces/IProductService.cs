using learn_014_moq_mocking.Models;

namespace learn_014_moq_mocking.Interfaces;

public interface IProductService
{
    bool CreateProduct(ProductRegistrationForm form);
    
    IEnumerable<Product> GetProducts();
}