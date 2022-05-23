using Microsoft.AspNetCore.Mvc;

namespace Asp_products_task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
