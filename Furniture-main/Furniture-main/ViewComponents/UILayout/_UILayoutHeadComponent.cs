using Microsoft.AspNetCore.Mvc;

namespace Furniture.ViewComponents.UILayout
{
	public class _UILayoutHeadComponent:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View();
		}	
	}
}
