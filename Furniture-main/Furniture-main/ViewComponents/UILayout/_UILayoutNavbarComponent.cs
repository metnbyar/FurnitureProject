using Microsoft.AspNetCore.Mvc;

namespace Furniture.ViewComponents.UILayout
{
	public class _UILayoutNavbarComponent:ViewComponent

	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
