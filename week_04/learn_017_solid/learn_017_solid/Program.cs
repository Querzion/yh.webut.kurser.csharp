// SOLID
// S - SINGLE RESPONSIBILITY PRINCIPLE
//     A class/method only has responsibility for one thing.
//     If it's a UserService, then it doesn't handle the ProductServices.

// O - OPEN/CLOSED PRINCIPLE
//     The class has to be open for future expansion through other classes,
//     but closed for modifications.

// L - LISKOV SUBSTITUTION PRINCIPLE
//     The Subclasses should have the capability to take over for the baseclass,
//     without breaking the logic.

// I - INTERFACE SEGREGATION PRINCIPLE
//     Interfaces should be compact & focused.

// D - DEPENDENCY INVERSION PRINCIPLE
//     Prefer Constructor initializations at all times, dependency injection.
//     Focus on Abstractions, such as Interfaces, Abstracts and delegates.

// THE RIGHT WAY = DEPENDENCY INJECTION
// private readonly IFileService _fileService;
// public UserService(IFileService _fileService)
// {
//      _fileService = fileService;
// }

// THE WRONG WAY = NO DEPENDENCY INJECTION
// private readonly FileService _fileService = new FileService();
// private readonly IFileService _fileService = new FileService();

// CRUD - CREATE/READ/UPDATE/DELETE

using learn_017_Business.Interfaces;
using learn_017_Business.Repositories;
using learn_017_Business.Services;
using learn_017_solid.Dialogs;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IUserFileService>(new UserFileService("Data", "users.json"))
    .AddSingleton<IProductFileService>(new ProductFileService("Data", "products.json"))
    .AddSingleton<IUserRepository, UserRepository>()
    .AddSingleton<IArticleRepository, ArticleRepository>()
    .AddSingleton<IUserService, UserService>()
    .AddSingleton<IArticleService, ArticleService>()
    .AddTransient<MenuDialog>()
    .BuildServiceProvider();

var menuDialog = serviceProvider.GetRequiredService<MenuDialog>();
menuDialog.ShowMainMenu();
