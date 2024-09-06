using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        SalesDbContext _context;

        public HomeController(SalesDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> prodList = _context.Products.ToList();
            return View(prodList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product prod)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(prod);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prod);
        }

        public IActionResult Details(int id)
        {
            Product pr = _context.Products.Find(id);
            return View(pr);
        }
        public IActionResult Edit(int id)
        {
            Product product = _context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product pr)
        {
            _context.Products.Update(pr);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) {
            Product pr = _context.Products.Find(id);
            return View(pr);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteInfo(Product pr)
        {
            _context.Products.Remove(pr);
            _context.SaveChanges(true);
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
