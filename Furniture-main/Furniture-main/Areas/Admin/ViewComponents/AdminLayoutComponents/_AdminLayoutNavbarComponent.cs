using Furniture.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Furniture.Areas.Admin.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutNavbarComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminLayoutNavbarComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name=user.NameSurname;
            ViewBag.Email=user.Email;

            string api = "b76f7050e5c9eefb3973c2801e80c6c9";
            string city = "ankara";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q="+city+"&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.cityName= document.Descendants("city").ElementAt(0).Attribute("name").Value;
            ViewBag.degree = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.status = document.Descendants("weather").ElementAt(0).Attribute("value").Value;
            return View();  
        }
    }
}
