using Microsoft.AspNetCore.Mvc;

namespace _5Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            // Зчитуємо повідомлення з appsettings.json
            var message = _configuration["MessageSettings:WelcomeMessage"];
            ViewData["Message"] = message;
            return View();
        }
    }
}
