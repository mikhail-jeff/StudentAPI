using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        //[HttpGet]
        //public string Greetings()
        //{
        //    return "Hello World...";
        //}

        //[HttpGet]
        //public IActionResult Goodnight()
        //{
        //    return Ok("night night motherfucker");

        //    return NoContent();
        //}

        [HttpGet]
        public ActionResult<string> Greet()
        {
            return "Hello World...";
        }
    }
}
 