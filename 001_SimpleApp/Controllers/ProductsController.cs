using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;

namespace SimpleApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductReader _reader;
        public ProductsController()
        {
            _reader = new ProductReader();
        }

        // Products/List
        public IActionResult List(string category)
        {
            List<Product> products = _reader.ReadFromFile();
            if(category != null)
            {
                products = products.Where(x => x.Category.ToLower() == category.ToLower()).ToList();               
            }
            return View(products);
        }

        // Products/Details/1
        public IActionResult Details(int id)
        {
            List<Product> products = _reader.ReadFromFile();
            Product product = products.Where(x => x.Id == id).FirstOrDefault();

            if (product != null)
            {
                return View(product);
            }
            else
            {
                // Повернення помилки 404
                return NotFound();
            }
        }
    }
}