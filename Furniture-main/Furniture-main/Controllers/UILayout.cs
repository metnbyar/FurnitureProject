using Microsoft.AspNetCore.Mvc;

namespace Furniture.Controllers
{
    public class UILayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
