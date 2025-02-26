using Business.Interfaces;
using Business.Repositories;
using Business.Services;
using MA_Presentation_Console.Dialogs;
using MA_Presentation_Console.Interfaces;
using Microsoft.Extensions.DependencyInjection;

    // .AddSingleton<IUserFileService>(new UserFileService(AppDomain.CurrentDomain.BaseDirectory, "users.json"))
var serviceProvider = new ServiceCollection()
    .AddSingleton<IUserFileService>(new UserFileService("Data", "users.json"))
    .AddSingleton<IUserRepository, UserRepository>()
    .AddSingleton<IUserService, UserService>()
    .AddTransient<IMenuDialog, MenuDialog>()
    .BuildServiceProvider();
    
var menuDialog = serviceProvider.GetRequiredService<IMenuDialog>();
menuDialog.ShowMainMenu();