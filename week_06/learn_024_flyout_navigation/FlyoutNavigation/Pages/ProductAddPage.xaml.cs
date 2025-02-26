using FlyoutNavigation.ViewModels;

namespace FlyoutNavigation.Pages;

public partial class ProductAddPage : ContentPage
{
	public ProductAddPage(ProductAddViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}