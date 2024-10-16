using Furniture.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace Furniture.ViewComponents.Default_Index
{
    public class _DefaultServiceComponent : ViewComponent

    {
        private readonly FurnitureContext _context;

        public _DefaultServiceComponent(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Services.ToList();

            return View(values);
        }
    }
}
