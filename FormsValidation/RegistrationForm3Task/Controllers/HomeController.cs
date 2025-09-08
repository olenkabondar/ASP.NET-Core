using Microsoft.AspNetCore.Mvc;
using RegistrationForm3Task.Models;
using System.Diagnostics;

namespace RegistrationForm3Task.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(ConsultationFormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Success", model);
            }

            return View(model);
        }
    }
}
