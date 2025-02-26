using learn_013_test_driven_development_xunit.Dtos;
using learn_013_test_driven_development_xunit.Factories;
using learn_013_test_driven_development_xunit.Models;

namespace learn_013_test_driven_development_xunit.Services;

public class ProductService
{
    private List<Product> _products = [];

    public int SetNewId()
    {
        var id = _products.Count != 0 ? _products.Last().Id + 1 : 1;
        return id;
    }

    public bool AddProductToList(Product product)
    {
        try
        {
            _products.Add(product);
            return true;
        }
        catch { return false; }
    }

    public bool CreateNewProduct(ProductRegistrationForm productRegistrationForm)
    {
        try
        {
            var product = ProductFactory.Create(productRegistrationForm);
            product.Id = SetNewId();

            var result = AddProductToList(product);
            return true;
        }
        catch { return false; }
    }
}