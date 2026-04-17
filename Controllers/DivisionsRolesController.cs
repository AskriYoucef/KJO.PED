using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class DivisionsRolesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Divisions & Roles";
            return View();
        }
    }
}
