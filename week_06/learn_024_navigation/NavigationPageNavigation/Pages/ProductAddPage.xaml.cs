using Shared.Services;

namespace NavigationPageNavigation.Pages;

public partial class ProductAddPage : ContentPage
{
	private readonly ProductService _productService;

    public ProductAddPage(ProductService productService)
    {
        InitializeComponent();
        _productService = productService;
    }
}