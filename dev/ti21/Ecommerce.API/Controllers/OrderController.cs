using Ecommerce.Domain.Services;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("[controller]")]

    public class OrderController : ControllerBase
{
    public OrderController(){

    }
    [HttpPost]
    public AcceptedResult Create(Order order)
    {

        OrderService.Add(order);
        return Accepted(order);
    }

    [HttpGet("Get all orders")]
    public ActionResult<List<Order>> GetAll() => OrderService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Order> GetById(Guid id)
    {
        var order = OrderService.GetById(id);
        if (order is null)
        {
            return NotFound();
        }
        else
        {
            return order;
        }
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        
        if (id == 0)
        {
            return NotFound();
        }
        OrderService.Delete(id);
        return Accepted();
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, Order order){
        if (order is null || id==0)
        {
            return NotFound();
        }else{
            OrderService.Update(order);
            return Accepted(order);
        }
    }
}
    



