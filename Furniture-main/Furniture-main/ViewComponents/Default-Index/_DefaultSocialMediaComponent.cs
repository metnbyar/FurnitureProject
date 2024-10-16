using Furniture.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace Furniture.ViewComponents.Default_Index
{
    public class _DefaultSocialMediaComponent:ViewComponent

    {
        private readonly FurnitureContext _context;

        public _DefaultSocialMediaComponent(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values=_context.SocialMedias.ToList();
            return View(values);
        }
    }
}
