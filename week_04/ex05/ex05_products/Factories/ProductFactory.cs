using ex05_products.Dtos;
using ex05_products.Models;

namespace ex05_products.Factories;

public static class ProductFactory
{
    // public static ProductDto Create()
    // {
    //     return new ProductDto();
    // }
    
    public static Product Create(ProductDto dto)
    {
        return new Product
        {
            Id = dto.Id,
            Name = dto.Name,
            Price = dto.Price
        };
    }
}