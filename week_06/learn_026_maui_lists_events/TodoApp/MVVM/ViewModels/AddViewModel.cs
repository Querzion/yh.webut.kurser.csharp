using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TodoApp.MVVM.Models;
using TodoApp.Services;

namespace TodoApp.MVVM.ViewModels;

public partial class AddViewModel : ObservableObject
{
    private readonly TodoService _todoService;

    public AddViewModel(TodoService todoService)
    {
        _todoService = todoService;
    }

    [ObservableProperty]
    private TodoItem item = new();

    [RelayCommand]
    private async Task Add()
    {
        _todoService.Add(Item);
        Item = new();

        await Shell.Current.GoToAsync("//ListView");
    }
}
