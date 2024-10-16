using Furniture.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Furniture.Areas.Admin.ViewComponents.AdminLayoutComponents
{
    public class _AdminWeatherAPIComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string api = "b76f7050e5c9eefb3973c2801e80c6c9";
            string city = "gaziantep";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.cityName = document.Descendants("city").ElementAt(0).Attribute("name").Value;
            ViewBag.degree = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.status = document.Descendants("weather").ElementAt(0).Attribute("value").Value;
            // Dereceyi string olarak alıyoruz
            string degreeString = ViewBag.degree.ToString();

            // Sadece tam kısmını alıyoruz (ilk iki karakter)
            if (degreeString.Length > 1)
            {
                degreeString = degreeString.Substring(0, 2);
            }
            else
            {
                degreeString = degreeString.Substring(0, 1);
            }

            // Yeni değeri ViewBag'e atıyoruz
            ViewBag.degree = degreeString;
            return View();
        }
    }
}
