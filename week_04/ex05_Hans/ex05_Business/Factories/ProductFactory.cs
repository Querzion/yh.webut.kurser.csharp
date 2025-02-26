using ex05_Business.Dtos;
using ex05_Business.Interfaces;
using ex05_Business.Models;

namespace ex05_Business.Factories;

public class ProductFactory :IProductFactory
{
    public Product Create(ProductDto dto) => new()
    {
        Id = dto.Id,
        Name = dto.Name,
        Price = (double)dto.Price,
    };
}