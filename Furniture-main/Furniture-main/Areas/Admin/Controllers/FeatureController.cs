using Furniture.DataAccess.Context;
using Furniture.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Furniture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    [Authorize]
    public class FeatureController : Controller
    {
        private readonly FurnitureContext _context;

        public FeatureController(FurnitureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Features.ToList();
            return View(values);
        }

        public IActionResult DeleteFeature(int id)
        {
            var value = _context.Features.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature Feature)
        {
            _context.Add(Feature);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = _context.Features.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature Feature)
        {
            _context.Features.Update(Feature);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
