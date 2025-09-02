using Microsoft.AspNetCore.Mvc;

namespace _1TaskStaticValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.OnlineUsers = OnlineUsersMiddleware.GetOnlineUsers();
            return View();
        }
    }
}
