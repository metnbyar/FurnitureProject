using Furniture.DataAccess.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Furniture.ViewComponents.UILayout
{
    public class _UILayoutFooterComponent:ViewComponent
    {
      
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
