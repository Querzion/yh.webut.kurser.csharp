using learn_017_Business.Models;

namespace learn_017_Business.Interfaces;

public interface IArticleService : IProductItemService, IServiceItemService
{
    bool CreateItem(ItemRegistrationForm itemRegistrationForm);
    IEnumerable<Product> GetAllItems();
}