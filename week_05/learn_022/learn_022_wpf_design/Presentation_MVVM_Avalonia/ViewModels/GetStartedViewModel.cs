using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation_MVVM_Avalonia.ViewModels;

public partial class GetStartedViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;

    public GetStartedViewModel(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    [RelayCommand]
    public void GetStarted()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<AddItemsViewModel>();
    }
}