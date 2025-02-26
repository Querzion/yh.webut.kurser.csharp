using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation_MVVM_Avalonia.ViewModels;
using Presentation_MVVM_Avalonia.Views;

namespace Presentation_MVVM_Avalonia;

public partial class App : Application
{
    private readonly IHost? _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<MainViewModel>();
                services.AddSingleton<MainWindow>();

                services.AddTransient<GetStartedViewModel>();
                services.AddTransient<GetStartedView>();
                services.AddTransient<AddItemsViewModel>();
                services.AddTransient<AddItemView>();
                services.AddTransient<ListItemsViewModel>();
                services.AddTransient<ListItemsView>();
            })
            .Build();
        
    }


    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // var mainViewModel = _host.Services.GetRequiredService<MainViewModel>();
            // mainViewModel.CurrentViewModel = _host.Services.GetRequiredService<GetStartedViewModel>();
            //
            // var mainWindow = _host.Services.GetRequiredService<MainWindow>();
            // mainWindow.DataContext = mainViewModel;
            //
            // desktop.MainWindow = mainWindow;
            
            var mainWindow = _host!.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        base.OnFrameworkInitializationCompleted();
    }
}