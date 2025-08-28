using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    /*
     * Завдання 5 Створіть веб-додаток. Додайте модель, яка представлятиме колекцію об'єктів із властивостями Id, Price, Name. 
     * Заповніть колекцію випадковими значеннями. Зробіть контролер Products з методом доступу Index, який повертає подання з усіма даними моделі. 
     * Зробіть передачу даних у виставу двома способами, через ViewBag і через строго типізоване уявлення. 
     * З якими складнощами Ви зіткнулися під час реалізації уявлень двома різними способами?
     */
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            // Генеруємо випадкові дані
            var random = new Random();
            var products = new List<Product>();

            for (int i = 1; i <= 5; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Price = Math.Round((decimal)(random.NextDouble() * 100), 2)
                });
            }

            //Передаємо двома способами
            ViewBag.Products = products;   // спосіб 1
            return View(products);         // спосіб 2 (строго типізоване уявлення)
        }
    }
}
