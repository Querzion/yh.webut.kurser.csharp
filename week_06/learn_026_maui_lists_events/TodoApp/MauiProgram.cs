using Microsoft.Extensions.Logging;
using TodoApp.MVVM.ViewModels;
using TodoApp.MVVM.Views;
using TodoApp.Services;
using ListView = TodoApp.MVVM.Views.ListView;

namespace TodoApp
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

            builder.Services.AddSingleton<TodoService>();

            builder.Services.AddSingleton<ListViewModel>();
            builder.Services.AddSingleton<ListView>(); 

            builder.Services.AddSingleton<AddViewModel>();
            builder.Services.AddSingleton<AddView>(); 

            builder.Services.AddSingleton<EditViewModel>();
            builder.Services.AddSingleton<EditView>();

            builder.Logging.AddDebug();
            return builder.Build();
        }
    }
}
