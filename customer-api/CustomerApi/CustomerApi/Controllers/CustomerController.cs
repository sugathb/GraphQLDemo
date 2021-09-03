using Microsoft.AspNetCore.Mvc;
using CustomerApi.Models;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var customer = new Customer
            {
                CustomerId = 1,
                FirstName = "John",
                LastName = "Pfizer",
                Address = "Sample Address 1",
                Mobile = "0444111111",
                Email = "test@testmail.com"
            };

            return Ok(customer);
        }
    }
}
