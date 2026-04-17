using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class ApplicationsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Applications";
            return View();
        }
    }
}
