namespace NavigationPageNavigation.Pages;

public partial class ProductListPage : ContentPage
{
    private readonly IServiceProvider _serviceProvider;

    public ProductListPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    private async void Btn_Add_Clicked(object sender, EventArgs e)
    {
        var productAddPage = _serviceProvider.GetRequiredService<ProductAddPage>();
        await Navigation.PushAsync(productAddPage);
    }
}