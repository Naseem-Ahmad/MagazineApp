using MagazineApp.Data;
using MagazineApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagazineApp.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList=_db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
