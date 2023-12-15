using EasyTours.Data;
using EasyTours.Models;
using EasyTours.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyTours.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext db;

        public OrderController(AppDbContext db)
        {
            this.db = db; 
        }

        [HttpGet]
        public IActionResult OrderList()
        {
            var orders = db.Orders.Include(x=>x.Tour).ToList();
            return View(orders);
        }
        
        [HttpGet]
        public IActionResult Index(int id)
        {
            OrderViewModel model = new OrderViewModel();
            var tour = db.Tours.FirstOrDefault(x => x.Id == id);
            if(tour != null)
            {
                model.TourId = tour.Id;
                if(tour.Discount != null)
                    model.Price = (decimal)tour.Discount;
                else
                    model.Price = tour.Price;
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(OrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                var order = new Order
                {
                    TourId = model.TourId,
                    Surname = model.Surname,
                    Name = model.Name,
                    Patronymic = model.Patronymic,
                    Age = model.Age,
                    Count = model.Count
                };
                if (model.IsAddDiscount)
                    model.Price = model.Price * 0.9m;
                if(model.IsNewlyweds)
                    model.Price = model.Price * 0.85m;
                var finalPrice = model.Price * model.Count;
                order.Price = finalPrice;

                var tour = db.Tours.FirstOrDefault(x=>x.Id == order.TourId);
                if(tour != null)
                {
                    tour.Count = tour.Count - model.Count;
                    db.Tours.Update(tour);
                }

                db.Orders.Add(order);
                db.SaveChanges();

                return Redirect("/");
            }
            return View(model);
        }

        public IActionResult OrderDetail(int id)
        {
            var order = db.Orders.Include(x=>x.Tour).FirstOrDefault(x=>x.Id == id);
            return View(order);
        }
    }
}
