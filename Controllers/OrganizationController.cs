using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class OrganizationController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Organization";
            return View();
        }
    }
}
