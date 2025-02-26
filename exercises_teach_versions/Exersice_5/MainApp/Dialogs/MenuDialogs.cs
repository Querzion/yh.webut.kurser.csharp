using Business.Dtos;
using Business.Interfaces;

namespace MainApp.Dialogs;

public class MenuDialogs
{
    private readonly IProductService _productService;

    public MenuDialogs(IProductService productService)
    {
        _productService = productService;
    }

    public bool CreateMenu()
    {
        Console.WriteLine("MENU");
        Console.Write("Enter Product Id: ");
        int.TryParse(Console.ReadLine()!, out int id);
        Console.Write("Enter Product Name: ");
        var name = Console.ReadLine()!;
        Console.Write("Enter Product Price: ");
        decimal.TryParse(Console.ReadLine()!, out decimal price);

        var dto = new ProductDto(id, name, price);
        _productService.AddProduct(dto);
        return true;
    }
}
