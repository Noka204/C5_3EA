using Microsoft.AspNetCore.Mvc;

namespace FloralShop.Controllers {
    public class HomeController : Controller {
        // GET: /  ho?c /Home/Index
        public IActionResult Index()
        {
            ViewData["Title"] = "Trang Ch?";
            return View();
        }

        // GET: /Home/About
        public IActionResult About()
        {
            ViewData["Title"] = "Gi?i Thi?u";
            return View();
        }

        // GET: /Home/Products
        public IActionResult Products()
        {
            ViewData["Title"] = "S?n Ph?m";
            return View();
        }

        // GET: /Home/Specials
        public IActionResult Specials()
        {
            ViewData["Title"] = "Khuy?n Mãi";
            return View();
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            ViewData["Title"] = "Liên H?";
            return View();
        }
    }
}
