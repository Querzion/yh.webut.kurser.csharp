using Data.Contexts;
using Data.Entities;

namespace Business.Services;

public interface IOrderService
{
    void CreateOrder(String userId, List<ProductEntity> products);
    IEnumerable<OrderEntity> GetAllOrders();
    OrderEntity GetOrder(int id);
}

public class OrderService(
    DataContext context, 
    UserService userService
    ) : IOrderService
{
    private readonly DataContext _context = context;
    private readonly UserService _userService = userService;
    

    public void CreateOrder(String userId, List<ProductEntity> products)
    {
        var user = _userService.GetUser(userId);

        var orderEntity = new OrderEntity
        {
            CustomerName = $"{user.FirstName} {user.LastName}",
            OrderDate = DateTime.Now,
            DueDate = DateTime.Now.AddDays(30)
        };
        
        _context.Orders.Add(orderEntity);
        _context.SaveChanges();
    }

    public IEnumerable<OrderEntity> GetAllOrders()
    {
        var orders = _context.Orders;
        return orders;
    }

    public OrderEntity GetOrder(int id)
    {
        var order = _context.Orders.Find(id);
        // var order = _context.Orders.Find(id);
        return order;
    }
}