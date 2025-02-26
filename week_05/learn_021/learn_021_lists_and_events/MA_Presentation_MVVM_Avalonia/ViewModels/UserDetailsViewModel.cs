using System;
using Business.Interfaces;
using Business.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace MA_Presentation_MVVM_Avalonia.ViewModels;

public partial class UserDetailsViewModel(IServiceProvider serviceProvider) : ObservableObject
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;
    
    [ObservableProperty] 
    private User _user = new();

    [RelayCommand]
    private void GoToEditView()
    {
        var userEditViewModel = _serviceProvider.GetRequiredService<UserEditViewModel>();
        userEditViewModel.User = User;
        
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = userEditViewModel;
        
    }
    
    [RelayCommand]
    private void Cancel()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<UserListViewModel>();
    }
}