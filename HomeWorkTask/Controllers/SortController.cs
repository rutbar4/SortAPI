using HomeWorkTask.DTO;
using HomeWorkTask.Utils;
using HomeWorkTask.Utils.SortUtils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

//{
//    "numbers": [
//      0
//  ]
//}

namespace HomeWorkTask.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class SortController : ControllerBase
    {
        [HttpPost]
        public IActionResult SortNumbers([FromBody] NumbersItem numbers) //TEST: repeating numbers. numbers with dot
        {
            if (numbers is null || numbers.Numbers is null)
                return BadRequest("Invalid request body");

            if (!Validation.IsRangeValid(numbers.Numbers))
                return BadRequest("Invalid numbers input");

            int[] sortedNumbers = SortHandler.SortNumbers(numbers.Numbers);

            OutUtils.WriteToFile(sortedNumbers);

            return Ok(sortedNumbers);
        }

        [HttpGet]
        public IActionResult Numbers()
        {
            int[] resultNumbers = InUtils.ReadResults();

            return Ok(resultNumbers);
        }
    }
}