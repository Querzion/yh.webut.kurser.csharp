using Microsoft.Extensions.Logging;
using ShellNavigation.Pages;
using ShellNavigation.ViewModels;

namespace ShellNavigation
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ProductAddPage>();
            builder.Services.AddSingleton<ProductListPage>();
            builder.Services.AddSingleton<ProductListViewModel>();
            builder.Services.AddSingleton<ProductAddViewModel>();

            return builder.Build();
        }
    }
}
