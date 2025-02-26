using learn_013_test_driven_development_xunit.Dtos;
using learn_013_test_driven_development_xunit.Factories;
using learn_013_test_driven_development_xunit.Models;

namespace learn_013_test_driven_development_xunit_tests.Factories;

public class ProductFactoryTests
{
    [Fact]
    public void Create_ShouldReturnProductRegistrationForm()
    {
        // Arrange - Förberedelser
        
        
        // Act - Själva utförandet
        ProductRegistrationForm result = ProductFactory.Create();
        
        // Assert - Test förfarande (Förväntat resultat)
        Assert.IsType<ProductRegistrationForm>(result);
        
    }

    [Fact]
    public void Create_ShouldReturnProduct_WhenProductRegistrationFormIsSupplied()
    {
        // Arrange
        ProductRegistrationForm productRegistrationForm = new() { Title = "", Price = 100m };
        
        // Act
        Product result = ProductFactory.Create(productRegistrationForm);
        
        // Assert
        Assert.IsType<Product>(result);
        Assert.Equal(productRegistrationForm.Title, result.Title);
        Assert.Equal(productRegistrationForm.Price, result.Price);
    
    }
    
    [Theory]
    [InlineData("", 0)]
    [InlineData("", 100)]
    [InlineData("Test Product", 0)]
    [InlineData("Test Product", 100)]
    public void Create_ShouldReturnProduct_WhenProductRegistrationFormIsSupplied2(string title, decimal price)
    {
        // Arrange
        ProductRegistrationForm productRegistrationForm = new() { Title = title, Price = price };
        
        // Act
        Product result = ProductFactory.Create(productRegistrationForm);
        
        // Assert
        Assert.IsType<Product>(result);
        Assert.Equal(productRegistrationForm.Title, result.Title);
        Assert.Equal(productRegistrationForm.Price, result.Price);

    }
}