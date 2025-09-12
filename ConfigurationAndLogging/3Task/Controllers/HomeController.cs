using Microsoft.AspNetCore.Mvc;

namespace _3Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CauseError()
        {
            throw new Exception("Тестова помилка для логування!");
        }
    }
}
