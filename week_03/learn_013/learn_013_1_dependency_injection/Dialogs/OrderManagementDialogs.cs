using static System.Console;
using Business.Services;

namespace learn_013_1_dependency_injection.Dialogs;

public interface IOrderManagementDialogs
{
    void ShowMenuOptions();
}

public class OrderManagementDialogs(IOrderService orderService) : IOrderManagementDialogs
{
    private readonly IOrderService _orderService = orderService;

    public void ShowMenuOptions()
    {
        Clear();
        WriteLine("************** ORDER MANAGEMENT *************");
        WriteLine("1. Create New Order");
        WriteLine("2. View All Orders");
        WriteLine("3. View Order");
        WriteLine("*********************************************");
        Write("Select an option: ");
        var option = ReadLine();

        switch (option)
        {
            case "1":
                // _orderService.CreateOrder();
                break;
            case "2":
                _orderService.GetAllOrders().ToList();
                break;
            case "3":
                // _orderService.GetOrder();
                break;
            default:
                WriteLine("Invalid option");
                break;
        }
    }
}