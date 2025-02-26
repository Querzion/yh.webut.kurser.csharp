using Business.Dtos;
using Business.Models;

namespace Business.Tests;

public static class TestingData
{
    public static List<ProductDto> Dtos { get; set; } = 
    [
        new ProductDto(1, "Test Product 1", 100m),
        new ProductDto(2, "Test Product 2", 100m),
        new ProductDto(3, "Test Product 3", 100m)
    ];

    public static List<Product> Products { get; set; } =
    [
        new Product { Id = 1, Name = "Test Product 1", Price = 100m },
        new Product { Id = 2, Name = "Test Product 2", Price = 100m },
        new Product { Id = 3, Name = "Test Product 3", Price = 100m }
    ];
}
