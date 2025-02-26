using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Presentation_MVVM_Avalonia.Models;

namespace Presentation_MVVM_Avalonia.ViewModels;

public partial class AddItemsViewModel(IServiceProvider serviceProvider) : ObservableObject
{
    private IServiceProvider _serviceProvider = serviceProvider;
    
    [ObservableProperty]
    private string headline = "NEW ACTIVITY";
    
    [ObservableProperty]
    private string warningMessage = "";

    [ObservableProperty] 
    private ActivityItem activityItem = new();

    [RelayCommand]
    public void Add()
    {
        if (!string.IsNullOrEmpty(ActivityItem.Title))
        {
            ActivityItem = new();
            WarningMessage = "";
            var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
            mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<ListItemsViewModel>();
        }
        else
        {
            WarningMessage = "You must enter a title";
        }
    }

    [RelayCommand]
    public void Cancel()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<GetStartedViewModel>();
    }
}