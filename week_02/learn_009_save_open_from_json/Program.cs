using learn_009_save_open_from_json.Services;

var url = "https://youtu.be/nsP7EYOiHHA";
Console.WriteLine("Video link " + url);
Console.ReadKey();

var menuService = new MenuService();

while (true)
{
    menuService.ViewAllUsersDialog();
    menuService.CreateUserDialog();
}