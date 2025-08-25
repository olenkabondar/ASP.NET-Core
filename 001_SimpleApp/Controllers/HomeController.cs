using Microsoft.AspNetCore.Mvc;

namespace _001_SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // «Завантажити опис уроку»
        public IActionResult DownloadLesson()
        {
            // шлях до файлу (наприклад у папці wwwroot/files)
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "LessonDescription.txt");

            // перевірка чи існує файл
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("Файл не знайдено");
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var fileName = "LessonDescription.txt";

            // повертаємо файл
            return File(fileBytes, "application/octet-stream", fileName);
        }
    }
}
