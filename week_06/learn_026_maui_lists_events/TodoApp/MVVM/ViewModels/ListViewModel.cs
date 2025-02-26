using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TodoApp.MVVM.Models;
using TodoApp.Services;

namespace TodoApp.MVVM.ViewModels;

public partial class ListViewModel : ObservableObject
{
    private readonly TodoService _todoService;

    public ListViewModel(TodoService todoService)
    {
        _todoService = todoService;

        _todoService.TodoItemsUpdated += (sender, e) =>
        {
            TodoItems = new ObservableCollection<TodoItem>(_todoService.GetAll());
        };
    }

    [ObservableProperty]
    private ObservableCollection<TodoItem> todoItems = [];

    [RelayCommand]
    private async Task NavigateToAdd(TodoItem item)
    {
        await Shell.Current.GoToAsync("AddView");
    }

    [RelayCommand]
    private async Task NavigateToEdit(TodoItem item)
    {
        var parameters = new ShellNavigationQueryParameters
        {
            {"Todo", item}
        };

        await Shell.Current.GoToAsync("EditView", parameters);
    }

    [RelayCommand]
    private void Remove(TodoItem item)
    {
        _todoService.Remove(item);

        TodoItems = new ObservableCollection<TodoItem>(_todoService.GetAll());
    }
}
