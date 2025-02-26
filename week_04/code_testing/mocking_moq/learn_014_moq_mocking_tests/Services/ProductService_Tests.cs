using learn_014_moq_mocking.Interfaces;
using learn_014_moq_mocking.Models;
using learn_014_moq_mocking.Services;
using Moq;

namespace learn_014_moq_mocking_tests.Services;

public class ProductServiceTests
{
    // Part One
    // // Instansiering
    // private readonly Mock<IProductService> _productServiceMock;
    // // private readonly IProductService _productService;
    // private readonly ProductService _productService;
    //
    // public ProductServiceTests()
    // {
    //     _productServiceMock = new Mock<IProductService>();
    //     // _productService = _productServiceMock.Object;
    //     _productService = new ProductService();
    // }
    //
    // // Test
    // [Fact]
    // public void CreateProduct_ShouldReturnTrue_WhenProductIsCreated()
    // {
    //     // Arrange
    //     var productRegistrationForm = new ProductRegistrationForm { Title = "Test Product", Price = 100 };
    //     _productServiceMock
    //         .Setup(x => x.CreateProduct(productRegistrationForm))
    //         .Returns(true);
    //     
    //     // Act
    //     // var result = _productService.CreateProduct(productRegistrationForm);
    //     var result = _productServiceMock.Object.CreateProduct(productRegistrationForm);
    //     
    //     // Assert
    //     Assert.True(result);
    //     _productServiceMock.Verify(x => x.CreateProduct(productRegistrationForm), Times.Once);
    // }
    //
    // [Fact]
    // public void GetProducts_ShouldReturnListOfProducts()
    // {
    //     // Arrange
    //     var products = new List<Product>()
    //     {
    //         new() { Id = 1, Title = "Test Product 1", Price = 100 },
    //         new() { Id = 2, Title = "Test Product 2", Price = 200 }
    //     };
    //     
    //     _productServiceMock
    //         .Setup(ps => ps.GetProducts())
    //         .Returns(products);
    //     
    //     // Act 
    //     // var result = _productService.GetProducts();
    //     var result = _productServiceMock.Object.GetProducts();
    //     
    //     // Assert
    //     Assert.NotNull(result);
    //     // Assert.Single(result);
    //     Assert.Equal(2, result.Count());
    //     Assert.Equal("Test Product 1", result.First().Title);
    //     
    // }
    //
    // [Fact]
    // public void AddProductToList_ShouldReturnTrue_AndListCountOfOne()
    // {
    //     // Arrange
    //     Product product = new() { Id = 1, Title = "Test Product 1", Price = 100 };
    //     
    //     // Act 
    //     var result = _productService.AddProductToList(product);
    //     
    //     // Assert
    //     Assert.NotNull(result);
    //     Assert.Equal(1, _productService.GetProducts().Count());
    // }
    
    // Part Two
    private readonly Mock<IFileService> _fileServiceMock;
    private readonly IProductService _productService;

    public ProductServiceTests()
    {
        _fileServiceMock = new Mock<IFileService>();
        _productService = new ProductService(_fileServiceMock.Object);
    }

    [Fact]
    public void CreateProduct_ShouldAddProductToList_AndSaveToFile()
    {
        // Arrange
        var productRegistrationForm = new ProductRegistrationForm();
        _fileServiceMock
            .Setup(fs => fs.SaveContentToFile(It.IsAny<string>()))  // Här adderas innehållet, vilket "It.IsAny<string>()" skapar, typ en lorem ipsum.
            .Returns(true);
        
        // Act
        var result = _productService.CreateProduct(productRegistrationForm);

        // Assert
        Assert.True(result);
        _fileServiceMock.Verify(fs => fs.SaveContentToFile(It.IsAny<string>()), Times.Once());
    }
}