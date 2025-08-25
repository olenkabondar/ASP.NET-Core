using Microsoft.AspNetCore.Mvc;
    /*Створіть порожню ASP.NET Core програму. Внесіть до нього потрібні зміни для використання MVC.
     * Зробіть необхідні зміни в проекті, щоб при запиті /Test/Message відображалася сторінка з повідомленням Hello world,
     * а при запиті List/Info - відображався список <ul> з трьома елементами і довільним текстом.*/
namespace _3Task.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Message()
        {
            return Content("Hello world", "text/plain");
        }
    }
}
