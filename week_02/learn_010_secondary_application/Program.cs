using Infrastructure.Factories;
using Infrastructure.Services;

var userService = new UserService();

var user = UserFactory.Create();

user.FirstName = "Slisk";
user.LastName = "Lindqvist";
user.Email = "slisk.lindqvist@querzion.com";

userService.Add(user);