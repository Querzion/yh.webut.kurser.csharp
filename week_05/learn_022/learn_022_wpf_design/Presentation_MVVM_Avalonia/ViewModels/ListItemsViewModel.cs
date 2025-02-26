using CommunityToolkit.Mvvm.ComponentModel;

namespace Presentation_MVVM_Avalonia.ViewModels;

public partial class ListItemsViewModel : ObservableObject
{
    [ObservableProperty] 
    private string headline = "YOUR ACTIVITIES";
}