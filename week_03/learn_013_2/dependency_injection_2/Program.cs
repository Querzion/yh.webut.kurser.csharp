using dependency_injection_2.Dialogs;
using dependency_injection_2.Interfaces;
using dependency_injection_2.Models;
using dependency_injection_2.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Phase 8 - Create List for injection
// var userService = new UserService();
// Phase 9 - Link/Nest list to method creation, in order to use the same list.
//           If this is not done, then multiple separate lists are going to be created.
// var standardMenuDialogs = new StandardMenuDialogs(userService);
// var adminMenuDialogs = new AdminMenuDialogs(userService);
// The problem with this is instead that it's only good for when it's a small application,
// where you only have to inject the same instance into just a few classes. So Instead!
// Were going to use a whole other way to do this.
// Phase 10 / 8.2 - Host Injection, this is the skeleton structure.
//                  In order to get this to work, a bunch of Nuget Packages has to be installed.
//                  Microsoft.Extensions. + all the mentioned.
//                  Configuration & Configuration.Binder/CommandLine/EnvironmentVariables/FileExtensions/Json/Secrets
//                  DependencyInjection & DependencyInjection.Abstractions
//                  Diagnostics, FileProviders.Physical, Hosting.Abstractions
//                  Logging & Logging.Abstractions/Configurations/Console/Debug/EventLog/EventSource
// IHost host = Host.CreateDefaultBuilder()
//     .ConfigureServices(services =>
//     {
//         
//     })
//     .Build();
// Phase 9.2 - It should now be usable. with
// AddSingleton -   uses the same list and combines the inputs to one shared output, instanced once. 
// AddScoped -      uses the same list and combines the inputs to one shared output, instanced multiple times.
// AddTransient -   uses the same list, but separates the output based on the input, instanced multiple times.
// (If unsure of which to use, use Transient).
// You add the services in order to register their existence, and it's much better than the earlier
// method where you might end up corrupting something along the way if you have to change something.
// Shared Get / Set?
// IHost host = Host.CreateDefaultBuilder()
//     .ConfigureServices(services =>
//     {
//         services.AddSingleton<UserService>();
//         
//         services.AddTransient<StandardMenuDialogs>();
//         services.AddTransient<AdminMenuDialogs>();
//
//     })
//     .Build();
//
// // Phase 10 - Initialize usage of the Host Injection, It's much more text, but you can now share the same services
// //            across multiple initialized services/classes, hundreds or even thousands of them.
// var standardMenuDialogs = host.Services.GetRequiredService<StandardMenuDialogs>();
// var adminMenuDialogs = host.Services.GetRequiredService<AdminMenuDialogs>();

// Phase 11 - Use the interfaces instead, in order to take control of the project.
IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddSingleton(new List<User>());
        
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IStandardMenuDialogs, StandardMenuDialogs>();
        services.AddTransient<IAdminMenuDialogs, AdminMenuDialogs>();

    })
    .Build();

// Phase 16 - Initialize usage of the Host Injection, It's much more text, but you can now share the same services
//            across multiple initialized services/classes, hundreds or even thousands of them.
var standardMenuDialogs = host.Services.GetRequiredService<IStandardMenuDialogs>();
var adminMenuDialogs = host.Services.GetRequiredService<IAdminMenuDialogs>();


standardMenuDialogs.CreateUserOption();
adminMenuDialogs.CreateUserOption();

standardMenuDialogs.ShowAllUsersOption();
adminMenuDialogs.ShowAllUsersOption();