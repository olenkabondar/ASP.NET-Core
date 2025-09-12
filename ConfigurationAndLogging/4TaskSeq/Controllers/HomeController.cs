using Microsoft.AspNetCore.Mvc;

namespace _4TaskSeq.Controllers
{
    public class HomeController : Controller
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

        // Метод для виклику тестової помилки
        public IActionResult CauseError()
        {
            try
            {
                throw new Exception("Тестова помилка для Seq!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Сталася помилка!");
                throw; // щоб стандартна обробка помилок спрацювала
            }
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
