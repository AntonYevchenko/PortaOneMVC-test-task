using Microsoft.AspNetCore.Mvc;
using PortaOneMVC.Models;
using System.Diagnostics;

namespace PortaOneMVC.Controllers
{
    public class HomeController:Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessFile(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    var numbers = WorkWithFiles.ReadNumbersToList(reader);

                    var result = new CalculationResult
                    {
                        MinNumber = Calculate.FindMinNumber(numbers),
                        MaxNumber = Calculate.FindMaxNumber(numbers),
                        AverageNumber = Calculate.FindAverageNumber(numbers),
                        Median = Calculate.FindMedian(numbers.ConvertAll(x => (double) x)),
                        LongestIncreasingSequence = Calculate.FindLongestIncreasingSequence(numbers),
                        LongestDecreasingSequence = Calculate.FindLongestDecreasingSequence(numbers)
                    };

                    return View("Result", result);
                }
            }

            return View("Error");
        }

        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
