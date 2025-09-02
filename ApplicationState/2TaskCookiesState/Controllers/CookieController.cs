using _2TaskCookiesState.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2TaskCookiesState.Controllers
{
    public class CookieController : Controller
    {
        // Форма для введення
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Обробка відправленої форми
        [HttpPost]
        public IActionResult Index(CookieFormModel model)
        {
            if (ModelState.IsValid)
            {
                // Зберігаємо в Cookies
                var options = new CookieOptions
                {
                    Expires = model.ExpirationDate
                };

                Response.Cookies.Append("MyValue", model.Value, options);

                ViewBag.Message = "Cookie збережено!";
            }
            return View(model);
        }

        // Перевірка наявності Cookies
        [HttpGet]
        public IActionResult Check()
        {
            string value = Request.Cookies["MyValue"];
            if (string.IsNullOrEmpty(value))
            {
                ViewBag.CookieStatus = "Cookie відсутній або неактивний.";
            }
            else
            {
                ViewBag.CookieStatus = $"Cookie знайдено! Значення: {value}";
            }

            return View();
        }
    }
}
