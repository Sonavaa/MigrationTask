using FirstMigration.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace FirstMigration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Sizes()
        {
            var db = new AppDBContext();
            var Sizes = db.Sizes.ToList();
            return View(Sizes);
        }
        public IActionResult Colors()
        {
            var db = new AppDBContext();
            var Sizes = db.Colors.ToList();
            return View(Colors);
        }
        public IActionResult Brands()
        {
            var db = new AppDBContext();
            var Sizes = db.Brands.ToList();
            return View(Brands);
        }
    }
}
