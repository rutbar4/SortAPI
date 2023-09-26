using HomeWorkTask.DTO;
using HomeWorkTask.Utils;
using HomeWorkTask.Utils.SortUtils;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkTask.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class SortController : ControllerBase
    {
        [HttpPost]
        public IActionResult SortNumbers([FromBody] NumbersItem numbers)
        {
            if (numbers is null || numbers.Numbers is null)
                return BadRequest("Invalid request body");

            if (!Validation.IsRangeAndLengthValid(numbers.Numbers))
                return BadRequest("Invalid numbers input");

            var sortedNumbers = SortHandler.SortNumbers(numbers);

            InOutUtils.WriteToFile(sortedNumbers);

            return Ok(sortedNumbers);
        }

        [HttpGet]
        public IActionResult SortedNumbers()
        {
            var resultNumbers = InOutUtils.ReadResults();

            if (resultNumbers is null) return NotFound("File does not exist");

            return Ok(resultNumbers);
        }
    }
}