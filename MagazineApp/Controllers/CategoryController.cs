using Microsoft.AspNetCore.Mvc;

namespace MagazineApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
