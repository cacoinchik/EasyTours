using EasyTours.Data;
using EasyTours.Models;
using EasyTours.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EasyTours.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext db;

        public AdminController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var allTours = db.Tours.ToList();
            return View(allTours);
        }

        public IActionResult Delete(int id)
        {
            var tour = db.Tours.FirstOrDefault(x => x.Id == id);
            if (tour == null)
            {
                return NotFound();
            }
            db.Tours.Remove(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddTour()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTour(AddTourViewModel model)
        {
            if (ModelState.IsValid)
            {
                var tour = new Tour
                {
                    HotelName = model.HotelName,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    DepartureStartTime = model.DepartureStartTime,
                    DepartureEndTime = model.DepartureEndTime,
                    ArrivalStartTime = model.ArrivalStartTime,
                    ArrivalEndTime = model.ArrivalEndTime,
                    Price = model.Price,
                    Discount = model.Discount,
                    DeparturePoint = model.DeparturePoint,
                    ArrivalCountry = model.ArrivalCountry,
                    ArrivalPoint = model.ArrivalPoint,
                    Description = model.Description,
                    Count = model.Count
                };

                db.Tours.Add(tour);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
