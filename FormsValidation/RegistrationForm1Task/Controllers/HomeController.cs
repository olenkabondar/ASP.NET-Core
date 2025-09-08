using Microsoft.AspNetCore.Mvc;
using RegistrationForm1Task.Models;

namespace RegistrationForm1Task.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View(new ConsultationFormModel());
        }

        [HttpPost]
        public IActionResult Register(ConsultationFormModel model)
        {
            if (ModelState.IsValid)
            {            
                ViewBag.Message = "Реєстрація успішна!";
                return View("Success");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
