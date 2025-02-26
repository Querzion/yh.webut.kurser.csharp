using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Business.Interfaces;
using Business.Repositories;
using Business.Services;
using MA_Presentation_MVVM_Avalonia.ViewModels;
using MA_Presentation_MVVM_Avalonia.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MA_Presentation_MVVM_Avalonia;

public partial class App : Application
{
    private readonly IHost _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // Register file and user-related services
                services.AddSingleton<IUserFileService>(new UserFileService(AppDomain.CurrentDomain.BaseDirectory, "users.json"));
                // services.AddSingleton<IUserFileService>(new UserFileService("Data", "users.json"));
                services.AddSingleton<IUserRepository, UserRepository>();
                services.AddSingleton<IUserService, UserService>();
                // services.AddSingleton<IServiceProvider>(_ => _host.Services);

                // Register view models
                services.AddTransient<UserListViewModel>();
                services.AddTransient<UserAddViewModel>();
                services.AddTransient<UserDetailsViewModel>();
                services.AddTransient<UserEditViewModel>();
                
                // Register views
                services.AddTransient<UserListView>();
                services.AddTransient<UserAddView>();
                services.AddTransient<UserDetailsView>();
                services.AddTransient<UserEditView>();
                
                // Register main view model and window
                services.AddSingleton<MainViewModel>();
                services.AddSingleton<MainWindow>();

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
            try
            {
                var mainViewModel = _host.Services.GetRequiredService<MainViewModel>();
                mainViewModel.CurrentViewModel = _host.Services.GetRequiredService<UserListViewModel>();

                var mainWindow = _host.Services.GetRequiredService<MainWindow>();
                mainWindow.DataContext = mainViewModel;
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing application: {ex.Message}");
            }
        }

        base.OnFrameworkInitializationCompleted();
    }
}