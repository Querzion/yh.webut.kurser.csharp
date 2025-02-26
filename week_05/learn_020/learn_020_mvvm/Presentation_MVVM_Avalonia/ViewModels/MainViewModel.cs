using CommunityToolkit.Mvvm.ComponentModel;

namespace Presentation_MVVM_Avalonia.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableObject _currentViewModel = null!;
}