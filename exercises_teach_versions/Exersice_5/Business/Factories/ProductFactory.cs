using Business.Dtos;
using Business.Interfaces;
using Business.Models;

namespace Business.Factories;

public class ProductFactory : IProductFactory
{
    public Product Create(ProductDto dto) => new()
    {
        Id = dto.Id,
        Name = dto.Name,
        Price = dto.Price
    };
}
