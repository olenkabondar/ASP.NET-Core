using _2Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult Menu1()
        {
            return View();
        }

        public IActionResult Menu2()
        {
            return View();
        }

        public IActionResult Menu3()
        {
            return View();
        }
    }
}
