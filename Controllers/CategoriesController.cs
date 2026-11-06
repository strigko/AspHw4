using Microsoft.AspNetCore.Mvc;
using AspHw4.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspHw4.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DataContext _context;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();

            return View(categories);
        }

        public IActionResult Create()
        {
            var categories = _context.Categories.ToList();

            Console.WriteLine($"Categories found: {categories.Count}");

            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(
                    _context.Categories.ToList(),
                    "Id",
                    "Name"
                );

                return View(product);
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}