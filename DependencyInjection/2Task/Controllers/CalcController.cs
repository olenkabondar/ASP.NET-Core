using _2Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2Task.Controllers
{
    public class CalcController : Controller
    {
        private readonly ICalcService _calcService;

        public CalcController(ICalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int a, int b)
        {
            var result = _calcService.Add(a, b);
            return View("Result", result);
        }

        [HttpPost]
        public IActionResult Subtract(int a, int b)
        {
            var result = _calcService.Subtract(a, b);
            return View("Result", result);
        }

        [HttpPost]
        public IActionResult Multiply(int a, int b)
        {
            var result = _calcService.Multiply(a, b);
            return View("Result", result);
        }

        [HttpPost]
        public IActionResult Divide(int a, int b)
        {
            try
            {
                var result = _calcService.Divide(a, b);
                return View("Result", result);
            }
            catch (DivideByZeroException ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
