using Business.Factories;
using Business.Interfaces;
using Business.Services;
using MainApp.Dialogs;

IProductFactory productFactory = new ProductFactory();
IProductService productService = new ProductService(productFactory);
var menuDialogs = new MenuDialogs(productService);

menuDialogs.CreateMenu();