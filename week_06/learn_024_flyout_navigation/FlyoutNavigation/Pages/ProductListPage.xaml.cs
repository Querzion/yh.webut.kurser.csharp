using FlyoutNavigation.ViewModels;

namespace FlyoutNavigation.Pages;

public partial class ProductListPage : ContentPage
{
	public ProductListPage(ProductListViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}