using Microsoft.AspNetCore.Mvc;

namespace N01595910Http5101Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        /// <summary>
        /// Says Hello
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Hello World</returns>
        [HttpPost("")]
        public IActionResult SayHello()
        {
            return Ok("Hello world!");
        }

        /// <summary>
        /// Takes a number and returns its square
        /// </summary>
        /// <param name="id"></param>
        /// <returns>square of input</returns>
        [HttpGet("{id}")]
        public IActionResult SayGreeting(int id)
        {
            return Ok($"Greetings to {id} people");
        }
    }
}
