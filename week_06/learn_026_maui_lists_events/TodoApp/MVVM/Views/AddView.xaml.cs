using TodoApp.MVVM.ViewModels;

namespace TodoApp.MVVM.Views;

public partial class AddView : ContentPage
{
	public AddView(AddViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}