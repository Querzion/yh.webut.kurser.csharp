using Avalonia.Controls;
using Presentation_MVVM_Avalonia.ViewModels;

namespace Presentation_MVVM_Avalonia;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}