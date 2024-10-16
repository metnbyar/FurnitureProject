using Furniture.DataAccess.Entities;
using Furniture.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Furniture.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);// username password kullanıcının girişi sürekli kalsın mı
                                                                                                                // ve kullanıcı 5 ten fazla yanlışşifrede bloke edilsin mi 
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Product", new { area = "Admin" });
            }
            ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı ");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
