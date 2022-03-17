using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using msa_ddd_cqrs.Database;
using msa_ddd_cqrs.Domain.Aggregates.Order;

namespace msa_ddd_cqrs.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersDbContext _ordersDbContext;

        public OrdersController(OrdersDbContext ordersDbContext)
        {
            _ordersDbContext = ordersDbContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _ordersDbContext.Orders.SingleOrDefaultAsync(b => b.Id == id));
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order)
        {
            _ordersDbContext.Orders.Add(order);
            await _ordersDbContext.SaveChangesAsync();

            return Created($"/blogs{order.Id}", order);
        }

        [HttpPost("save-order-test")]
        public async Task<IActionResult> Post()
        {
            var order = new Order(buyerId: Guid.NewGuid(), address: "Address 1", isDraft: false);
            order.SetAsCreated();
            order.AddOrderItem(name: "Product 1", price: 12.34M, units: 3);
            
            _ordersDbContext.Orders.Add(order);
            await _ordersDbContext.SaveChangesAsync();

            return Created($"/blogs{order.Id}", order);
        }

    }
}
