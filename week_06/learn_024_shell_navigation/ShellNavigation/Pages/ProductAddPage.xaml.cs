using ShellNavigation.ViewModels;

namespace ShellNavigation.Pages;

public partial class ProductAddPage : ContentPage
{
	public ProductAddPage(ProductAddViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}