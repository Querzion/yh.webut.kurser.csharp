using TodoApp.MVVM.ViewModels;

namespace TodoApp.MVVM.Views;

public partial class ListView : ContentPage
{
	public ListView(ListViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}