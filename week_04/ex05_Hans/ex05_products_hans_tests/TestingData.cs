using ex05_Business.Dtos;
using ex05_Business.Models;

namespace ex05_products_hans_tests;

public class TestingData
{
    public static List<ProductDto> Dtos { get; set; } = new List<ProductDto>
    {
        new ProductDto(1, "Test Product 1", 100m),
        new ProductDto(2, "Test Product 2", 200m),
        new ProductDto(3, "Test Product 3", 300m)
    };

    public static List<Product> Products { get; set; } = new List<Product>
    {
        new Product { Id = 1, Name = "Test Product 1", Price = 100 },
        new Product { Id = 2, Name = "Test Product 2", Price = 200 },
        new Product { Id = 3, Name = "Test Product 3", Price = 300 }
    };
}