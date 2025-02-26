using Avalonia.Controls;
using Avalonia.Interactivity;
using Business.Models;

namespace Presentation_Avalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddActivity_Click(object? sender, RoutedEventArgs e)
    {
        var activityItem = new ActivityItem()
        {
            Activity = Activity.Text
        };
        
        Activities.Items.Add(activityItem);
        Activity.Clear();
    }

    private void ChangeStatus_OnClick(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            if (button.DataContext is ActivityItem activityItem)
            {
                activityItem.IsCompleted = true;
            }
        }
    }
}