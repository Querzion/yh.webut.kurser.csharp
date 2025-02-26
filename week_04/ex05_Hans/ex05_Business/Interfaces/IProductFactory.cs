using ex05_Business.Dtos;
using ex05_Business.Models;

namespace ex05_Business.Interfaces;

public interface IProductFactory
{
    Product Create(ProductDto dto);
}