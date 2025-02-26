using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Transformation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation_MVVM_Avalonia.ViewModels;
using Presentation_MVVM_Avalonia.Views;

namespace Presentation_MVVM_Avalonia;

public partial class App : Application
{
    private readonly IHost _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<MainViewModel>();
                services.AddSingleton<MainWindow>();
                
                services.AddTransient<ActivitiesViewModel>();
                services.AddTransient<ActivitiesView>();

                services.AddTransient<AddActivityViewModel>();
                services.AddTransient<AddActivityView>();
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
            var mainViewModel = _host.Services.GetRequiredService<MainViewModel>();
            mainViewModel.CurrentViewModel = _host.Services.GetRequiredService<ActivitiesViewModel>();
            
            var mainWindow = _host.Services.GetRequiredService<MainWindow>();
            mainWindow.DataContext = mainViewModel;
            
            desktop.MainWindow = mainWindow;
        }
    
        base.OnFrameworkInitializationCompleted();
    }
}