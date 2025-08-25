using Microsoft.AspNetCore.Mvc;

namespace CalculateApp.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return Content("use one of variant (add, sub, mul, div) like https://localhost/Calc/Add/20/10");
        }
        public IActionResult Add(int a, int b)
        {
            return Content((a + b).ToString());
        }

        public IActionResult Sub(int a, int b)
        {
            return Content((a - b).ToString());
        }

        public IActionResult Mul(int a, int b)
        {
            return Content((a * b).ToString());
        }

        public IActionResult Div(int a, int b)
        {
            if (b == 0)
                return Content("Division by zero!");
            return Content((a / b).ToString());
        }
    }
}
