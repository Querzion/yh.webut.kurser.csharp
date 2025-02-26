using learn_017_Business.Models;

namespace learn_017_Business.Interfaces;

public interface IProductItemService
{
    IEnumerable<Product> GetAllProductItems();
}