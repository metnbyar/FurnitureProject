using Microsoft.AspNetCore.Mvc;

namespace Furniture.Controllers
{
	public class AdminLayout : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
