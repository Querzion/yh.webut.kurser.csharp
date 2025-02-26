using learn_013_test_driven_development_xunit.Dtos;
using learn_013_test_driven_development_xunit.Models;
using learn_013_test_driven_development_xunit.Services;

namespace learn_013_test_driven_development_xunit_tests.Services;

public class ProductServicesTests
{
    private readonly ProductService _productService = new();
    
    // [Fact]
    // public void SetNewId_ShouldReturnInt()
    // {
    //     // Arrange
    //     ProductService productService = new();
    //     
    //     // Act
    //     int result = productService.SetNewId();
    //
    //     // Assert
    //     Assert.Equal(1, result);
    // }
    
    [Fact]
    public void SetNewId_ShouldReturn1AsId_IfNoProductExists()
    {
        // Act
        int result = _productService.SetNewId();

        // Assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void SetNewId_ShouldReturn2AsId_IfOneProductExists()
    {
        // Arrange
        var product = new Product { Id = 1, Title = "Test", Price = 100 };
        _productService.AddProductToList(product);
        
        // Act
        int result = _productService.SetNewId();

        // Assert
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void AddProductToList_ShouldReturnTrue_WhenProductIsAddedToProductsList()
    {
        // Arrange
        var product = new Product { Id = 1, Title = "Test", Price = 100 };
        
        // Act
        bool result = _productService.AddProductToList(product);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CreateNewProduct_ShouldReturnTrue_WhenProductIsCreatedSuccessfully()
    {
        // Arrange
        var productRegistrationForm = new ProductRegistrationForm { Id = 1, Title = "Test", Price = 100 };
        // Act
        var result = _productService.CreateNewProduct(productRegistrationForm);

        // Assert
        Assert.True(result);

    }
}
