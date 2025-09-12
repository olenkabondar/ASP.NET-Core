using _1TaskActionFilter.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _1TaskActionFilter.Controllers
{
    public class HomeController : Controller
    {
        [ServiceFilter(typeof(UniqueUserCounterFilter))]
        public IActionResult Index()
        {
            // Беремо кількість з HttpContext
            ViewBag.UniqueUsers = HttpContext.Items["UniqueUserCount"];
            return View();
        }
    }
}
