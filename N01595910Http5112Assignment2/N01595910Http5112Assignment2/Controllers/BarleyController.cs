using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace N01595910Http5112Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarleyController : ControllerBase
    {
        /// <summary>
        /// Calculates the treat score of Barley the dog and returns a value indicating whether barley is happy or sad
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <param name="l"></param>
        /// <returns>returns happy is treat score is 10 or more. Else, returns sad</returns>
        [HttpGet("treats/small/{s}/medium/{m}/large/{l}")]
        public IActionResult CalculateDogTreat(int s, int m, int l)
        {
            int treatScore = 1 * s + 2 * m + 3 * l;

            return Ok(treatScore >= 10 ? "happy" : "sad");
        }
    }
}
