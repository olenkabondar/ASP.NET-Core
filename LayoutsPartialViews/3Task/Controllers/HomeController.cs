using Microsoft.AspNetCore.Mvc;

namespace _3Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Ласкаво просимо! Це головна сторінка!";
            return View();
        }

        public IActionResult Page1()
        {
            ViewData["Message"] = "Ви на сторінці 1.";
            return View();
        }

        public IActionResult Page2()
        {
            ViewData["Message"] = "Ви на сторінці 2.";
            return View();
        }
    }
}
