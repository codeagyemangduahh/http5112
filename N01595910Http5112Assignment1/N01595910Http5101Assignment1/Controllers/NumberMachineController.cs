using Microsoft.AspNetCore.Mvc;

namespace N01595910Http5101Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberMachineController : ControllerBase
    {
        /// <summary>
        /// Takes a number and performs some math operations on it
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The Absolute value of the number multiplied by 3, divided by 4 then increased by 32</returns>
        [HttpGet("{id}")]
        public IActionResult PerformMath(int id)
        {
            return Ok((Math.Abs(id) * 3 / 4) + 32);
        }
    }
}
