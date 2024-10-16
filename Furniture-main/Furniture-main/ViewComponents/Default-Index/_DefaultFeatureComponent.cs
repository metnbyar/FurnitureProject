using Furniture.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace Furniture.ViewComponents.Default_Index
{
	public class _DefaultFeatureComponent : ViewComponent
	{
		private readonly FurnitureContext _context;

		public _DefaultFeatureComponent(FurnitureContext context)
		{
			_context = context;
		}


		public IViewComponentResult Invoke()
		{
			var values=_context.Features.ToList();
			return View(values); 
		}	
	}
}
