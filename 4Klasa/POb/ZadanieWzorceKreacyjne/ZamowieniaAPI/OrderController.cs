using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ZamowieniaAPI;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderContext Context;

    public OrderController(OrderContext context)
    {
        Context = context;
        Context.Database.EnsureCreated();
    }

    [HttpGet("getAll")]
    public JsonResult GetOrders()
    {
        return new JsonResult(Context.Orders
            .Include(o => o.Burgers)
            .Include(o => o.Fries)
            .Include(o => o.Drinks)
            .ToList());
    }

    [HttpPost("add")]
    public JsonResult PostOrder(Order order)
    {
        Context.Orders.Add(order);
        Context.SaveChanges();

        return new JsonResult(order);
    }
}