using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation_MVVM_Avalonia.ViewModels;

public partial class AddActivityViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    
    [ObservableProperty]
    private string _title = "Add New Activity";

    [RelayCommand]
    private void GoToActivities()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<ActivitiesViewModel>();
    }
    
    
    public AddActivityViewModel(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
}