using _1Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1Task.Controllers
{
    public class ValuesController : Controller
    {
        private readonly IStringService _stringService;

        public ValuesController(IStringService stringService)
        {
            _stringService = stringService;
        }

        public IActionResult Index()
        {
            var values = _stringService.GetValues();
            return View(values);
        }
    }
}
