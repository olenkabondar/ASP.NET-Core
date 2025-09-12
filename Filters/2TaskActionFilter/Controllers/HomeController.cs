using _2TaskActionFilter.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _2TaskActionFilter.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _logFile = "action_log.txt";

        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult Index()
        {
            // Читаємо останній запис із файлу
            string lastLog;
            if (System.IO.File.Exists(_logFile))
            {
                var allLines = System.IO.File.ReadAllLines(_logFile);
                lastLog = allLines.Length > 0 ? allLines[^1] : "Логів ще нема.";
            }
            else
            {
                lastLog = "Логів ще нема.";
            }

            ViewBag.LastLog = lastLog;
            return View();
        }

        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult About()
        {
            string lastLog;
            if (System.IO.File.Exists(_logFile))
            {
                var allLines = System.IO.File.ReadAllLines(_logFile);
                lastLog = allLines.Length > 0 ? allLines[^1] : "Логів ще нема.";
            }
            else
            {
                lastLog = "Логів ще нема.";
            }

            ViewBag.LastLog = lastLog;
            return View();
        }
    }
}
