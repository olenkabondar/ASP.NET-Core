using _2Task.Models;
using _2Task.Services;
using Microsoft.AspNetCore.Mvc;

namespace _2Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmailService _emailService;

        public HomeController(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(EmailFormModel model)
        {
            //змінити дані в appsettings
            if (!ModelState.IsValid)
                return View(model);

            try
            {
                _emailService.SendEmail(model.To, model.Subject, model.Body);
                ViewBag.Message = "Лист успішно надіслано!";
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Помилка при відправці: {ex.Message}";
            }

            return View(model);
        }
    }
}
