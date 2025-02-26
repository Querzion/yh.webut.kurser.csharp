using static System.Console;
using Business.Services;

namespace learn_013_1_dependency_injection.Dialogs;

public interface IProductManagementDialogs
{
    void ShowMenuOptions();
}

public class ProductManagementDialogs(IProductService productService) : IProductManagementDialogs
{
    private readonly IProductService _productService = productService;
    
    public void ShowMenuOptions()
    {
        WriteLine("************* PRODUCT MANAGEMENT *************");
        WriteLine("1. Create New Product");
        WriteLine("2. View All Products");
        WriteLine("3. View Product");
        WriteLine("*********************************************");
        Write("Select an option: ");
        var option = ReadLine();
        
        switch (option)
        {
            case "1":
                // _productService.CreateProduct();
                break;
            case "2":
                _productService.GetAllProducts().ToList();
                break;
            case "3":
                // _productService.GetProduct();
                break;
            default:
                WriteLine("Invalid option");
                break;
        }
    }
}

