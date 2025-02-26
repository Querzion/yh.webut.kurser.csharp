using MauiWithMvvm.ViewModels;

namespace MauiWithMvvm
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
