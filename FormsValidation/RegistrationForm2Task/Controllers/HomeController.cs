using Microsoft.AspNetCore.Mvc;
using RegistrationForm2Task.Models;

namespace RegistrationForm2Task.Controllers
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
