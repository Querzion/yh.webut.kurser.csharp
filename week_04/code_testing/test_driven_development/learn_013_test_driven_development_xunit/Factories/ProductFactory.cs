using learn_013_test_driven_development_xunit.Dtos;
using learn_013_test_driven_development_xunit.Models;

namespace learn_013_test_driven_development_xunit.Factories;

public static class ProductFactory
{
    // public static ProductRegistrationForm Create(ProductRegistrationForm productRegistrationForm)
    // {
    //     return new ProductRegistrationForm();
    // }
    public static ProductRegistrationForm Create() => new();

    public static Product Create(ProductRegistrationForm productRegistrationForm) => new()
    {
        Title = productRegistrationForm.Title,
        Price = productRegistrationForm.Price
    };
}