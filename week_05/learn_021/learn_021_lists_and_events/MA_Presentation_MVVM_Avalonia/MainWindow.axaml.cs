using Avalonia.Controls;
using MA_Presentation_MVVM_Avalonia.ViewModels;

namespace MA_Presentation_MVVM_Avalonia;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}