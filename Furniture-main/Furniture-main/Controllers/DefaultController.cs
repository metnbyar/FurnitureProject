using Microsoft.AspNetCore.Mvc;

namespace Furniture.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
