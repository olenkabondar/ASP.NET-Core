using _1Task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace _1Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptionsSnapshot<MessageConfig> _messageConfig;

        public HomeController(IOptionsSnapshot<MessageConfig> messageConfig)
        {
            _messageConfig = messageConfig;
        }

        public IActionResult Index()
        {
            // Беремо повідомлення з конфігурації
            string message = _messageConfig.Value.MessageText;
            ViewBag.Message = message;

            return View();
        }
    }
}
