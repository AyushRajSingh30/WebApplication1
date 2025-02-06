using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMessageController : ControllerBase
    {
        [HttpGet]
        [Route("GetMessage")]
        public IActionResult GetMessage()
        {
            return Ok("Hello World!");
        }

    }
}
