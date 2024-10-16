using Furniture.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Furniture.Areas.Admin.Controllers
{
    public class AllAPI : Controller
    {
        [Area("Admin")]
        [Route("[area]/[controller]/[action]/{id?}")]
        [Authorize]
        public IActionResult Index()
        {

            return View();
        }

    }
}

