using Microsoft.AspNetCore.Mvc;

namespace Furniture.Areas.Admin.ViewComponents.AdminLayoutComponents
{
    public class _AdminSidebarComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
