using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "News & Announcements";
            return View();
        }
    }
}
