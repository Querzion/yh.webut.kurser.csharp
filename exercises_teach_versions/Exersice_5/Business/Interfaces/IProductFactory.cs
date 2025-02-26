using Business.Dtos;
using Business.Models;

namespace Business.Interfaces;

public interface IProductFactory
{
    Product Create(ProductDto dto);
}