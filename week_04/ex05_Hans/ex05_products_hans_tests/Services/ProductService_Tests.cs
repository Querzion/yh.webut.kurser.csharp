
using System.Reflection.Metadata;
using ex05_Business.Dtos;
using ex05_Business.Interfaces;
using ex05_Business.Models;
using ex05_Business.Services;
using Moq;

namespace ex05_products_hans_tests.Services;

public class ProductService_Tests
{
    private readonly Mock<IProductFactory> _productFactoryMock;
    private readonly IProductService _productService;

    public ProductService_Tests()
    {
        _productFactoryMock = new Mock<IProductFactory>();
        _productService = new ProductService(_productFactoryMock.Object);
    }

    [Fact]
    public void AddProduct_ShouldAddProductToList()
    {
        // Arrange
        var dto = new ProductDto(1, "Test Product", 100m);
        var expectedProduct = new Product { Id = 1, Name = "Test Product", Price = 100m };

        _productFactoryMock.Setup(_productService => _productService.Create(dto)).Returns(expectedProduct);
        
        // Act
        _productService.AddProduct(dto);
        
        // Assert
        var products = _productService.GetAllProducts();
        Assert.Single(products);
        Assert.Equal(dto.Name, products.First().Name);
        _productFactoryMock.Verify(pf => pf.Create(dto), Times.Once);
    }

    [Fact]
    public void GetAllProducts_ShouldReturnListOfAllProducts()
    {
        _productFactoryMock.Setup(pf => pf.Create(TestingData.Dtos[0])).Returns(TestingData.Dtos[0]);
        _productFactoryMock.Setup(pf => pf.Create(TestingData.Dtos[1])).Returns(TestingData.Dtos[1]);
        
        _productService.AddProduct(TestingData.Dtos[0]);
        _productService.AddProduct(TestingData.Dtos[1]);
        
        var result = _productService.GetAllProducts();
        
        Assert.Equal(2, result.Count());
    }

    [Fact]
    public void GetProductById_ShouldReturnCorrectProduct()
    {
        _productService.AddProduct(TestingData.Dtos[0]);
        
        var result = _productService.GetProductById(1);
        
        Assert.NotNull(result);
        Assert.Equal(1, result.Id);
    }

    [Fact]
    public void GetProductById_ShouldThrowKeyNotFoundException_IfNotFound()
    {
        Assert.Throws<KeyNotFoundException>(() => _productService.GetProductById(1));
    }
}
