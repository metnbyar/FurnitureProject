using Furniture.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Furniture.Areas.Admin.ViewComponents.AdminLayoutComponents
{
    public class _AdminInstagramAPIComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/bilisimbelsoft"),
                Headers =
    {
        { "x-rapidapi-key", "f7eaa69decmsh72ca1057b6751f4p11862cjsn181dab7e0ec3" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                InstagramViewModel viewModel = JsonConvert.DeserializeObject<InstagramViewModel>(body);
                return View(viewModel);
            }

        }

    }

}



