using Business.Interfaces;
using Business.Services;
using ex04_Hans.Dialogs;



IFileService fileService = new FileService("Data", "content.json");
IUserService userService = new UserService(fileService);
var menuDialog = new MenuDialog(userService);


menuDialog.ViewAllUsers();

menuDialog.NewRegularUser();
menuDialog.NewAdminUser();

menuDialog.ViewAllUsers();