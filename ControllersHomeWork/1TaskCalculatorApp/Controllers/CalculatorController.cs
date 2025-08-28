using _1TaskCalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1TaskCalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model, string operation)
        {
            switch (operation)
            {
                case "Add":
                    model.Result = model.Number1 + model.Number2;
                    break;
                case "Subtract":
                    model.Result = model.Number1 - model.Number2;
                    break;
                case "Multiply":
                    model.Result = model.Number1 * model.Number2;
                    break;
                case "Divide":
                    model.Result = model.Number2 != 0 ? model.Number1 / model.Number2 : double.NaN;
                    break;
            }

            return View(model);
        }
    }
}
