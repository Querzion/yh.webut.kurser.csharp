
using learn_011_interfaces.Interfaces;
using learn_011_interfaces.Models;
using learn_011_interfaces.Services;

/*
    Man använder ett interface för att begränsa tillgången till metoder. 
    Det som läggs till i en interface fil, är det som sedan kommer kunna användas om det är länkat med en specifik klass, 
    förslagsvis en med samma namn för enkelhetens skull.
*/

IUserService userService = new UserService();

var user = new User();
userService.CreateUser(user);