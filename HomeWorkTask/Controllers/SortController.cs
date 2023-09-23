using HomeWorkTask.DTO;
using HomeWorkTask.Utils;
using HomeWorkTask.Utils.SortUtils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HomeWorkTask.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class SortController : ControllerBase
    {
        [HttpPut(Name = "SortNumbers")]
        public IActionResult Put([FromBody] object requestBody) //needs validation that numbers are 1-10
        {
            if (requestBody is null)
                return BadRequest("Invalid request body. Body was null");

            NumbersDTO? numbers = JsonConvert.DeserializeObject<NumbersDTO>(requestBody.ToString());



            if (numbers is null || numbers.Numbers is null) //if left [] doesn't catch
                return BadRequest("Invalid request body");

            if (!Validation.IsRangeValid(numbers.Numbers))
                return BadRequest("Invalid numbers input");

            int[] sortedNumbers = SortHandler.SortNumbers(numbers.Numbers);

            OutUtils.WriteToFile(sortedNumbers);

            return Ok(sortedNumbers);
        }

        [HttpGet(Name = "GetNumbers")]
        public IActionResult Get() //needs validation that numbers are 1-10
        {
            int[] resultNumbers = InUtils.ReadResults();

            return Ok(resultNumbers);
        }
    }
}