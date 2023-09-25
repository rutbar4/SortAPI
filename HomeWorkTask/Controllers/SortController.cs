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

            if (!Validation.IsRangeValid(numbers.Numbers))
                return BadRequest("Invalid numbers input");

            int[] sortedNumbers = SortHandler.SortNumbers(numbers.Numbers);

            InOutUtils.WriteToFile(sortedNumbers);

            return Ok(sortedNumbers);
        }

        [HttpGet]
        public IActionResult Numbers()
        {
            int[] resultNumbers = InOutUtils.ReadResults();

            return Ok(resultNumbers);
        }
    }
}