using Microsoft.AspNetCore.Mvc;

namespace EasyTours.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
