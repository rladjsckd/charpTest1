using Microsoft.AspNetCore.Mvc;

namespace EmptyBootstrap01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
