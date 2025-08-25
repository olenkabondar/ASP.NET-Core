using Microsoft.AspNetCore.Mvc;

namespace _3Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string result = "add /List/Info/ or /Test/Message/ in your url";
            return Content(result, "text/plain");
        }
    }
}
