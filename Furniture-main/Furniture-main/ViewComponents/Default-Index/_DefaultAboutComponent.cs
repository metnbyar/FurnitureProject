using Furniture.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace Furniture.ViewComponents.Default_Index
{
    public class _DefaultAboutComponent : ViewComponent
    {
        private readonly FurnitureContext _context;

        public _DefaultAboutComponent(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
