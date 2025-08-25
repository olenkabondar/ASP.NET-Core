using Microsoft.AspNetCore.Mvc;

namespace _3Task.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            string html = "<ul>" +
                          "<li>First element</li>" +
                          "<li>Second element</li>" +
                          "<li>Threed element</li>" +
                          "</ul>";

            return Content(html, "text/html");
        }
    }
}
