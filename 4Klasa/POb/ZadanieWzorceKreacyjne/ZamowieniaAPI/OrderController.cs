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
    public async Task<ActionResult<IEnumerable<OrderDTO>>> GetOrders()
    {
        return await Context.Orders.ToListAsync();
    }

    [HttpPost("add")]
    public async Task<ActionResult<OrderDTO>> PostOrder(OrderDTO orderDto)
    {
        OrderDTO newOrderDto = new OrderDTO
        {
            Burgers = orderDto.Burgers,
            Fries = orderDto.Fries,
            Drinks = orderDto.Drinks
        };

        await Context.Orders.AddAsync(newOrderDto);
        await Context.SaveChangesAsync();

        return newOrderDto;
    }
}