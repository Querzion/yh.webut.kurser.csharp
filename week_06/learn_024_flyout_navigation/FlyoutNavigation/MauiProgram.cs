using FlyoutNavigation.Pages;
using FlyoutNavigation.ViewModels;
using Microsoft.Extensions.Logging;

namespace FlyoutNavigation
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

            builder.Services.AddTransient<ProductAddViewModel>();
            builder.Services.AddTransient<ProductListViewModel>();
            builder.Services.AddTransient<ProductListPage>();
            builder.Services.AddTransient<ProductAddPage>();

            return builder.Build();
        }
    }
}
