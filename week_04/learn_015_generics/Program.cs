using learn_015_Data.Data;
using learn_015_Business.Models;
using learn_015_Business.Services;
using learn_015_generics.Dialogs;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<DataContext<Product>>()
    .AddSingleton<DataContext<User>>()
    .AddScoped<ProductService>()
    .AddScoped<UserService>()
    .AddTransient<MenuDialogs>()
    .BuildServiceProvider();

var menuDialog = serviceProvider.GetRequiredService<MenuDialogs>();

menuDialog.ShowMenu();
    
    