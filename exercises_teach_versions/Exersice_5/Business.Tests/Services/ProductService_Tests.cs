using Business.Dtos;
using Business.Interfaces;
using Business.Models;
using Business.Services;
using Moq;

namespace Business.Tests.Services;

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
		var expected = new Product { Id = 1, Name = "Test Product", Price = 100m };
		_productFactoryMock.Setup(productFactory => productFactory.Create(dto)).Returns(expected);

		// Act
		_productService.AddProduct(dto);


		// Assert
		var products = _productService.GetAllProducts();
		Assert.Single(products);
		Assert.Equal(expected.Name, products.First().Name);
        _productFactoryMock.Verify(pf => pf.Create(dto), Times.Once);
    }

	[Fact]
	public void GetAllProducts_ShouldReturnListOfProducts()
	{
        // Arrange
        _productFactoryMock.Setup(pf => pf.Create(TestingData.Dtos[0])).Returns(TestingData.Products[0]);
        _productFactoryMock.Setup(pf => pf.Create(TestingData.Dtos[1])).Returns(TestingData.Products[1]);

        _productService.AddProduct(TestingData.Dtos[0]);
        _productService.AddProduct(TestingData.Dtos[1]);


        // Act
        var result = _productService.GetAllProducts();

		// Assert
		Assert.Equal(2, result.Count());
	}

	[Fact]	
	public void GetProductById_ShouldReturnCorrectProduct()
	{
		// Arrange
		var expected = TestingData.Products[0];
        _productFactoryMock.Setup(pf => pf.Create(TestingData.Dtos[0])).Returns(TestingData.Products[0]);
        _productService.AddProduct(TestingData.Dtos[0]);

        // Act
        var result = _productService.GetProductById(1);

		// Assert
		Assert.NotNull(result);
		Assert.Equal(expected.Id, result.Id);
	}

	[Fact]
	public void GetProductById_ShouldThrowKeyNotFoundException_IfNotFound()
	{
		// Act & Assert
		Assert.Throws<KeyNotFoundException>(() => _productService.GetProductById(1));
	}

}
