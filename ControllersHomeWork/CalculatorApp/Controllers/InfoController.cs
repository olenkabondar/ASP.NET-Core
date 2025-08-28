using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            var ip = HttpContext.Connection.RemoteIpAddress?.ToString();
            var userAgent = HttpContext.Request.Headers["User-Agent"].ToString();

            ViewBag.IP = ip;
            ViewBag.Browser = userAgent;

            return View();
        }
    }
}
