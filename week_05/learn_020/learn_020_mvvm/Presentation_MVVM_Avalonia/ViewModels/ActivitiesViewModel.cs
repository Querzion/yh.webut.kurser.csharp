using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation_MVVM_Avalonia.ViewModels;

public partial class ActivitiesViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    
    [ObservableProperty] 
    private string _title = "Activities";

    [RelayCommand]
    private void GoToAddActivity()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<AddActivityViewModel>();
    }
    
    public ActivitiesViewModel(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
}