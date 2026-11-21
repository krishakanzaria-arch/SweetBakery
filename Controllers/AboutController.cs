using Microsoft.AspNetCore.Mvc;

namespace SweetBakery.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}