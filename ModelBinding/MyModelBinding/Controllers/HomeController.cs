using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyModelBinding.Models;

namespace MyModelBinding.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new MyFormModel()); // передаємо порожню модель
        }

        [HttpPost]
        public IActionResult Index(MyFormModel model)
        {
            Debug.WriteLine($"First: {model.First}");
            Debug.WriteLine($"Second: {model.Second}");
            Debug.WriteLine($"Count: {model.Count}");

            return View(); // повертаємо модель назад у View
        }
    }
}
