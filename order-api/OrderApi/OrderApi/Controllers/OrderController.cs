using Microsoft.AspNetCore.Mvc;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
       
        [HttpGet]
        public IActionResult Get()
        {
            var order = new Order {OrderId = 1, CustomerId = 1, TotalPrice = 10};
            return Ok(order);
        }
    }
}
