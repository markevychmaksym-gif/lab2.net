using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
