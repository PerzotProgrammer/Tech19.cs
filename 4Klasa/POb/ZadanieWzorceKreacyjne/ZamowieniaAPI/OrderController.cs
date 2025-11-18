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
    public IActionResult GetOrders()
    {
        return Ok(Context.Orders
            .Include(o => o.Burgers)
            .Include(o => o.Fries)
            .Include(o => o.Drinks)
            .ToList());
    }

    [HttpPost("add")]
    public IActionResult PostOrder(Order order)
    {
        Context.Orders.Add(order);
        Context.SaveChanges();

        return Ok(order);
    }
}