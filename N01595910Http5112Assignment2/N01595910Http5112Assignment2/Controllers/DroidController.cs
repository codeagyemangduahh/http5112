using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace N01595910Http5112Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DroidController : ControllerBase
    {
        /// <summary>
        /// Calculates delivery score based on the number of packages a bot delivers with penalties for collisions and bonus points for more successful delivery than collisions
        /// </summary>
        /// <param name="numberOfPackages"></param>
        /// <param name="collisions"></param>
        /// <returns>delivery score</returns>
        [HttpGet("j1/packages/{numberOfPackages}/collisions/{collisions}")]
        public IActionResult GetDeliveryPoints(int numberOfPackages, int collisions)
        {
            int packagesScore = numberOfPackages * 50;
            int collisionScore = collisions * 10;
            int bonus = numberOfPackages > collisions ? 500 : 0;

            if (numberOfPackages < 0)
                return BadRequest("Number of packages should not be negative");

            if (collisions < 0)
                return BadRequest("collisions should not be negative");

            return Ok(packagesScore - collisionScore + bonus);
        }
    }
}
