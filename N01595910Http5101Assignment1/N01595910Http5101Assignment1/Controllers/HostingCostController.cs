using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace N01595910Http5101Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostingCostController : ControllerBase
    {
        /// <summary>
        /// Calculates the cost of web hosting and maintenance
        /// </summary>
        /// <param name="id"></param>
        /// <returns>cost</returns>
        [HttpGet("{id}")]
        public IActionResult CalculateHostingCost(int id)
        {
            StringBuilder builder = new StringBuilder();
            double fortNights = Math.Ceiling(id > 14D ? id / 14D : 1D);
            double subTotal = fortNights * 5.50;
            double hst = 0.13 * subTotal;
            double total = subTotal + hst;
            builder.AppendLine($"{(int) fortNights} fortnights at $5.50/FN = ${Math.Round(subTotal, 2)} CAD");
            builder.AppendLine($"HST 13% = ${Math.Round(hst,2)} CAD");
            builder.AppendLine($"Total = ${Math.Round(total,2)} CAD");
            return Ok(builder.ToString());
        }

    }
}
