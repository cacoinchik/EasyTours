using EasyTours.Data;
using Microsoft.AspNetCore.Mvc;

namespace EasyTours.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult AllTours()
        {
            var allTours = db.Tours.ToList();
            return View(allTours);
        }

        [HttpGet]
        public IActionResult Discount()
        {
            var discountTours = db.Tours.Where(x=>x.Discount != null).ToList();
            return View(discountTours);
        }

        [HttpGet]
        public IActionResult TourAbout(int id)
        {
            var tour = db.Tours.FirstOrDefault(x => x.Id == id);
            if (tour == null)
            {
                return NotFound();
            }
            return View(tour);
        }
    }
}
