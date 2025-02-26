using System.Diagnostics;
using learn_017_Business.Models;

namespace learn_017_Business.Factories;

public static class ProductFactory
{
    public static ProductRegistrationForm CreateProduct()
    {
        return new ProductRegistrationForm();
    }

    public static ServiceRegistrationForm CreateService()
    {
        return new ServiceRegistrationForm();
    }

    public static ProductEntity Create(ItemRegistrationForm registrationForm)
    {
        try
        {
            if (registrationForm is ServiceRegistrationForm serviceForm)
            {
                return new ProductEntity
                {
                    Title = serviceForm.Title,
                    Description = serviceForm.Description,
                    Price = serviceForm.Price,
                    IsEnabled = true,
                    IsService = serviceForm.IsService()
                };
            }
            else if (registrationForm is ProductRegistrationForm productForm)
            {
                return new ProductEntity
                {
                    ArticleNumber = productForm.ArticleNumber,
                    Title = productForm.Title,
                    Description = productForm.Description,
                    Price = productForm.Price,
                    IsEnabled = true,
                    IsService = productForm.IsService()
                };
            }
            
            return null!;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null!;
        }
    }

    public static Product Create(ProductEntity entity)
    {
        return new Product
        {
            Id = entity.Id,
            ArticleNumber = entity.ArticleNumber,
            Title = entity.Title,
            Description = entity.Description,
            Price = entity.Price,
            IsService = entity.IsService
        };
    }
}