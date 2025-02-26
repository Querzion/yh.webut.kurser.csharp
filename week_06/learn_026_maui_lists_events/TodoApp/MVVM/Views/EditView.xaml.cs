using TodoApp.MVVM.ViewModels;

namespace TodoApp.MVVM.Views;

public partial class EditView : ContentPage
{
	public EditView(EditViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}