using Furniture.DataAccess.Context;
using Furniture.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Furniture.Controllers
{
	public class ContactController : Controller
	{	
		private readonly FurnitureContext _context;

		public ContactController(FurnitureContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var contactInfo = await _context.ContactInfos.FirstOrDefaultAsync();

			// Adres bilgisini ViewBag ile doğru şekilde gönder
			if (contactInfo != null)
			{
				ViewBag.Adres = contactInfo.Address;
				ViewBag.Email = contactInfo.Email;
				ViewBag.Phone = contactInfo.Phone;
			}

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserMessage model)
		{
			if (ModelState.IsValid)
			{
				_context.UserMessages.Add(model);
				await _context.SaveChangesAsync();
				ViewBag.Message = "Mesajınız başarıyla gönderildi!";

				// Formu gönderildikten sonra sayfayı yeniden yüklemeden gösterim için redirect yerine Json kullanılabilir.
				return Json(new { success = true });
			}

			var contactInfo = await _context.ContactInfos.FirstOrDefaultAsync();
			if (contactInfo != null)
			{
				ViewBag.Adres = contactInfo.Address;
				ViewBag.Email = contactInfo.Email;
				ViewBag.Phone = contactInfo.Phone;
			}

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> SendMessage(UserMessage model)
		{
			if (ModelState.IsValid)
			{
				_context.UserMessages.Add(model);
				await _context.SaveChangesAsync();
				return Json(new { success = true });
			}

			return Json(new { success = false });
		}


	}
}
