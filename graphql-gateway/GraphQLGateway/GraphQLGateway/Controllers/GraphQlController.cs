using Microsoft.AspNetCore.Mvc;

namespace GraphQLGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GraphQlController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
