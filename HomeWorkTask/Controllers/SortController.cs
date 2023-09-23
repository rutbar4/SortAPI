using HomeWorkTask.Utils;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkTask.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class SortController : ControllerBase
    {
        private readonly ILogger<SortController> _logger;

        public SortController(ILogger<SortController> logger)
        {
            _logger = logger;
        }

        [HttpPut(Name = "SortNumbers")]
        public void Put(int[] numbers)
        {
            int[] sortedNumbers = SortAlgorithms.BubbleSort(numbers);
            OutUtils.WriteToFile(sortedNumbers);
            //get numbers that are sent
            //call methods for action
              //method sorts numbers
              //prints to file 
        }
    }
}