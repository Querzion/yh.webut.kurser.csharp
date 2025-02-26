using ShellNavigation.ViewModels;

namespace ShellNavigation.Pages;

public partial class ProductListPage : ContentPage
{
	public ProductListPage(ProductListViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private async void Btn_NavigateToAddNewProduct_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("ProductAddPage");
    }
}