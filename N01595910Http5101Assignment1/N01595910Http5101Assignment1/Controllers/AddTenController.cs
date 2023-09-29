using Microsoft.AspNetCore.Mvc;

namespace N01595910Http5101Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddTenController : ControllerBase
    {
        /// <summary>
        /// Takes a number and returns 10 more
        /// </summary>
        /// <param name="id"></param>
        /// <returns>input + 10</returns>
        [HttpGet("{id}")]
        public IActionResult AddTen(int id)
        {
            return Ok(id + 10);
        }
    }
}
