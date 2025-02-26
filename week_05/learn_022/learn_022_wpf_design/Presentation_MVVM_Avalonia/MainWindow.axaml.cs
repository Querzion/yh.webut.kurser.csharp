using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Presentation_MVVM_Avalonia.ViewModels;

namespace Presentation_MVVM_Avalonia;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        
        // Remove the window border and title bar
        // this.WindowStyle = Avalonia.Controls.WindowStyle.None;
        // this.WindowBorderStyle = Avalonia.Controls.WindowBorderStyle.None;

        // Set the background to transparent
        // this.Background = Avalonia.Media.Brushes.Transparent;
        
        // If you want to allow transparent regions and drag behavior, set the following:
        // this.ExtendClientAreaToDecorationsHint = true;
        
        // Optionally, make the window draggable by clicking on any part of the content
        // this.CanResize = false;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void TopBar_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        // Start dragging the window
        if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
        {
            this.BeginMoveDrag(e);
        }
    }

    private void ExitButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Environment.Exit(0);
    }
}