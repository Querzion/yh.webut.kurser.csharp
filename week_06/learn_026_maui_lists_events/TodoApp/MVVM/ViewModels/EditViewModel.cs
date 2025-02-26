using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TodoApp.MVVM.Models;
using TodoApp.Services;

namespace TodoApp.MVVM.ViewModels;

// https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0

public partial class EditViewModel : ObservableObject, IQueryAttributable
{
    private readonly TodoService _todoService;

    public EditViewModel(TodoService todoService)
    {
        _todoService = todoService;
    }

    [ObservableProperty]
    private TodoItem item = new();

    [RelayCommand]
    private async Task Update()
    {
        _todoService.Update(Item);
        Item = new();

        await Shell.Current.GoToAsync("..");
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Item = (query["Todo"] as TodoItem)!;
    }
}
