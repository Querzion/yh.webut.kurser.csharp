using learn_015_Business.Models;
using learn_015_Data.Data;

namespace learn_015_Business.Services;

public class ProductService(DataContext<Product> context)
{
    private readonly DataContext<Product> _context = context;

    public ResponseResult<Product> SaveProduct(Product product)
    {
        // Check if the same product name is already in use before adding.
        try
        {
            // If the item doesn't exist "_context.Add(product);"
            if (_context.Items().All(x => x.Title != product.Title))
            {
                // Count product id as long as the count is not 0 take the last id and add +1 otherwise set it as 1.
                // product.Id = _context.Items().Count() != 0 ? _context.Items().Last().Id + 1 : 1;
                // If the source is null/empty give it id 1, otherwise take the last id and add +1
                product.Id = _context.Items().Any() ? _context.Items().Last().Id + 1 : 1;
                _context.Save(product);
                return new ResponseResult<Product>
                {
                    Success = true,
                    Message = "Product has been saved."
                };
            }
            else
            {
                return new ResponseResult<Product>
                {
                    Success = false,
                    Message = "A product with the same name already exists!"
                };
            }
        }
        catch (Exception ex)
        {
            return new ResponseResult<Product>
            {
                Success = false,
                Message = $"Something went wrong! {ex.Message}"
            };
        }
    }

    // public IEnumerable<Product> GetAllProducts()
    // {
    //     return _context.Items();
    // }
    
    public ResponseResult<IEnumerable<Product>> GetAllProducts()
    {
        try
        {
            return new ResponseResult<IEnumerable<Product>>
            {
                Success = true,
                // Result = _context.Items().ToList(),
                Result = _context.Items()
            };

        }
        catch (Exception e)
        {
            return new ResponseResult<IEnumerable<Product>>
            {
                Success = false,
                Message = $"Something went wrong: {e.Message}"
            };
        }
    }
}