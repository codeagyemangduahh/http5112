using Microsoft.AspNetCore.Mvc;

namespace N01595910Http5101Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquareController : ControllerBase
    {
        /// <summary>
        /// Takes a number and returns its square
        /// </summary>
        /// <param name="id"></param>
        /// <returns>square of input</returns>
        [HttpGet("{id}")]
        public IActionResult Square(int id)
        {
            return Ok(Math.Pow(id, 2));
        }
    }
}
